namespace BookStoreManagementSystem
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvRentals = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rentalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.actualReturnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyFeeAtRental = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.Font = new System.Drawing.Font("Cascadia Code", 8F);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(51, 20);
            this.toolStripMenuItem1.Text = "Books";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.booksToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(61, 20);
            this.toolStripMenuItem2.Text = "Authors";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.authorsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(76, 20);
            this.toolStripMenuItem3.Text = "Customers";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.customersToolStripMenuItem_Click);
            // 
            // dgvRentals
            // 
            this.dgvRentals.AllowUserToAddRows = false;
            this.dgvRentals.AllowUserToDeleteRows = false;
            this.dgvRentals.AllowUserToResizeRows = false;
            this.dgvRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRentals.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.bookId,
            this.customerId,
            this.bookName,
            this.customerName,
            this.rentalDate,
            this.dueDate,
            this.actualReturnDate,
            this.dailyFeeAtRental,
            this.totalFee,
            this.status});
            this.dgvRentals.Location = new System.Drawing.Point(12, 62);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.ReadOnly = true;
            this.dgvRentals.RowHeadersVisible = false;
            this.dgvRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentals.Size = new System.Drawing.Size(858, 607);
            this.dgvRentals.TabIndex = 1;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // bookId
            // 
            this.bookId.DataPropertyName = "book_id";
            this.bookId.HeaderText = "Book ID";
            this.bookId.Name = "bookId";
            this.bookId.ReadOnly = true;
            this.bookId.Visible = false;
            // 
            // customerId
            // 
            this.customerId.DataPropertyName = "customer_id";
            this.customerId.HeaderText = "Customer ID";
            this.customerId.Name = "customerId";
            this.customerId.ReadOnly = true;
            this.customerId.Visible = false;
            // 
            // bookName
            // 
            this.bookName.DataPropertyName = "book_name";
            this.bookName.HeaderText = "Book Name";
            this.bookName.Name = "bookName";
            this.bookName.ReadOnly = true;
            this.bookName.Width = 107;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "customer_name";
            this.customerName.HeaderText = "Customer Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 107;
            // 
            // rentalDate
            // 
            this.rentalDate.DataPropertyName = "rental_date";
            this.rentalDate.HeaderText = "Rental Date";
            this.rentalDate.Name = "rentalDate";
            this.rentalDate.ReadOnly = true;
            this.rentalDate.Width = 107;
            // 
            // dueDate
            // 
            this.dueDate.DataPropertyName = "due_date";
            this.dueDate.HeaderText = "Due Date";
            this.dueDate.Name = "dueDate";
            this.dueDate.ReadOnly = true;
            this.dueDate.Width = 107;
            // 
            // actualReturnDate
            // 
            this.actualReturnDate.DataPropertyName = "actual_return_date";
            this.actualReturnDate.HeaderText = "Actual Return Date";
            this.actualReturnDate.Name = "actualReturnDate";
            this.actualReturnDate.ReadOnly = true;
            this.actualReturnDate.Width = 106;
            // 
            // dailyFeeAtRental
            // 
            this.dailyFeeAtRental.DataPropertyName = "daily_fee_at_rental";
            this.dailyFeeAtRental.HeaderText = "Daily Fee At Rental";
            this.dailyFeeAtRental.Name = "dailyFeeAtRental";
            this.dailyFeeAtRental.ReadOnly = true;
            this.dailyFeeAtRental.Width = 107;
            // 
            // totalFee
            // 
            this.totalFee.DataPropertyName = "total_fee";
            this.totalFee.HeaderText = "Total Fee";
            this.totalFee.Name = "totalFee";
            this.totalFee.ReadOnly = true;
            this.totalFee.Width = 107;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 107;
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1184, 681);
            this.Controls.Add(this.dgvRentals);
            this.Controls.Add(this.menuStrip2);
            this.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.MainMenuStrip = this.menuStrip2;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book Rantel Management System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem booksToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.DataGridView dgvRentals;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookId;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookName;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn rentalDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn actualReturnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyFeeAtRental;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}