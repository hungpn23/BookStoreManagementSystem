using BookStoreManagementSystem.DataAccess;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookStoreManagementSystem
{
    public partial class CustomerForm : Form
    {
        private readonly CustomerRepository _customerRepository;

        public CustomerForm()
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
        }

        private void LoadCustomers()
        {
            try
            {
                DataTable dtCustomers = _customerRepository.GetAllCustomers();

                dgvCustomers.AutoGenerateColumns = false;
                dgvCustomers.DataSource = dtCustomers;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách khách hàng: " + ex.Message);
            }
        }

        private void dgvCustomers_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvCustomers.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvCustomers.SelectedRows[0];

                    lblSelectedCustomer.Text = row.Cells["id"].Value.ToString();
                    txtCustomerFullName.Text = row.Cells["fullName"].Value.ToString();

                    object emailValue = row.Cells["email"].Value;
                    txtCustomerEmail.Text = (emailValue == DBNull.Value) ? "" : emailValue.ToString();
                }
                catch (Exception ex)
                {
                    ClearCustomerPanel();
                }
            }
            else
            {
                ClearCustomerPanel();
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchCustomer.Text.Trim();
            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                MessageBox.Show("Vui lòng nhập tên khách hàng để tìm kiếm.");
                return;
            }
            try
            {
                dgvCustomers.DataSource = _customerRepository.SearchCustomersByName(searchTerm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm khách hàng: " + ex.Message);
            }
        }

        private void btnShowAllCustomers_Click(object sender, EventArgs e)
        {
            txtSearchCustomer.Text = "";
            LoadCustomers();
        }

        

        private void btnCustomerClear_Click(object sender, EventArgs e)
        {
            ClearCustomerPanel();
        }

        private void btnCustomerSave_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblSelectedCustomer.Text);
                string fullName = txtCustomerFullName.Text;
                string email = txtCustomerEmail.Text;

                if (string.IsNullOrWhiteSpace(fullName))
                {
                    MessageBox.Show("Tên khách hàng không được để trống.");
                    return;
                }

                if (id == 0)
                {
                    // Thêm mới
                    _customerRepository.AddCustomer(fullName, email);
                    MessageBox.Show("Thêm khách hàng thành công!");
                }
                else
                {
                    // Cập nhật
                    _customerRepository.UpdateCustomer(id, fullName, email);
                    MessageBox.Show("Cập nhật khách hàng thành công!");
                }

                LoadCustomers();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lưu khách hàng: " + ex.Message);
            }
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(lblSelectedCustomer.Text);

                if (id == 0)
                {
                    MessageBox.Show("Vui lòng chọn một khách hàng để xóa.");
                    return;
                }

                var confirm = MessageBox.Show(
                    "Bạn có chắc muốn xóa khách hàng này? (Tất cả lịch sử thuê sách của khách hàng này cũng sẽ bị xóa nếu CSDL có cài đặt 'ON DELETE CASCADE')",
                    "Xác nhận xóa",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (confirm == DialogResult.Yes)
                {
                    _customerRepository.DeleteCustomer(id);
                    MessageBox.Show("Xóa khách hàng thành công!");
                    LoadCustomers();
                    ClearCustomerPanel();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa khách hàng: " + ex.Message);
            }
        }

        private void ClearCustomerPanel()
        {
            lblSelectedCustomer.Text = "0";
            txtCustomerFullName.Text = "";
            txtCustomerEmail.Text = "";
        }
    }
}