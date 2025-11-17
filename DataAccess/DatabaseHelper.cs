using Npgsql;
using System.Configuration;
using System.Data;

namespace BookStoreManagementSystem.DataAccess
{
    public static class DatabaseHelper
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["BookStoreDb"].ConnectionString;
        }

        public static DataTable GetDataTable(string sql)
        {
            DataTable dt = new DataTable();
            using (var conn = new NpgsqlConnection(GetConnectionString()))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// Thực thi truy vấn SELECT có tham số và trả về một DataTable.
        /// </summary>
        public static DataTable GetDataTable(string sql, NpgsqlParameter[] parameters)
        {
            DataTable dt = new DataTable();
            using (var conn = new NpgsqlConnection(GetConnectionString()))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }

                    using (var adapter = new NpgsqlDataAdapter(cmd))
                    {
                        adapter.Fill(dt);
                    }
                }
            }
            return dt;
        }

        /// <summary>
        /// Thực thi một lệnh (INSERT, UPDATE, DELETE) và trả về số hàng bị ảnh hưởng.
        /// Sử dụng parameters để chống SQL Injection.
        /// </summary>
        public static int ExecuteNonQuery(string sql, NpgsqlParameter[] parameters)
        {
            using (var conn = new NpgsqlConnection(GetConnectionString()))
            {
                conn.Open();
                using (var cmd = new NpgsqlCommand(sql, conn))
                {
                    if (parameters != null)
                    {
                        cmd.Parameters.AddRange(parameters);
                    }
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}