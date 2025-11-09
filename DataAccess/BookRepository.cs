using BookStoreManagementSystem.DataAccess;
using Npgsql;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Data;

public class BookRepository
{
    // Hàm này đã được khởi tạo trong MainForm.cs
    public BookRepository()
    {
    }

    /// <summary>
    /// Lấy tất cả sách, bao gồm tất cả các cột từ bảng Books
    /// và thêm cột 'author_name' từ bảng Authors.
    /// </summary>
    /// <returns>Một DataTable chứa dữ liệu đã join.</returns>
    public DataTable GetAllBooksWithAuthorName()
    {
        // Câu SQL này JOIN bảng books và authors
        // và chọn tất cả các cột từ 'books', cộng thêm cột 'name' từ 'authors'
        // mà chúng ta đổi tên thành 'author_name' để tránh trùng lặp.
        string sql = @"
            SELECT 
                b.id, 
                b.name, 
                b.book_type, 
                b.published_date, 
                b.price, 
                b.author_id, 
                a.name AS author_name 
            FROM 
                books b
            JOIN 
                authors a ON b.author_id = a.id
            ORDER BY
                b.id;
        ";

        // Sử dụng DatabaseHelper để thực thi và lấy kết quả
        return DatabaseHelper.GetDataTable(sql);
    }

    /// <summary>
    /// Thêm một cuốn sách mới vào cơ sở dữ liệu.
    /// </summary>
    public void AddBook(string name, string type, float price, DateTime publishedDate, int authorId)
    {
        string sql = @"
            INSERT INTO books (name, book_type, price, published_date, author_id)
            VALUES (@name, @type, @price, @pubDate, @authorId);
        ";

        var parameters = new NpgsqlParameter[]
        {
            new NpgsqlParameter("@name", NpgsqlDbType.Varchar) { Value = name },
            new NpgsqlParameter("@type", NpgsqlDbType.Varchar) { Value = type },
            new NpgsqlParameter("@price", NpgsqlDbType.Real) { Value = price },
            new NpgsqlParameter("@pubDate", NpgsqlDbType.Timestamp) { Value = publishedDate },
            new NpgsqlParameter("@authorId", NpgsqlDbType.Integer) { Value = authorId }
        };

        DatabaseHelper.ExecuteNonQuery(sql, parameters);
    }

    /// <summary>
    /// Cập nhật thông tin một cuốn sách dựa trên ID của nó.
    /// </summary>
    public void UpdateBook(int id, string name, string type, float price, DateTime publishedDate, int authorId)
    {
        string sql = @"
            UPDATE books SET
                name = @name,
                book_type = @type,
                price = @price,
                published_date = @pubDate,
                author_id = @authorId
            WHERE
                id = @id;
        ";

        var parameters = new NpgsqlParameter[]
        {
            new NpgsqlParameter("@name", NpgsqlDbType.Varchar) { Value = name },
            new NpgsqlParameter("@type", NpgsqlDbType.Varchar) { Value = type },
            new NpgsqlParameter("@price", NpgsqlDbType.Real) { Value = price },
            new NpgsqlParameter("@pubDate", NpgsqlDbType.Timestamp) { Value = publishedDate },
            new NpgsqlParameter("@authorId", NpgsqlDbType.Integer) { Value = authorId },
            new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = id } // Tham số ID cho mệnh đề WHERE
        };

        DatabaseHelper.ExecuteNonQuery(sql, parameters);
    }

    /// <summary>
    /// Xóa một cuốn sách khỏi cơ sở dữ liệu dựa trên ID.
    /// </summary>
    public void DeleteBook(int id)
    {
        // Câu lệnh DELETE, sử dụng tham số @id
        string sql = "DELETE FROM books WHERE id = @id;";

        // Tạo tham số
        var parameters = new NpgsqlParameter[]
        {
            new NpgsqlParameter("@id", NpgsqlDbType.Integer) { Value = id }
        };

        // Gọi hàm ExecuteNonQuery
        DatabaseHelper.ExecuteNonQuery(sql, parameters);
    }

    /// <summary>
    /// Tìm kiếm sách theo tên (không phân biệt hoa thường, chứa).
    /// </summary>
    public DataTable SearchBooksByName(string name)
    {
        // Câu SQL này vẫn JOIN 2 bảng
        // và thêm mệnh đề WHERE b.name ILIKE @searchTerm
        // (ILIKE là "LIKE" không phân biệt hoa thường trong PostgreSQL)
        string sql = @"
            SELECT 
                b.id, b.name, b.book_type, b.published_date, 
                b.price, b.author_id, a.name AS author_name 
            FROM 
                books b
            JOIN 
                authors a ON b.author_id = a.id
            WHERE
                b.name ILIKE @searchTerm
            ORDER BY
                b.name;
        ";

        // Tạo tham số. Thêm "%" để tìm kiếm "chứa"
        var parameters = new NpgsqlParameter[]
        {
            new NpgsqlParameter("@searchTerm", NpgsqlDbType.Varchar) { Value = $"%{name}%" }
        };

        // Gọi hàm GetDataTable MỚI có tham số
        return DatabaseHelper.GetDataTable(sql, parameters);
    }

    /// <summary>
    /// Lấy tất cả các sách của một tác giả cụ thể.
    /// </summary>
    public DataTable GetBooksByAuthorId(int authorId)
    {
        // Câu SQL này JOIN 2 bảng và lọc theo author_id
        string sql = @"
            SELECT 
                b.id, b.name, b.book_type, b.published_date, 
                b.price, b.author_id, a.name AS author_name 
            FROM 
                books b
            JOIN 
                authors a ON b.author_id = a.id
            WHERE
                b.author_id = @authorId
            ORDER BY
                b.name;
        ";

        // Tạo tham số
        var parameters = new NpgsqlParameter[]
        {
            new NpgsqlParameter("@authorId", NpgsqlDbType.Integer) { Value = authorId }
        };

        // Gọi hàm GetDataTable CÓ tham số
        return DatabaseHelper.GetDataTable(sql, parameters);
    }

    /// <summary>
    /// Lấy tất cả sách dưới dạng List<Book> (dùng cho Crystal Reports).
    /// </summary>
    public List<Book> GetAllBooksAsList()
    {
        List<Book> books = new List<Book>();

        // Dùng lại hàm GetDataTable của DatabaseHelper
        DataTable dt = DatabaseHelper.GetDataTable("SELECT * FROM books ORDER BY id");

        // Chuyển đổi từ DataTable sang List<Book>
        foreach (DataRow row in dt.Rows)
        {
            Book book = new Book
            {
                Id = Convert.ToInt32(row["id"]),
                Name = row["name"].ToString(),
                Price = Convert.ToSingle(row["price"]),
                PublishedDate = Convert.ToDateTime(row["published_date"]),
                Type = row["book_type"].ToString(),
                AuthorId = Convert.ToInt32(row["author_id"])
            };
            books.Add(book);
        }

        return books;
    }
}