using System;
using System.Windows.Forms;

namespace BookStoreManagementSystem
{
    public partial class MainForm : Form
    {
        private readonly BookRepository _bookRepository;

        public MainForm()
        {
            InitializeComponent();
            _bookRepository = new BookRepository();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Book Store Management System!");
        }
    }
}
