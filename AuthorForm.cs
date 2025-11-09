using BookStoreManagementSystem.DataAccess; // Thêm thư mục Repository
using System;
using System.Data;
using System.Windows.Forms;

namespace BookStoreManagementSystem
{
    public partial class AuthorForm : Form
    {
        private readonly AuthorRepository _authorRepository;

        public AuthorForm()
        {
            InitializeComponent();
            _authorRepository = new AuthorRepository();
        }

        private void AuthorForm_Load(object sender, EventArgs e)
        {
            LoadAuthors();
        }

        private void LoadAuthors()
        {
            try
            {
                DataTable dtAuthors = _authorRepository.GetAllAuthors();
                dgvAuthors.AutoGenerateColumns = false; // Đảm bảo đã tắt
                dgvAuthors.DataSource = dtAuthors;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách tác giả: " + ex.Message);
            }
        }


        private void btnSearchAuthor_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchAuthor.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Vui lòng nhập tên tác giả để tìm kiếm.");
                return;
            }
            try
            {
                dgvAuthors.DataSource = _authorRepository.SearchAuthorsByName(searchTerm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm tác giả: " + ex.Message);
            }
        }

        private void btnShowAllAuthors_Click(object sender, EventArgs e)
        {
            txtSearchAuthor.Text = "";
            LoadAuthors();
        }

        private void dgvAuthors_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvAuthors.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvAuthors.SelectedRows[0];

                    // Lấy dữ liệu (Đảm bảo tên cột khớp với 'DataPropertyName' của bạn)
                    lblSelectedAuthorId.Text = row.Cells["id"].Value.ToString();
                    txtAuthorName.Text = row.Cells["name"].Value.ToString();
                    dtpAuthorBirthDate.Value = Convert.ToDateTime(row.Cells["birthDate"].Value);
                    txtAuthorShortBio.Text = row.Cells["shortBio"].Value.ToString();
                }
                catch (Exception ex)
                {
                    // Xử lý nếu giá trị bị null hoặc lỗi
                    // MessageBox.Show("Lỗi khi chọn hàng: " + ex.Message);
                    ClearAuthorPanel(); // Xóa trống nếu có lỗi
                }
            }
            else
            {
                ClearAuthorPanel(); // Xóa trống nếu không có hàng nào được chọn
            }
        }

        private void btnAuthorNew_Click(object sender, EventArgs e)
        {
            ClearAuthorPanel();
        }

        // Nút "Save" sẽ xử lý cả THÊM MỚI (Add) và CẬP NHẬT (Update)
        private void btnAuthorSave_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy dữ liệu từ panel
                int id = Convert.ToInt32(lblSelectedAuthorId.Text);
                string name = txtAuthorName.Text;
                DateTime birthDate = dtpAuthorBirthDate.Value;
                string shortBio = txtAuthorShortBio.Text;

                if (string.IsNullOrWhiteSpace(name))
                {
                    MessageBox.Show("Tên tác giả không được để trống.");
                    return;
                }

                if (id == 0)
                {
                    // ID = 0, nghĩa là đây là "Thêm mới"
                    _authorRepository.AddAuthor(name, birthDate, shortBio);
                    MessageBox.Show("Thêm tác giả thành công!");
                }
                else
                {
                    // ID != 0, nghĩa là đây là "Cập nhật"
                    _authorRepository.UpdateAuthor(id, name, birthDate, shortBio);
                    MessageBox.Show("Cập nhật tác giả thành công!");
                }

                // Tải lại danh sách
                LoadAuthors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu tác giả: " + ex.Message);
            }
        }

        private void btnAuthorDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblSelectedAuthorId.Text);

                if (id == 0)
                {
                    MessageBox.Show("Vui lòng chọn một tác giả để xóa.");
                    return;
                }

                // Hỏi xác nhận
                var confirm = MessageBox.Show(
                    "Bạn có chắc muốn xóa tác giả này? (Tất cả sách của tác giả này cũng sẽ bị xóa - nếu CSDL có cài đặt 'ON DELETE CASCADE')",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    _authorRepository.DeleteAuthor(id);
                    MessageBox.Show("Xóa tác giả thành công!");
                    LoadAuthors();
                    ClearAuthorPanel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa tác giả: " + ex.Message);
            }
        }

        // Hàm tiện ích để xóa trống panel chi tiết
        private void ClearAuthorPanel()
        {
            lblSelectedAuthorId.Text = "0";
            txtAuthorName.Text = "";
            txtAuthorShortBio.Text = "";
            dtpAuthorBirthDate.Value = DateTime.Now;
        }
    }
}