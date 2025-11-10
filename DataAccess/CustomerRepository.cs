using BookStoreManagementSystem.DataAccess; // Đảm bảo bạn có using này
using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;

namespace BookStoreManagementSystem.DataAccess
{
    public class CustomerRepository
    {
        /// <summary>
        /// Lấy tất cả khách hàng.
        /// </summary>
        public DataTable GetAllCustomers()
        {
            string sql = @"
                SELECT 
                    id, 
                    full_name, 
                    email
                FROM 
                    customers
                ORDER BY
                    full_name;
            ";
            return DatabaseHelper.GetDataTable(sql);
        }

        /// <summary>
        /// (MỚI) Tìm kiếm khách hàng theo tên (không phân biệt hoa thường).
        /// </summary>
        public DataTable SearchCustomersByName(string name)
        {
            string sql = @"
                SELECT id, full_name, email 
                FROM customers
                WHERE full_name ILIKE @searchTerm
                ORDER BY full_name;";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@searchTerm", NpgsqlDbType.Varchar) { Value = $"%{name}%" }
            };

            return DatabaseHelper.GetDataTable(sql, parameters);
        }

        /// <summary>
        /// (MỚI) Thêm một khách hàng mới.
        /// </summary>
        public void AddCustomer(string fullName, string email)
        {
            string sql = @"
                INSERT INTO customers (full_name, email)
                VALUES (@fullName, @email);
            ";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@fullName", NpgsqlDbType.Varchar) { Value = fullName },
                new NpgsqlParameter("@email", NpgsqlDbType.Varchar) { Value = (object)email ?? DBNull.Value } // Cho phép email là NULL
            };

            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        /// <summary>
        /// (MỚI) Cập nhật một khách hàng dựa trên ID.
        /// </summary>
        public void UpdateCustomer(int id, string fullName, string email)
        {
            string sql = @"
                UPDATE customers SET
                    full_name = @fullName,
                    email = @email
                WHERE
                    id = @id;
            ";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@fullName", NpgsqlDbType.Varchar) { Value = fullName },
                new NpgsqlParameter("@email", NpgsqlDbType.Varchar) { Value = (object)email ?? DBNull.Value },
                new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = id }
            };

            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        /// <summary>
        /// (MỚI) Xóa một khách hàng dựa trên ID.
        /// </summary>
        public void DeleteCustomer(int id)
        {
            // CẢNH BÁO: Nếu CSDL của bạn có 'ON DELETE CASCADE'
            // (ví dụ trong bảng book_rentals), việc này sẽ xóa tất cả lịch sử thuê của khách hàng.
            string sql = "DELETE FROM customers WHERE id = @id;";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = id }
            };

            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }
    }
}