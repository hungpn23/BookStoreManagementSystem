using BookStoreManagementSystem.DataAccess; // Cần dùng DatabaseHelper
using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;

namespace BookStoreManagementSystem.DataAccess
{
    public class AuthorRepository
    {
        /// <summary>
        /// Lấy tất cả các cột của tất cả tác giả.
        /// </summary>
        /// <returns>Một DataTable chứa danh sách tác giả.</returns>
        public DataTable GetAllAuthors()
        {
            // Lấy tất cả thông tin từ bảng authors (dựa trên BookStoreMigrationUp.sql)
            string sql = @"
                SELECT 
                    id, 
                    name, 
                    birth_date, 
                    short_bio 
                FROM 
                    authors
                ORDER BY
                    name;
            ";

            // Sử dụng lại DatabaseHelper đã tạo ở các bước trước
            return DatabaseHelper.GetDataTable(sql);
        }

        /// <summary>
        /// Tìm kiếm tác giả theo tên (không phân biệt hoa thường).
        /// </summary>
        public DataTable SearchAuthorsByName(string name)
        {
            string sql = @"
                SELECT id, name, birth_date, short_bio 
                FROM authors
                WHERE name ILIKE @searchTerm
                ORDER BY name;";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@searchTerm", NpgsqlDbType.Varchar) { Value = $"%{name}%" }
            };

            // Dùng hàm GetDataTable CÓ tham số
            return DatabaseHelper.GetDataTable(sql, parameters);
        }

        /// <summary>
        /// Thêm một tác giả mới.
        /// </summary>
        public void AddAuthor(string name, DateTime birthDate, string shortBio)
        {
            string sql = @"
                INSERT INTO authors (name, birth_date, short_bio)
                VALUES (@name, @birthDate, @shortBio);
            ";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", NpgsqlDbType.Varchar) { Value = name },
                new NpgsqlParameter("@birthDate", NpgsqlDbType.Timestamp) { Value = birthDate },
                new NpgsqlParameter("@shortBio", NpgsqlDbType.Text) { Value = (object)shortBio ?? DBNull.Value } // Cho phép shortBio là NULL
            };

            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        /// <summary>
        /// Cập nhật một tác giả dựa trên ID.
        /// </summary>
        public void UpdateAuthor(int id, string name, DateTime birthDate, string shortBio)
        {
            string sql = @"
                UPDATE authors SET
                    name = @name,
                    birth_date = @birthDate,
                    short_bio = @shortBio
                WHERE
                    id = @id;
            ";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", NpgsqlDbType.Varchar) { Value = name },
                new NpgsqlParameter("@birthDate", NpgsqlDbType.Timestamp) { Value = birthDate },
                new NpgsqlParameter("@shortBio", NpgsqlDbType.Text) { Value = (object)shortBio ?? DBNull.Value },
                new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = id }
            };

            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        /// <summary>
        /// Xóa một tác giả dựa trên ID.
        /// </summary>
        public void DeleteAuthor(int id)
        {
            string sql = "DELETE FROM authors WHERE id = @id;";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = id }
            };

            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }
    }
}