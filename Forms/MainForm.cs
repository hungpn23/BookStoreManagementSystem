using BookStoreManagementSystem.DataAccess;
using BookStoreManagementSystem.Forms;
using BookStoreManagementSystem.Models;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookStoreManagementSystem
{
    public partial class MainForm : Form
    {
        private readonly BookRentalRepository _rentalRepository;
        private readonly CustomerRepository _customerRepository;
        private readonly BookRepository _bookRepository;

        public MainForm()
        {
            InitializeComponent();
            _rentalRepository = new BookRentalRepository();
            _customerRepository = new CustomerRepository();
            _bookRepository = new BookRepository();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadRentals();
            LoadSearchComboBoxes();
        }

        private void LoadRentals()
        {
            try
            {
                dgvRentals.DataSource = _rentalRepository.GetAllRentalsWithDetailsForDGV();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải danh sách thuê sách: " + ex.Message);
            }
        }

        /// <summary>
        /// Chuẩn bị dữ liệu cho các ComboBox tìm kiếm
        /// </summary>
        private void LoadSearchComboBoxes()
        {
            // === Tải Khách hàng (Customer) ===
            DataTable dtCustomers = _customerRepository.GetAllCustomers();
            DataRow customerAllRow = dtCustomers.NewRow();
            customerAllRow["id"] = DBNull.Value; // Quan trọng: giá trị là NULL
            customerAllRow["full_name"] = "[ Tất cả khách hàng ]";
            dtCustomers.Rows.InsertAt(customerAllRow, 0); // Thêm vào đầu

            cbSearchCustomer.DataSource = dtCustomers;
            cbSearchCustomer.DisplayMember = "full_name";
            cbSearchCustomer.ValueMember = "id"; // Value sẽ là NULL nếu chọn "Tất cả"

            // === Tải Sách (Book) ===
            DataTable dtBooks = _bookRepository.GetAllBooksWithDetails(); // Lấy tất cả sách
            DataRow bookAllRow = dtBooks.NewRow();
            bookAllRow["id"] = DBNull.Value;
            bookAllRow["name"] = "[ Tất cả sách ]";
            dtBooks.Rows.InsertAt(bookAllRow, 0);

            cbSearchBook.DataSource = dtBooks;
            cbSearchBook.DisplayMember = "name";
            cbSearchBook.ValueMember = "id";

            // === Tải Trạng thái (Status) ===
            // Cách đơn giản để tải Enum vào ComboBox
            var statuses = new BindingSource
            {
                new { Value = (RentalStatus?)null, Name = "[ Tất cả trạng thái ]" },
                new { Value = (RentalStatus?)RentalStatus.Renting, Name = "Đang thuê" },
                new { Value = (RentalStatus?)RentalStatus.Returned, Name = "Đã trả" },
                new { Value = (RentalStatus?)RentalStatus.Overdue, Name = "Quá hạn" }
            };

            cbSearchStatus.DataSource = statuses;
            cbSearchStatus.DisplayMember = "Name";
            cbSearchStatus.ValueMember = "Value";
        }

        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AuthorForm authorForm = new AuthorForm();

            authorForm.ShowDialog();
        }

        private void customersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CustomerForm customerForm = new CustomerForm();

            customerForm.ShowDialog();
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookForm bookForm = new BookForm();

            bookForm.ShowDialog();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Tạo đối tượng tiêu chí
                var criteria = new BookRentalSearchCriteria();

                // 2. Lấy giá trị từ ComboBox (an toàn)
                // Nếu SelectedValue là DBNull.Value, (int?) sẽ tự động là null
                criteria.CustomerId = cbSearchCustomer.SelectedValue as int?;
                criteria.BookId = cbSearchBook.SelectedValue as int?;
                criteria.Status = cbSearchStatus.SelectedValue as RentalStatus?;

                // 3. Lấy giá trị từ DateTimePicker
                // (Giả sử bạn có CheckBox "chkFilterByDate" để bật/tắt lọc ngày)
                // Nếu không, bạn có thể lọc luôn:
                criteria.DateFrom = dtpSearchFrom.Value;
                criteria.DateTo = dtpSearchTo.Value;

                // 4. Gọi hàm Search
                DataTable dtResults = _rentalRepository.SearchRentalsWithDetails(criteria);

                // 5. Cập nhật DGV
                dgvRentals.DataSource = dtResults;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tìm kiếm: " + ex.Message);
            }
        }

        private void btnResetSearch_Click(object sender, EventArgs e)
        {
            // 1. Đặt lại các ComboBox về "Tất cả"
            cbSearchCustomer.SelectedIndex = 0;
            cbSearchBook.SelectedIndex = 0;
            cbSearchStatus.SelectedIndex = 0;

            // 2. Đặt lại ngày (tùy chọn)
            dtpSearchFrom.Value = DateTime.Now.AddMonths(-1);
            dtpSearchTo.Value = DateTime.Now;

            // 3. Tải lại toàn bộ danh sách
            LoadRentals();
        }

        private void dgvRentals_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRentals.SelectedRows.Count > 0)
            {
                try
                {
                    DataGridViewRow row = dgvRentals.SelectedRows[0];

                    // Đọc dữ liệu từ các cột (kể cả cột ẩn)
                    // (Đảm bảo tên cột khớp với alias trong câu SQL của bạn)
                    int rentalId = Convert.ToInt32(row.Cells["id"].Value);
                    string bookName = row.Cells["bookName"].Value.ToString();
                    string customerName = row.Cells["customerName"].Value.ToString();
                    string statusStr = row.Cells["status"].Value.ToString();
                    DateTime dueDate = Convert.ToDateTime(row.Cells["dueDate"].Value);

                    // Chuyển đổi status string sang Enum
                    RentalStatus status = (RentalStatus)Enum.Parse(typeof(RentalStatus), statusStr, true);

                    // --- NẠP DỮ LIỆU VÀO PANEL ---

                    // Lưu ID vào một nơi (ví dụ: Tag của panel) để dùng lúc bấm nút
                    grpRentalActions.Tag = rentalId;

                    // Hiển thị thông tin
                    lblSelectedBook.Text = bookName;
                    lblSelectedCustomer.Text = customerName;
                    lblSelectedStatus.Text = statusStr;
                    lblCurrentDueDate.Text = dueDate.ToShortDateString();

                    // Đặt ngày gia hạn mặc định (ví dụ: 7 ngày tới)
                    dtpNewDueDate.Value = DateTime.Now.AddDays(7);

                    // --- LOGIC NGHIỆP VỤ QUAN TRỌNG ---
                    // Chỉ cho phép hành động nếu sách "Đang thuê" hoặc "Quá hạn"
                    if (status == RentalStatus.Renting || status == RentalStatus.Overdue)
                    {
                        grpRentalActions.Enabled = true;
                        btnExtend.Enabled = true;    // Cho phép gia hạn
                        btnReturnBook.Enabled = true; // Cho phép trả sách
                    }
                    else // Nếu status là "Returned" (Đã trả)
                    {
                        grpRentalActions.Enabled = true; // Vẫn cho xem thông tin
                        btnExtend.Enabled = false;       // Không cho gia hạn
                        btnReturnBook.Enabled = false;  // Không cho trả nữa
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi chọn hàng: " + ex.Message);
                    ClearAndDisableActionsPanel();
                }
            }
            else
            {
                // Nếu không có hàng nào được chọn (ví dụ: sau khi tìm kiếm không ra kết quả)
                ClearAndDisableActionsPanel();
            }
        }

        private void btnExtend_Click(object sender, EventArgs e)
        {
            try
            {
                int rentalId = Convert.ToInt32(grpRentalActions.Tag);
                if (rentalId == 0) return;

                DateTime newDueDate = dtpNewDueDate.Value;

                // Hỏi xác nhận
                var confirm = MessageBox.Show(
                    $"Bạn có chắc muốn gia hạn lượt thuê này đến ngày {newDueDate.ToShortDateString()}?",
                    "Xác nhận gia hạn",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    // (Bạn sẽ cần tạo hàm UpdateDueDate trong Repository)
                     _rentalRepository.UpdateDueDate(rentalId, newDueDate);

                    MessageBox.Show("Gia hạn thành công!");

                    // Tải lại Grid để thấy ngày mới
                    // (Tùy bạn, có thể gọi lại hàm Search hoặc hàm LoadAll)
                    //btnSearch.PerformClick();
                    LoadRentals();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi gia hạn: " + ex.Message);
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            try
            {
                int rentalId = Convert.ToInt32(grpRentalActions.Tag);
                if (rentalId == 0) return;

                // Hỏi xác nhận
                var confirm = MessageBox.Show(
                    $"Xác nhận trả sách: {lblSelectedBook.Text}?",
                    "Xác nhận trả sách",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question);

                if (confirm == DialogResult.Yes)
                {
                    // (Bạn sẽ cần tạo hàm ReturnBook trong Repository)
                    // Hàm này sẽ tự động:
                    // 1. SET ActualReturnDate = NOW()
                    // 2. SET Status = 'Returned'
                    // 3. Tính và SET TotalFee
                    // 4. Cập nhật bảng 'books' (SET current_customer_id = NULL)

                     _rentalRepository.ReturnBook(rentalId);

                    MessageBox.Show("Trả sách thành công!");

                    // Tải lại Grid để thấy status "Returned"
                    //btnSearch.PerformClick();
                    LoadRentals();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi trả sách: " + ex.Message);
            }
        }

        private void ClearAndDisableActionsPanel()
        {
            grpRentalActions.Tag = 0; // Đặt lại ID
            lblSelectedBook.Text = "(Chưa chọn)";
            lblSelectedCustomer.Text = "(Chưa chọn)";
            lblSelectedStatus.Text = "(Chưa chọn)";
            lblCurrentDueDate.Text = "(Chưa chọn)";
            grpRentalActions.Enabled = false;
        }

        private void btnDeleteRental_Click(object sender, EventArgs e)
        {
            try
            {
                int rentalId = Convert.ToInt32(grpRentalActions.Tag);
                if (rentalId == 0) return;

                var confirm = MessageBox.Show(
                    $"BẠN CÓ CHẮC MUỐN XÓA LỊCH SỬ THUÊ NÀY?\n\nSách: {lblSelectedBook.Text}\nKhách hàng: {lblSelectedCustomer.Text}\n\n(Nếu sách đang được thuê, hành động này sẽ tự động 'trả sách' về kho.)",
                    "Xác nhận XÓA",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning); // Biểu tượng cảnh báo

                if (confirm == DialogResult.Yes)
                {
                    _rentalRepository.DeleteRental(rentalId);
                    MessageBox.Show("Xóa lượt thuê thành công!");
                    LoadRentals(); // Tải lại
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa lượt thuê: " + ex.Message);
            }
        }

        private void btnAddRental_Click(object sender, EventArgs e)
        {
            AddRentalForm frmAddRental = new AddRentalForm();
            var result = frmAddRental.ShowDialog();

            // Nếu form Add báo OK, tải lại grid
            if (result == DialogResult.OK)
            {
                LoadRentals();
            }
        }

        private void btnRentalReport_Click(object sender, EventArgs e)
        {
            try
            {
                // 1. Lấy dữ liệu (data) đã được chuyển đổi sang List<T>
                // (Giả sử bạn đã tạo class RentalReportViewModel ở Bước 1)
                var rentalData = _rentalRepository.GetAllRentalsForReport();

                if (rentalData.Count == 0)
                {
                    MessageBox.Show("Không có dữ liệu để in báo cáo.");
                    return;
                }

                // 2. Tạo Form báo cáo
                // (Giả sử bạn đã tạo RentalReportForm ở Bước 3)
                RentalReportForm frmReport = new RentalReportForm();

                // 3. Truyền (data) vào Form và hiển thị
                frmReport.LoadReport(rentalData);
                frmReport.ShowDialog(); // Dùng ShowDialog để (focus) vào báo cáo
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tạo báo cáo: " + ex.Message);
            }
        }
    }
}
