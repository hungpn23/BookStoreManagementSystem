using BookStoreManagementSystem.DataAccess;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookStoreManagementSystem
{
    public partial class AddBookForm : Form
    {
        private readonly AuthorRepository _authorRepository;
        private readonly BookRepository _bookRepository;

        public AddBookForm()
        {
            InitializeComponent();
            _authorRepository = new AuthorRepository();
            _bookRepository = new BookRepository();
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {
            LoadAuthors();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                string name = txtName.Text;
                string type = txtType.Text;
                float price = (float)numPrice.Value;
                DateTime pubDate = dtpPublishedDate.Value;
                int authorId = (int)cmbAuthors.SelectedValue;

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Tên sách không được để trống.", "Cảnh báo");
                    return;
                }

                _bookRepository.AddBook(name, type, price, pubDate, authorId);

                MessageBox.Show("Thêm sách thành công!", "Thông báo");

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm sách: " + ex.Message, "Lỗi");
                DialogResult = DialogResult.Cancel;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void LoadAuthors()
        {
            try
            {
                DataTable dtAuthors = _authorRepository.GetAllAuthors();
                cmbAuthors.DataSource = dtAuthors;
                cmbAuthors.DisplayMember = "name";
                cmbAuthors.ValueMember = "id";
                cmbAuthors.DropDownStyle = ComboBoxStyle.DropDownList; 
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách tác giả: " + ex.Message, "Lỗi");
            }
        }
    }
}
