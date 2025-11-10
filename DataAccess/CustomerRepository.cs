using BookStoreManagementSystem.DataAccess;
using Npgsql;
using NpgsqlTypes;
using System.Data;

namespace BookStoreManagementSystem.DataAccess
{
    public class CustomerRepository
    {
        /// <summary>
        /// Lấy tất cả khách hàng.
        /// (Đã sửa: Bỏ cột 'is_active' khỏi câu truy vấn)
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
    }
}