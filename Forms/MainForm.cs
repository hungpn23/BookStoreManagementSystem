using System;
using System.Windows.Forms;

namespace BookStoreManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
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
