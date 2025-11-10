using BookStoreManagementSystem.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStoreManagementSystem
{
    public partial class BookForm : Form
    {
        private readonly BookRepository _bookRepository;
        private readonly AuthorRepository _authorRepository;

        public BookForm()
        {
            InitializeComponent();
            _bookRepository = new BookRepository();
            _authorRepository = new AuthorRepository();
        }

        private void BookForm_Load(object sender, EventArgs e)
        {
            LoadBooks();
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

                if (id == 0 || string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Vui lòng chọn một cuốn sách và đảm bảo tên sách không bị trống.");
                    return;
                }

                _bookRepository.UpdateBook(id, name, type, price, pubDate, authorId);

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
            txtSearchName.Text = "";

            LoadBooks();
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
                    string name = row.Cells["name"].Value.ToString();
                    string type = row.Cells["type"].Value.ToString();
                    DateTime pubDate = Convert.ToDateTime(row.Cells["publishedDate"].Value);
                    decimal dailyRentalFee = Convert.ToDecimal(row.Cells["dailyRentalFee"].Value);

                    lblSelectedBookId.Text = id;
                    cmbEditAuthors.SelectedValue = authorId;
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

        private void dgvBooks_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string columnName = dgvBooks.Columns[e.ColumnIndex].Name;

                if (columnName == "authorName")
                {
                    try
                    {
                        DataGridViewRow row = dgvBooks.Rows[e.RowIndex];

                        int authorId = Convert.ToInt32(row.Cells["authorId"].Value);
                        string authorName = row.Cells["authorName"].Value.ToString();

                        DataTable dtBooksByAuthor = _bookRepository.GetAllBooksWithDetails(authorId);

                        dgvBooks.DataSource = dtBooksByAuthor;

                        txtSearchName.Text = $"Sách của: {authorName}";

                        ClearEditPanel();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lỗi khi lọc sách theo tác giả: " + ex.Message);
                    }
                }
            }
        }

        private void LoadBooks()
        {
            dgvBooks.DataSource = _bookRepository.GetAllBooksWithDetails();
            LoadAuthorsToEditComboBox();
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
        }
    }
}
