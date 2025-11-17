using BookStoreManagementSystem.DataAccess;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookStoreManagementSystem.Forms
{
    public partial class AddRentalForm : Form
    {
        // Khai báo các repository cần thiết
        private readonly CustomerRepository _customerRepository;
        private readonly BookRepository _bookRepository;
        private readonly BookRentalRepository _rentalRepository;

        public AddRentalForm()
        {
            InitializeComponent();
            _customerRepository = new CustomerRepository();
            _bookRepository = new BookRepository();
            _rentalRepository = new BookRentalRepository();
        }

        private void AddRentalForm_Load(object sender, EventArgs e)
        {
            LoadCustomers();
            LoadAvailableBooks();

            // Đặt ngày hết hạn mặc định là 14 ngày tới
            dtpDueDate.Value = DateTime.Now.AddDays(14);
        }

        private void LoadCustomers()
        {
            try
            {
                DataTable dtCustomers = _customerRepository.GetAllCustomers();
                cbCustomers.DataSource = dtCustomers;
                cbCustomers.DisplayMember = "full_name";
                cbCustomers.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách khách hàng: " + ex.Message);
            }
        }

        private void LoadAvailableBooks()
        {
            try
            {
                // Chỉ lấy sách CÓ SẴN (available)
                DataTable dtBooks = _bookRepository.GetAvailableBooks();
                cbBooks.DataSource = dtBooks;
                cbBooks.DisplayMember = "name";
                cbBooks.ValueMember = "id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải danh sách sách có sẵn: " + ex.Message);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy và kiểm tra dữ liệu
                if (cbCustomers.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn một khách hàng.", "Lỗi");
                    return;
                }
                if (cbBooks.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn một cuốn sách (có sẵn).", "Lỗi");
                    return;
                }

                int customerId = (int)cbCustomers.SelectedValue;
                int bookId = (int)cbBooks.SelectedValue;
                DateTime dueDate = dtpDueDate.Value;

                if (dueDate <= DateTime.Now)
                {
                    MessageBox.Show("Ngày hết hạn phải ở trong tương lai.", "Lỗi");
                    return;
                }

                // 2. Gọi hàm CreateRental
                _rentalRepository.CreateRental(bookId, customerId, dueDate);

                // 3. Báo thành công và đóng form
                MessageBox.Show("Thêm lượt thuê thành công!", "Thông báo");
                this.DialogResult = DialogResult.OK; // Báo cho MainForm biết để tải lại
                this.Close();
            }
            catch (Exception ex)
            {
                // Hiển thị lỗi từ repository (ví dụ: "Sách đã được thuê")
                MessageBox.Show("Lỗi khi tạo lượt thuê: " + ex.Message, "Lỗi");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}