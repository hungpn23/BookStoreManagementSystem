using BookStoreManagementSystem.DataAccess;
using BookStoreManagementSystem.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace BookStoreManagementSystem
{
    public partial class MainForm : Form
    {
        private readonly BookRepository _bookRepository;
        private readonly AuthorRepository _authorRepository;
        private readonly CustomerRepository _customerRepository;

        public MainForm()
        {
            InitializeComponent();
            _bookRepository = new BookRepository();
            _authorRepository = new AuthorRepository();
            _customerRepository = new CustomerRepository();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
        }

        private void LoadBooks()
        {
            dgvBooks.DataSource = _bookRepository.GetAllBooksWithDetails();
            LoadAuthorsToEditComboBox();
            LoadCustomersToEditComboBox();
        }

        private void LoadAuthorsToEditComboBox()
        {
            try
            {
                DataTable dtAuthors = _authorRepository.GetAllAuthors();
                cmbEditAuthors.DataSource = dtAuthors;
                cmbEditAuthors.DisplayMember = "name";
                cmbEditAuthors.ValueMember = "id";
                cmbEditAuthors.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách tác giả: " + ex.Message);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            try
            {
                AddBookForm frmAddBook = new AddBookForm();

                var result = frmAddBook.ShowDialog();

                if (result == DialogResult.OK)
                {
                    LoadBooks();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sách: " + ex.Message);
            }
        }

        private void LoadCustomersToEditComboBox()
        {
            try
            {
                DataTable dtCustomers = _customerRepository.GetAllCustomers();

                // (Tùy chọn nhưng nên làm) Thêm một dòng "Không" (NULL)
                DataRow nullRow = dtCustomers.NewRow();
                nullRow["id"] = DBNull.Value; // Giá trị thực sự là NULL
                nullRow["full_name"] = "[Không]";
                dtCustomers.Rows.InsertAt(nullRow, 0); // Thêm vào đầu danh sách

                cmbEditCustomers.DataSource = dtCustomers;
                cmbEditCustomers.DisplayMember = "full_name";
                cmbEditCustomers.ValueMember = "id";
                cmbEditCustomers.DropDownStyle = ComboBoxStyle.DropDownList;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách khách hàng: " + ex.Message);
            }
        }

        private void dgvBooks_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvBooks.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvBooks.SelectedRows[0];

                    string id = row.Cells["id"].Value.ToString();
                    int authorId = Convert.ToInt32(row.Cells["authorId"].Value);
                    // SỬA: Lấy giá trị customerId một cách an toàn
                    object customerIdObj = row.Cells["currentCustomerId"].Value;
                    string name = row.Cells["name"].Value.ToString();
                    string type = row.Cells["type"].Value.ToString();
                    DateTime pubDate = Convert.ToDateTime(row.Cells["publishedDate"].Value);
                    decimal dailyRentalFee = Convert.ToDecimal(row.Cells["dailyRentalFee"].Value);

                    lblSelectedBookId.Text = id;
                    cmbEditAuthors.SelectedValue = authorId;
                    // SỬA: Gán giá trị cho cmbEditCustomers một cách an toàn
                    // Nếu customerIdObj là DBNull, nó sẽ tự động chọn dòng [Không] (vì ValueMember của nó là DBNull.Value)
                    // Nếu không, nó sẽ chọn khách hàng tương ứng.
                    cmbEditCustomers.SelectedValue = customerIdObj;
                    txtEditName.Text = name;
                    txtEditType.Text = type;
                    dtpEditPublishedDate.Value = pubDate;
                    numEditDailyRentalFee.Value = dailyRentalFee;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn hàng: " + ex.Message);
                }
            }
            else
            {
                ClearEditPanel();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblSelectedBookId.Text);
                string name = txtEditName.Text;
                string type = txtEditType.Text;
                float price = (float)numEditDailyRentalFee.Value;
                DateTime pubDate = dtpEditPublishedDate.Value;
                int authorId = (int)cmbEditAuthors.SelectedValue;

                int? customerId = null;
                if (cmbEditCustomers.SelectedValue != null && cmbEditCustomers.SelectedValue != DBNull.Value)
                {
                    customerId = Convert.ToInt32(cmbEditCustomers.SelectedValue);
                }

                if (id == 0 || string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Vui lòng chọn một cuốn sách và đảm bảo tên sách không bị trống.");
                    return;
                }

                _bookRepository.UpdateBook(id, name, type, price, pubDate, authorId, customerId);

                MessageBox.Show("Cập nhật sách thành công!");
                LoadBooks(); 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật sách: " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblSelectedBookId.Text);

                if (id == 0)
                {
                    MessageBox.Show("Vui lòng chọn một cuốn sách để xóa.", "Chưa chọn sách", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                var confirmResult = MessageBox.Show(
                    "Bạn có chắc chắn muốn xóa cuốn sách này không? Thao tác này không thể hoàn tác.",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirmResult == DialogResult.Yes)
                {
                    _bookRepository.DeleteBook(id);

                    MessageBox.Show("Xóa sách thành công!");
                    LoadBooks(); 

                    ClearEditPanel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa sách: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearEditPanel()
        {
            lblSelectedBookId.Text = "0";
            txtEditName.Text = "";
            txtEditType.Text = "";
            numEditDailyRentalFee.Value = 0;
            dtpEditPublishedDate.Value = DateTime.Now;

            if (cmbEditAuthors.Items.Count > 0)
            {
                cmbEditAuthors.SelectedIndex = 0;
            }

            // SỬA: Thêm reset cho cmbEditCustomers
            if (cmbEditCustomers.Items.Count > 0)
            {
                cmbEditCustomers.SelectedIndex = 0; // Chọn [Không]
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchName.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Vui lòng nhập tên sách để tìm kiếm.", "Thông báo");
                return;
            }

            try
            {
                DataTable dtResults = _bookRepository.SearchBooksByName(searchTerm);

                // 2. Cập nhật DataSource
                dgvBooks.DataSource = dtResults;

                if (dtResults.Rows.Count == 0)
                {
                    MessageBox.Show("Không tìm thấy sách nào khớp với từ khóa.", "Thông báo");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message, "Lỗi");
            }
        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            // Xóa nội dung tìm kiếm
            txtSearchName.Text = "";

            // Tải lại toàn bộ danh sách sách
            LoadBooks();
        }

        private void dgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // 1. Đảm bảo người dùng không double-click vào tiêu đề
            if (e.RowIndex >= 0)
            {
                // 2. Lấy tên của cột được click
                //    (Chúng ta cần tên (Name) của cột, không phải HeaderText)
                string columnName = dgvBooks.Columns[e.ColumnIndex].Name;

                // 3. Kiểm tra xem có phải cột "authorName" không
                //    (Đây là (Name) bạn đặt cho cột "Author Name" trong designer)
                if (columnName == "authorName")
                {
                    try
                    {
                        // 4. Lấy hàng hiện tại
                        DataGridViewRow row = dgvBooks.Rows[e.RowIndex];

                        // 5. Lấy author_id từ cột "authorId" (cột này có thể đang bị ẩn)
                        int authorId = Convert.ToInt32(row.Cells["authorId"].Value);
                        string authorName = row.Cells["authorName"].Value.ToString();

                        // 6. Gọi hàm Repository mới để lọc danh sách
                        DataTable dtBooksByAuthor = _bookRepository.GetAllBooksWithDetails(authorId);

                        // 7. Cập nhật lại DataGridView
                        dgvBooks.DataSource = dtBooksByAuthor;

                        // 8. (Tùy chọn) Hiển thị thông báo lọc trên ô tìm kiếm
                        txtSearchName.Text = $"Sách của: {authorName}";

                        // Xóa trống panel chi tiết vì danh sách đã thay đổi
                        ClearEditPanel();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lọc sách theo tác giả: " + ex.Message);
                    }
                }
            }
        }

        private void btnBookReport_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Gọi hàm mới từ repository để lấy List<Book>
                List<Book> allBooks = _bookRepository.GetAllBooksAsList();

                if (allBooks.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu sách để tạo báo cáo.");
                    return;
                }

                // 2. Tạo Form báo cáo
                ReportForm frmReport = new ReportForm();

                // 3. Truyền dữ liệu vào Form
                frmReport.LoadReport(allBooks);

                // 4. Hiển thị (ShowDialog để khóa MainForm, Show để mở độc lập)
                frmReport.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi chuẩn bị báo cáo: " + ex.Message, "Lỗi báo cáo");
            }
        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorForm authorForm = new AuthorForm();

            authorForm.ShowDialog();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();

            customerForm.ShowDialog();
        }
    }
}
