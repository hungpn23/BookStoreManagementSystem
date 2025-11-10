using BookStoreManagementSystem.DataAccess;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Data;

namespace BookStoreManagementSystem.DataAccess
{
    public class AuthorRepository
    {
        public DataTable GetAllAuthors()
        {
            // Đã sửa: Dùng 'bio'
            string sql = @"
                SELECT 
                    id, name, birth_date, bio 
                FROM authors ORDER BY name;
            ";
            return DatabaseHelper.GetDataTable(sql);
        }

        public DataTable SearchAuthorsByName(string name)
        {
            // Đã sửa: Dùng 'bio'
            string sql = @"
                SELECT id, name, birth_date, bio 
                FROM authors
                WHERE name ILIKE @searchTerm
                ORDER BY name;";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@searchTerm", NpgsqlDbType.Varchar) { Value = $"%{name}%" }
            };
            return DatabaseHelper.GetDataTable(sql, parameters);
        }

        public void AddAuthor(string name, DateTime birthDate, string bio)
        {
            // Đã sửa: Dùng 'bio'
            string sql = @"
                INSERT INTO authors (name, birth_date, bio)
                VALUES (@name, @birthDate, @bio);
            ";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", NpgsqlDbType.Varchar) { Value = name },
                new NpgsqlParameter("@birthDate", NpgsqlDbType.Timestamp) { Value = birthDate },
                new NpgsqlParameter("@bio", NpgsqlDbType.Text) { Value = (object)bio ?? DBNull.Value }
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

        public void UpdateAuthor(int id, string name, DateTime birthDate, string bio)
        {
            // Đã sửa: Dùng 'bio'
            string sql = @"
                UPDATE authors SET
                    name = @name,
                    birth_date = @birthDate,
                    bio = @bio
                WHERE
                    id = @id;
            ";

            var parameters = new NpgsqlParameter[]
            {
                new NpgsqlParameter("@name", NpgsqlDbType.Varchar) { Value = name },
                new NpgsqlParameter("@birthDate", NpgsqlDbType.Timestamp) { Value = birthDate },
                new NpgsqlParameter("@bio", NpgsqlDbType.Text) { Value = (object)bio ?? DBNull.Value },
                new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = id }
            };
            DatabaseHelper.ExecuteNonQuery(sql, parameters);
        }

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