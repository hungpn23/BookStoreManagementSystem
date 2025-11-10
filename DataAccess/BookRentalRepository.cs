using System.Data;

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
                    r.rental_date DESC;
            ";

            return DatabaseHelper.GetDataTable(sql);
        }
    }
}