using BookStoreManagementSystem.DataAccess;
using System;
using System.Data;
using System.Windows.Forms;

namespace BookStoreManagementSystem
{
    public partial class MainForm : Form
    {
        private BookRentalRepository _rentalRepository;

        public MainForm()
        {
            InitializeComponent();
            _rentalRepository = new BookRentalRepository();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadRentals();
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
    }
}
