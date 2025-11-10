using BookStoreManagementSystem.DataAccess;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Configuration;
using System.Data;

namespace BookStoreManagementSystem.DataAccess
{
    public class RentalRepository
    {
        private string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["BookStoreDb"].ConnectionString;
        }

        /// <summary>
        /// Lấy tất cả lịch sử thuê (Không thay đổi).
        /// </summary>
        public DataTable GetAllRentalsWithDetails()
        {
            string sql = @"
                SELECT 
                    r.id, r.rental_date, r.due_date, r.actual_return_date,
                    r.status, r.daily_fee_at_rental, r.total_due,
                    b.name AS book_name, c.full_name AS customer_name
                FROM 
                    book_rentals r
                JOIN books b ON r.book_id = b.id
                JOIN customers c ON r.customer_id = c.id
                ORDER BY r.rental_date DESC;
            ";
            return DatabaseHelper.GetDataTable(sql);
        }

        /// <summary>
        /// Lấy các sách đang được thuê (Không thay đổi).
        /// </summary>
        public DataTable GetActiveRentals()
        {
            string sql = @"
                SELECT 
                    r.id, r.rental_date, r.due_date, r.status,
                    b.name AS book_name, c.full_name AS customer_name,
                    r.book_id, r.customer_id, r.daily_fee_at_rental
                FROM 
                    book_rentals r
                JOIN books b ON r.book_id = b.id
                JOIN customers c ON r.customer_id = c.id
                WHERE
                    r.status = 'renting' OR r.status = 'overdue'
                ORDER BY
                    r.due_date ASC;
            ";
            return DatabaseHelper.GetDataTable(sql);
        }

        /// <summary>
        /// Xử lý nghiệp vụ Thuê sách mới.
        /// (Đã sửa: Cập nhật 'current_customer_id')
        /// </summary>
        public void CreateNewRental(int bookId, int customerId, DateTime dueDate, float dailyFee)
        {
            string sqlInsertRental = @"
                INSERT INTO book_rentals (book_id, customer_id, due_date, daily_fee_at_rental, status)
                VALUES (@bookId, @customerId, @dueDate, @dailyFee, 'renting');
            ";

            // (Đã sửa: Cập nhật 'current_customer_id')
            string sqlUpdateBook = @"
                UPDATE books 
                SET current_customer_id = @customerId
                WHERE id = @bookId;
            ";

            using (var conn = new NpgsqlConnection(GetConnectionString()))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Lệnh 1 (Không đổi)
                        using (var cmd1 = new NpgsqlCommand(sqlInsertRental, conn, transaction))
                        {
                            cmd1.Parameters.AddWithValue("@bookId", bookId);
                            cmd1.Parameters.AddWithValue("@customerId", customerId);
                            cmd1.Parameters.AddWithValue("@dueDate", dueDate);
                            cmd1.Parameters.AddWithValue("@dailyFee", dailyFee);
                            cmd1.ExecuteNonQuery();
                        }

                        // Lệnh 2 (Cập nhật 'current_customer_id')
                        using (var cmd2 = new NpgsqlCommand(sqlUpdateBook, conn, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@customerId", customerId);
                            cmd2.Parameters.AddWithValue("@bookId", bookId);
                            cmd2.ExecuteNonQuery();
                        }

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
        /// Xử lý nghiệp vụ Trả sách.
        /// (Đã sửa: Cập nhật 'current_customer_id')
        /// </summary>
        public void ReturnBook(int rentalId, int bookId, float totalDue)
        {
            string sqlUpdateRental = @"
                UPDATE book_rentals SET
                    actual_return_date = @returnDate,
                    total_due = @totalDue,
                    status = 'returned'
                WHERE
                    id = @rentalId;
            ";

            // (Đã sửa: Cập nhật 'current_customer_id' thành NULL)
            string sqlUpdateBook = @"
                UPDATE books 
                SET current_customer_id = NULL
                WHERE id = @bookId;
            ";

            using (var conn = new NpgsqlConnection(GetConnectionString()))
            {
                conn.Open();
                using (var transaction = conn.BeginTransaction())
                {
                    try
                    {
                        // Lệnh 1 (Không đổi)
                        using (var cmd1 = new NpgsqlCommand(sqlUpdateRental, conn, transaction))
                        {
                            cmd1.Parameters.AddWithValue("@returnDate", DateTime.Now);
                            cmd1.Parameters.AddWithValue("@totalDue", totalDue);
                            cmd1.Parameters.AddWithValue("@rentalId", rentalId);
                            cmd1.ExecuteNonQuery();
                        }

                        // Lệnh 2 (Cập nhật 'current_customer_id')
                        using (var cmd2 = new NpgsqlCommand(sqlUpdateBook, conn, transaction))
                        {
                            cmd2.Parameters.AddWithValue("@bookId", bookId);
                            cmd2.ExecuteNonQuery();
                        }

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
    }
}