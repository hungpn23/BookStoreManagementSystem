using BookStoreManagementSystem.Models;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace BookStoreManagementSystem.DataAccess 
{
    public class BookRentalRepository
    {
        /// <summary>
        /// Lấy tất cả thông tin thuê sách chi tiết để hiển thị lên DataGridView.
        /// Hàm này trả về chính xác các cột bạn yêu cầu.
        /// </summary>
        /// <returns>Một DataTable chứa dữ liệu đã JOIN.</returns>
        public DataTable GetAllRentalsWithDetailsForDGV()
        {
            // Câu SQL này JOIN 3 bảng:
            // 1. book_rentals (r) - Bảng chính
            // 2. books (b) - Để lấy tên sách (book_name)
            // 3. customers (c) - Để lấy tên khách hàng (customer_name)
            string sql = @"
                SELECT 
                    -- 1. Các cột ẩn bạn yêu cầu (dùng cho logic, không hiển thị)
                    r.id, 
                    r.book_id, 
                    r.customer_id, 
                    
                    -- 2. Các cột hiển thị bạn yêu cầu
                    b.name AS book_name,
                    c.full_name AS customer_name,
                    r.rental_date, 
                    r.due_date, 
                    r.actual_return_date, 
                    r.daily_fee_at_rental, 
                    r.total_fee, 
                    r.status 
                FROM 
                    book_rentals r
                JOIN 
                    books b ON r.book_id = b.id
                JOIN 
                    customers c ON r.customer_id = c.id
                ORDER BY 
                    r.due_date ASC;
            ";

            return DatabaseHelper.GetDataTable(sql);
        }

        /// <summary>
        /// MỚI: Tìm kiếm lượt thuê theo nhiều tiêu chí.
        /// </summary>
        public DataTable SearchRentalsWithDetails(BookRentalSearchCriteria criteria)
        {
            var sqlBuilder = new StringBuilder(@"
                SELECT 
                    r.id, r.book_id, r.customer_id, 
                    b.name AS book_name,
                    c.full_name AS customer_name,
                    r.rental_date, r.due_date, r.actual_return_date, 
                    r.daily_fee_at_rental, r.total_fee, r.status 
                FROM 
                    book_rentals r
                JOIN 
                    books b ON r.book_id = b.id
                JOIN 
                    customers c ON r.customer_id = c.id
                WHERE 1=1 
            ");

            var parameters = new List<NpgsqlParameter>();


            if (criteria.CustomerId.HasValue)
            {
                sqlBuilder.Append(" AND r.customer_id = @customerId");
                parameters.Add(new NpgsqlParameter("@customerId", NpgsqlDbType.Integer) { Value = criteria.CustomerId.Value });
            }

            if (criteria.BookId.HasValue)
            {
                sqlBuilder.Append(" AND r.book_id = @bookId");
                parameters.Add(new NpgsqlParameter("@bookId", NpgsqlDbType.Integer) { Value = criteria.BookId.Value });
            }

            if (criteria.Status.HasValue)
            {
                sqlBuilder.Append(" AND r.status = @status");
                parameters.Add(new NpgsqlParameter("@status", NpgsqlDbType.Varchar) { Value = criteria.Status.Value.ToString() });
            }

            if (criteria.DateFrom.HasValue)
            {
                sqlBuilder.Append(" AND CAST(r.rental_date AS DATE) >= @dateFrom");
                parameters.Add(new NpgsqlParameter("@dateFrom", NpgsqlDbType.Date) { Value = criteria.DateFrom.Value.Date });
            }

            if (criteria.DateTo.HasValue)
            {
                sqlBuilder.Append(" AND CAST(r.rental_date AS DATE) <= @dateTo");
                parameters.Add(new NpgsqlParameter("@dateTo", NpgsqlDbType.Date) { Value = criteria.DateTo.Value.Date });
            }

            sqlBuilder.Append(" ORDER BY r.rental_date DESC;");

            return DatabaseHelper.GetDataTable(sqlBuilder.ToString(), parameters.ToArray());
        }

        /// <summary>
        /// MỚI: Hàm cho nghiệp vụ "Gia hạn" (btnExtend_Click)
        /// </summary>
        public void UpdateDueDate(int rentalId, DateTime newDueDate)
        {
            string sql = @"
                UPDATE book_rentals 
                SET 
                    due_date = @newDueDate,
                    status = CASE 
                               WHEN status = 'Overdue' THEN 'Renting'
                               ELSE status 
                             END
                WHERE 
                    id = @rentalId;
            ";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@newDueDate", NpgsqlDbType.Timestamp) { Value = newDueDate },
                new NpgsqlParameter("@rentalId", NpgsqlDbType.Integer) { Value = rentalId }
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        /// <summary>
        /// MỚI: Hàm tính TotalFee bằng C#
        /// (Đây là logic C# thay thế cho hàm 'calculate_total_fee' trong Postgres)
        /// </summary>
        private float CalculateTotalFee(DateTime rentalDate, DateTime actualReturnDate, float dailyFeeAtRental)
        {
            // 1. Nếu ngày trả <= ngày thuê (lỗi dữ liệu), trả về 0
            if (actualReturnDate <= rentalDate)
            {
                return 0;
            }

            // 2. Tính khoảng thời gian
            TimeSpan duration = actualReturnDate - rentalDate;

            // 3. Lấy tổng số ngày (dưới dạng double) và LÀM TRÒN LÊN (Ceiling)
            //    (Giống hệt logic CEILING(EPOCH / 86400) trong Postgres)
            //    Ví dụ: 2.1 ngày -> 3 ngày
            double totalDaysAsDouble = Math.Ceiling(duration.TotalDays);

            // 4. Chuyển sang kiểu float và tính toán
            return (float)totalDaysAsDouble * dailyFeeAtRental;
        }

        /// <summary>
        /// MỚI: Hàm cho nghiệp vụ "Trả sách" (btnReturnBook_Click)
        /// (Phiên bản này đã được sửa để TÍNH TOÁN BẰNG C#)
        /// </summary>
        public void ReturnBook(int rentalId)
        {
            // Phải dùng Transaction thủ công
            using (var conn = new NpgsqlConnection(DatabaseHelper.GetConnectionString()))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // === BƯỚC 1: Lấy thông tin cần thiết từ DB ===
                        int bookId;
                        float dailyFee;
                        DateTime rentalDate;
                        DateTime returnDate = DateTime.Now; // Dùng 1 mốc thời gian duy nhất

                        // "FOR UPDATE" là để khóa hàng này lại, đảm bảo an toàn
                        string sqlGetInfo = "SELECT book_id, rental_date, daily_fee_at_rental FROM book_rentals WHERE id = @rentalId FOR UPDATE;";

                        using (var cmdGet = new NpgsqlCommand(sqlGetInfo, conn, transaction))
                        {
                            cmdGet.Parameters.AddWithValue("@rentalId", rentalId);

                            // Dùng ExecuteReader vì chúng ta cần nhiều giá trị
                            using (var reader = cmdGet.ExecuteReader())
                            {
                                if (!reader.Read())
                                {
                                    throw new Exception("Không tìm thấy lượt thuê để trả.");
                                }
                                bookId = reader.GetInt32(0); // book_id
                                rentalDate = reader.GetDateTime(1); // rental_date
                                dailyFee = reader.GetFloat(2); // daily_fee_at_rental

                                // Phải đóng Reader trước khi chạy lệnh tiếp theo
                                reader.Close();
                            }
                        }

                        // === BƯỚC 2: Tính toán TotalFee bằng C# ===
                        float calculatedTotalFee = CalculateTotalFee(rentalDate, returnDate, dailyFee);

                        // === BƯỚC 3: Cập nhật bảng book_rentals ===
                        string sqlUpdateRental = @"
                            UPDATE book_rentals 
                            SET 
                                actual_return_date = @returnDate,
                                status = 'Returned',
                                total_fee = @totalFee
                            WHERE 
                                id = @rentalId;
                        ";

                        using (var cmdUpdateRental = new NpgsqlCommand(sqlUpdateRental, conn, transaction))
                        {
                            cmdUpdateRental.Parameters.AddWithValue("@returnDate", returnDate);
                            cmdUpdateRental.Parameters.AddWithValue("@totalFee", calculatedTotalFee);
                            cmdUpdateRental.Parameters.AddWithValue("@rentalId", rentalId);
                            cmdUpdateRental.ExecuteNonQuery();
                        }

                        // === BƯỚC 4: Cập nhật bảng books (trả sách về kho) ===
                        string sqlUpdateBook = "UPDATE books SET current_customer_id = NULL WHERE id = @bookId;";

                        using (var cmdUpdateBook = new NpgsqlCommand(sqlUpdateBook, conn, transaction))
                        {
                            cmdUpdateBook.Parameters.AddWithValue("@bookId", bookId);
                            cmdUpdateBook.ExecuteNonQuery();
                        }

                        // === BƯỚC 5: Hoàn tất Transaction ===
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        // Nếu có lỗi ở bất kỳ bước nào, hủy bỏ
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// MỚI: Hàm cho nghiệp vụ "Thêm Lượt Thuê" (AddRentalForm)
        /// </summary>
        public void CreateRental(int bookId, int customerId, DateTime dueDate)
        {
            using (var conn = new NpgsqlConnection(DatabaseHelper.GetConnectionString()))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // === BƯỚC 1: Lấy thông tin sách và KIỂM TRA SÁCH ===
                        // (Khóa hàng 'books' để đảm bảo không ai thuê cùng lúc)
                        float dailyFee;
                        string sqlGetBookInfo = "SELECT daily_rental_fee, current_customer_id FROM books WHERE id = @bookId FOR UPDATE;";

                        using (var cmdGetBook = new NpgsqlCommand(sqlGetBookInfo, conn, transaction))
                        {
                            cmdGetBook.Parameters.AddWithValue("@bookId", bookId);
                            using (var reader = cmdGetBook.ExecuteReader())
                            {
                                if (!reader.Read())
                                {
                                    reader.Close();
                                    throw new Exception("Sách không tồn tại.");
                                }

                                dailyFee = reader.GetFloat(0); // daily_rental_fee
                                bool isRented = !reader.IsDBNull(1); // current_customer_id
                                reader.Close();

                                if (isRented)
                                {
                                    throw new Exception("Sách này đã được khách hàng khác thuê.");
                                }
                            }
                        }

                        // === BƯỚC 2: Thêm vào book_rentals ===
                        string sqlInsertRental = @"
                            INSERT INTO book_rentals (book_id, customer_id, rental_date, due_date, daily_fee_at_rental, status)
                            VALUES (@bookId, @customerId, @rentalDate, @dueDate, @dailyFee, @status);
                        ";

                        using (var cmdInsert = new NpgsqlCommand(sqlInsertRental, conn, transaction))
                        {
                            cmdInsert.Parameters.AddWithValue("@bookId", bookId);
                            cmdInsert.Parameters.AddWithValue("@customerId", customerId);
                            cmdInsert.Parameters.AddWithValue("@rentalDate", DateTime.Now);
                            cmdInsert.Parameters.AddWithValue("@dueDate", dueDate);
                            cmdInsert.Parameters.AddWithValue("@dailyFee", dailyFee);
                            cmdInsert.Parameters.AddWithValue("@status", RentalStatus.Renting.ToString());
                            cmdInsert.ExecuteNonQuery();
                        }

                        // === BƯỚC 3: Cập nhật bảng books (đánh dấu đã cho thuê) ===
                        string sqlUpdateBook = "UPDATE books SET current_customer_id = @customerId WHERE id = @bookId;";

                        using (var cmdUpdateBook = new NpgsqlCommand(sqlUpdateBook, conn, transaction))
                        {
                            cmdUpdateBook.Parameters.AddWithValue("@customerId", customerId);
                            cmdUpdateBook.Parameters.AddWithValue("@bookId", bookId);
                            cmdUpdateBook.ExecuteNonQuery();
                        }

                        // === BƯỚC 4: Hoàn tất ===
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// MỚI: Hàm cho nghiệp vụ "Xóa Lượt Thuê" (btnDeleteRental_Click)
        /// </summary>
        public void DeleteRental(int rentalId)
        {
            using (var conn = new NpgsqlConnection(DatabaseHelper.GetConnectionString()))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // === BƯỚC 1: Lấy thông tin (để biết có cần cập nhật 'books' không) ===
                        int bookId;
                        string status;
                        string sqlGetInfo = "SELECT book_id, status FROM book_rentals WHERE id = @rentalId FOR UPDATE;";

                        using (var cmdGet = new NpgsqlCommand(sqlGetInfo, conn, transaction))
                        {
                            cmdGet.Parameters.AddWithValue("@rentalId", rentalId);
                            using (var reader = cmdGet.ExecuteReader())
                            {
                                if (!reader.Read())
                                {
                                    reader.Close();
                                    throw new Exception("Không tìm thấy lượt thuê để xóa.");
                                }
                                bookId = reader.GetInt32(0);
                                status = reader.GetString(1);
                                reader.Close();
                            }
                        }

                        // === BƯỚC 2: Xóa khỏi book_rentals ===
                        string sqlDeleteRental = "DELETE FROM book_rentals WHERE id = @rentalId;";
                        using (var cmdDelete = new NpgsqlCommand(sqlDeleteRental, conn, transaction))
                        {
                            cmdDelete.Parameters.AddWithValue("@rentalId", rentalId);
                            cmdDelete.ExecuteNonQuery();
                        }

                        // === BƯỚC 3: Nếu sách ĐANG ĐƯỢC THUÊ, trả sách về kho ===
                        if (status == RentalStatus.Renting.ToString() || status == RentalStatus.Overdue.ToString())
                        {
                            string sqlUpdateBook = "UPDATE books SET current_customer_id = NULL WHERE id = @bookId;";
                            using (var cmdUpdateBook = new NpgsqlCommand(sqlUpdateBook, conn, transaction))
                            {
                                cmdUpdateBook.Parameters.AddWithValue("@bookId", bookId);
                                cmdUpdateBook.ExecuteNonQuery();
                            }
                        }

                        // === BƯỚC 4: Hoàn tất ===
                        transaction.Commit();
                    }
                    catch (Exception)
                    {
                        transaction.Rollback();
                        throw;
                    }
                }
            }
        }

        /// <summary>
        /// Lấy danh sách thuê sách dưới dạng List<T> để dùng cho Crystal Reports
        /// (ĐÃ SỬA ĐỂ KHẮC PHỤC LỖI System.Nullable<>)
        /// </summary>
        public List<RentalReportViewModel> GetAllRentalsForReport()
        {
            // 1. Lấy DataTable từ hàm bạn đã có
            DataTable dt = GetAllRentalsWithDetailsForDGV();

            // 2. Chuyển đổi (convert) DataTable sang List<RentalReportViewModel>
            List<RentalReportViewModel> list = new List<RentalReportViewModel>();

            foreach (DataRow row in dt.Rows)
            {
                RentalReportViewModel item = new RentalReportViewModel
                {
                    book_name = row["book_name"].ToString(),
                    customer_name = row["customer_name"].ToString(),
                    rental_date = Convert.ToDateTime(row["rental_date"]),
                    due_date = Convert.ToDateTime(row["due_date"]),
                    daily_fee_at_rental = Convert.ToSingle(row["daily_fee_at_rental"]),
                    status = row["status"].ToString(),

                    // === SỬA LỖI LOGIC Ở ĐÂY ===

                    // SỬA: Chuyển đổi an toàn sang STRING (thay vì DateTime?)
                    actual_return_date = (row["actual_return_date"] == DBNull.Value)
                                          ? string.Empty // Trả về chuỗi rỗng nếu là NULL
                                          : Convert.ToDateTime(row["actual_return_date"]).ToShortDateString(), // Định dạng ngày

                    // SỬA: Chuyển đổi an toàn sang STRING (thay vì float?)
                    total_fee = (row["total_fee"] == DBNull.Value)
                                 ? string.Empty // Trả về chuỗi rỗng nếu là NULL
                                 : Convert.ToSingle(row["total_fee"]).ToString("N2") // Định dạng số (ví dụ: 123.45)
                };

                list.Add(item);
            }

            return list;
        }
    }
}