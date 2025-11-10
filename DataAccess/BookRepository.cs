using BookStoreManagementSystem.DataAccess;
using BookStoreManagementSystem.Models;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Xml.Linq;

public class BookRepository
{
    public BookRepository() { }

    /// <summary>
    /// Lấy tất cả sách, bao gồm tên tác giả và tên người đang thuê.
    /// </summary>
    public DataTable GetAllBooksWithDetails()
    {
        string sql = @"
            SELECT 
                b.id, 
                b.name, 
                b.type, 
                b.published_date, 
                b.daily_rental_fee, 
                b.author_id, 
                a.name AS author_name,
                b.current_customer_id,
                c.full_name AS customer_name
            FROM 
                books b
            JOIN 
                authors a ON b.author_id = a.id
            LEFT JOIN
                customers c ON b.current_customer_id = c.id
            ORDER BY
                b.id;
        ";
        return DatabaseHelper.GetDataTable(sql);
    }

    public DataTable GetAllBooksWithDetails(int authorId)
    {
        string sql = @"
            SELECT 
                b.id, 
                b.name, 
                b.type, 
                b.published_date, 
                b.daily_rental_fee, 
                b.author_id, 
                a.name AS author_name,
                b.current_customer_id,
                c.full_name AS customer_name
            FROM 
                books b
            JOIN 
                authors a ON b.author_id = a.id
            LEFT JOIN
                customers c ON b.current_customer_id = c.id
            WHERE
                b.author_id = @authorId
            ORDER BY
                b.id;
        ";

        var parameters = new NpgsqlParameter[]
        {
            new NpgsqlParameter("@authorId", NpgsqlDbType.Integer) { Value = authorId }
        };

        return DatabaseHelper.GetDataTable(sql, parameters);
    }

    /// <summary>
    /// Lấy tất cả sách đang có sẵn (chưa ai thuê).
    /// </summary>
    public DataTable GetAvailableBooks()
    {
        string sql = @"
            SELECT 
                id, 
                name,
                daily_rental_fee
            FROM 
                books
            WHERE
                current_customer_id IS NULL
            ORDER BY
                name;
        ";
        return DatabaseHelper.GetDataTable(sql);
    }

    /// <summary>
    /// Thêm sách mới.
    /// </summary>
    public void AddBook(string name, string type, float dailyRentalFee, DateTime publishedDate, int authorId)
    {
        string sql = @"
            INSERT INTO books (name, type, daily_rental_fee, published_date, author_id)
            VALUES (@name, @type, @dailyFee, @pubDate, @authorId);
        ";

        var parameters = new NpgsqlParameter[]
        {
            new NpgsqlParameter("@name", NpgsqlDbType.Varchar) { Value = name },
            new NpgsqlParameter("@type", NpgsqlDbType.Varchar) { Value = type },
            new NpgsqlParameter("@dailyFee", NpgsqlDbType.Real) { Value = dailyRentalFee },
            new NpgsqlParameter("@pubDate", NpgsqlDbType.Timestamp) { Value = publishedDate },
            new NpgsqlParameter("@authorId", NpgsqlDbType.Integer) { Value = authorId }
        };
        DatabaseHelper.ExecuteNonQuery(sql, parameters);
    }

    /// <summary>
    /// Cập nhật sách.
    /// </summary>
    public void UpdateBook(int id, string name, string type, float dailyRentalFee, DateTime publishedDate, int authorId, int? customerId)
    {
        string sql = @"
            UPDATE books SET
                name = @name,
                type = @type,
                daily_rental_fee = @dailyFee,
                published_date = @pubDate,
                author_id = @authorId,
                current_customer_id = @customerId
            WHERE
                id = @id;
        ";

        var parameters = new NpgsqlParameter[]
        {
            new NpgsqlParameter("@name", NpgsqlDbType.Varchar) { Value = name },
            new NpgsqlParameter("@type", NpgsqlDbType.Varchar) { Value = type },
            new NpgsqlParameter("@dailyFee", NpgsqlDbType.Real) { Value = dailyRentalFee },
            new NpgsqlParameter("@pubDate", NpgsqlDbType.Timestamp) { Value = publishedDate },
            new NpgsqlParameter("@authorId", NpgsqlDbType.Integer) { Value = authorId },
            // Xử lý giá trị NULL (DBNull)
            new NpgsqlParameter("@customerId", NpgsqlDbType.Integer)
            {
                Value = customerId.HasValue ? (object)customerId.Value : (object)DBNull.Value
            },
            new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = id }
        };
        DatabaseHelper.ExecuteNonQuery(sql, parameters);
    }

    /// <summary>
    /// Xóa một cuốn sách.
    /// </summary>
    public void DeleteBook(int id)
    {
        string sql = "DELETE FROM books WHERE id = @id;";
        var parameters = new NpgsqlParameter[]
        {
            new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = id }
        };
        DatabaseHelper.ExecuteNonQuery(sql, parameters);
    }

    /// <summary>
    /// Tìm kiếm sách.
    /// </summary>
    public DataTable SearchBooksByName(string name)
    {
        string sql = @"
            SELECT 
                b.id,
                b.name,
                b.type,
                b.published_date,
                b.daily_rental_fee, 
                b.author_id, 
                b.current_customer_id, 
                a.name AS author_name,
                c.full_name AS customer_name
            FROM 
                books b
            JOIN 
                authors a ON b.author_id = a.id
            LEFT JOIN
                customers c ON b.current_customer_id = c.id
            WHERE
                b.name ILIKE @searchTerm
            ORDER BY
                b.name;
        ";
        var parameters = new NpgsqlParameter[]
        {
            new NpgsqlParameter("@searchTerm", NpgsqlDbType.Varchar) { Value = $"%{name}%" }
        };
        return DatabaseHelper.GetDataTable(sql, parameters);
    }

    /// <summary>
    /// Lấy tất cả sách dưới dạng List<Book> (dùng cho Crystal Reports).
    /// </summary>
    public List<Book> GetAllBooksAsList()
    {
        List<Book> books = new List<Book>();
        DataTable dt = DatabaseHelper.GetDataTable("SELECT id, name, daily_rental_fee, published_date, type, author_id, current_customer_id FROM books ORDER BY id");

        foreach (DataRow row in dt.Rows)
        {
            Book book = new Book
            {
                Id = Convert.ToInt32(row["id"]),
                Name = row["name"].ToString(),
                DailyRentalFee = Convert.ToSingle(row["daily_rental_fee"]),
                PublishedDate = Convert.ToDateTime(row["published_date"]),
                Type = row["type"].ToString(),
                AuthorId = Convert.ToInt32(row["author_id"]),

                CurrentCustomerId = row["current_customer_id"] == DBNull.Value ? (int?)null : Convert.ToInt32(row["current_customer_id"])
            };
            books.Add(book);
        }
        return books;
    }
}