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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnResetSearch = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.dtpSearchTo = new System.Windows.Forms.DateTimePicker();
            this.dtpSearchFrom = new System.Windows.Forms.DateTimePicker();
            this.cbSearchStatus = new System.Windows.Forms.ComboBox();
            this.cbSearchBook = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbSearchCustomer = new System.Windows.Forms.ComboBox();
            this.grpRentalActions = new System.Windows.Forms.GroupBox();
            this.btnDeleteRental = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnExtend = new System.Windows.Forms.Button();
            this.dtpNewDueDate = new System.Windows.Forms.DateTimePicker();
            this.lblCurrentDueDate = new System.Windows.Forms.Label();
            this.lblSelectedBook = new System.Windows.Forms.Label();
            this.lblSelectedStatus = new System.Windows.Forms.Label();
            this.lblSelectedCustomer = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddRental = new System.Windows.Forms.Button();
            this.btnRentalReport = new System.Windows.Forms.Button();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRentals)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpRentalActions.SuspendLayout();
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
            this.toolStripMenuItem1.Size = new System.Drawing.Size(49, 20);
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
            this.toolStripMenuItem3.Size = new System.Drawing.Size(73, 20);
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
            this.dgvRentals.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvRentals.Location = new System.Drawing.Point(0, 24);
            this.dgvRentals.Name = "dgvRentals";
            this.dgvRentals.ReadOnly = true;
            this.dgvRentals.RowHeadersVisible = false;
            this.dgvRentals.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRentals.Size = new System.Drawing.Size(878, 537);
            this.dgvRentals.TabIndex = 1;
            this.dgvRentals.SelectionChanged += new System.EventHandler(this.dgvRentals_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
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
            this.bookName.Width = 109;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "customer_name";
            this.customerName.HeaderText = "Customer Name";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            this.customerName.Width = 110;
            // 
            // rentalDate
            // 
            this.rentalDate.DataPropertyName = "rental_date";
            this.rentalDate.HeaderText = "Rental Date";
            this.rentalDate.Name = "rentalDate";
            this.rentalDate.ReadOnly = true;
            this.rentalDate.Width = 109;
            // 
            // dueDate
            // 
            this.dueDate.DataPropertyName = "due_date";
            this.dueDate.HeaderText = "Due Date";
            this.dueDate.Name = "dueDate";
            this.dueDate.ReadOnly = true;
            this.dueDate.Width = 110;
            // 
            // actualReturnDate
            // 
            this.actualReturnDate.DataPropertyName = "actual_return_date";
            this.actualReturnDate.HeaderText = "Actual Return Date";
            this.actualReturnDate.Name = "actualReturnDate";
            this.actualReturnDate.ReadOnly = true;
            this.actualReturnDate.Width = 109;
            // 
            // dailyFeeAtRental
            // 
            this.dailyFeeAtRental.DataPropertyName = "daily_fee_at_rental";
            this.dailyFeeAtRental.HeaderText = "Daily Fee At Rental";
            this.dailyFeeAtRental.Name = "dailyFeeAtRental";
            this.dailyFeeAtRental.ReadOnly = true;
            this.dailyFeeAtRental.Width = 109;
            // 
            // totalFee
            // 
            this.totalFee.DataPropertyName = "total_fee";
            this.totalFee.HeaderText = "Total Fee";
            this.totalFee.Name = "totalFee";
            this.totalFee.ReadOnly = true;
            this.totalFee.Width = 110;
            // 
            // status
            // 
            this.status.DataPropertyName = "status";
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 109;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnResetSearch);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.dtpSearchTo);
            this.groupBox1.Controls.Add(this.dtpSearchFrom);
            this.groupBox1.Controls.Add(this.cbSearchStatus);
            this.groupBox1.Controls.Add(this.cbSearchBook);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cbSearchCustomer);
            this.groupBox1.Location = new System.Drawing.Point(884, 37);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 216);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rental Search";
            // 
            // btnResetSearch
            // 
            this.btnResetSearch.Location = new System.Drawing.Point(166, 179);
            this.btnResetSearch.Name = "btnResetSearch";
            this.btnResetSearch.Size = new System.Drawing.Size(90, 28);
            this.btnResetSearch.TabIndex = 11;
            this.btnResetSearch.Text = "Reset";
            this.btnResetSearch.UseVisualStyleBackColor = true;
            this.btnResetSearch.Click += new System.EventHandler(this.btnResetSearch_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(70, 179);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 28);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // dtpSearchTo
            // 
            this.dtpSearchTo.Location = new System.Drawing.Point(47, 141);
            this.dtpSearchTo.Name = "dtpSearchTo";
            this.dtpSearchTo.Size = new System.Drawing.Size(235, 21);
            this.dtpSearchTo.TabIndex = 9;
            // 
            // dtpSearchFrom
            // 
            this.dtpSearchFrom.Location = new System.Drawing.Point(47, 114);
            this.dtpSearchFrom.Name = "dtpSearchFrom";
            this.dtpSearchFrom.Size = new System.Drawing.Size(235, 21);
            this.dtpSearchFrom.TabIndex = 8;
            // 
            // cbSearchStatus
            // 
            this.cbSearchStatus.FormattingEnabled = true;
            this.cbSearchStatus.Location = new System.Drawing.Point(75, 84);
            this.cbSearchStatus.Name = "cbSearchStatus";
            this.cbSearchStatus.Size = new System.Drawing.Size(207, 24);
            this.cbSearchStatus.TabIndex = 7;
            // 
            // cbSearchBook
            // 
            this.cbSearchBook.FormattingEnabled = true;
            this.cbSearchBook.Location = new System.Drawing.Point(75, 52);
            this.cbSearchBook.Name = "cbSearchBook";
            this.cbSearchBook.Size = new System.Drawing.Size(207, 24);
            this.cbSearchBook.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "From";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Status";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Book";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Customer";
            // 
            // cbSearchCustomer
            // 
            this.cbSearchCustomer.FormattingEnabled = true;
            this.cbSearchCustomer.Location = new System.Drawing.Point(75, 20);
            this.cbSearchCustomer.Name = "cbSearchCustomer";
            this.cbSearchCustomer.Size = new System.Drawing.Size(207, 24);
            this.cbSearchCustomer.TabIndex = 0;
            // 
            // grpRentalActions
            // 
            this.grpRentalActions.Controls.Add(this.btnDeleteRental);
            this.grpRentalActions.Controls.Add(this.btnReturnBook);
            this.grpRentalActions.Controls.Add(this.btnExtend);
            this.grpRentalActions.Controls.Add(this.dtpNewDueDate);
            this.grpRentalActions.Controls.Add(this.lblCurrentDueDate);
            this.grpRentalActions.Controls.Add(this.lblSelectedBook);
            this.grpRentalActions.Controls.Add(this.lblSelectedStatus);
            this.grpRentalActions.Controls.Add(this.lblSelectedCustomer);
            this.grpRentalActions.Controls.Add(this.label10);
            this.grpRentalActions.Controls.Add(this.label6);
            this.grpRentalActions.Controls.Add(this.label9);
            this.grpRentalActions.Controls.Add(this.label7);
            this.grpRentalActions.Controls.Add(this.label8);
            this.grpRentalActions.Enabled = false;
            this.grpRentalActions.Location = new System.Drawing.Point(884, 259);
            this.grpRentalActions.Name = "grpRentalActions";
            this.grpRentalActions.Size = new System.Drawing.Size(288, 209);
            this.grpRentalActions.TabIndex = 3;
            this.grpRentalActions.TabStop = false;
            this.grpRentalActions.Text = "Rental Actions";
            // 
            // btnDeleteRental
            // 
            this.btnDeleteRental.ForeColor = System.Drawing.Color.Red;
            this.btnDeleteRental.Location = new System.Drawing.Point(185, 174);
            this.btnDeleteRental.Name = "btnDeleteRental";
            this.btnDeleteRental.Size = new System.Drawing.Size(63, 28);
            this.btnDeleteRental.TabIndex = 22;
            this.btnDeleteRental.Text = "Delete";
            this.btnDeleteRental.UseVisualStyleBackColor = true;
            this.btnDeleteRental.Click += new System.EventHandler(this.btnDeleteRental_Click);
            // 
            // btnReturnBook
            // 
            this.btnReturnBook.Location = new System.Drawing.Point(110, 174);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(69, 28);
            this.btnReturnBook.TabIndex = 21;
            this.btnReturnBook.Text = "Return";
            this.btnReturnBook.UseVisualStyleBackColor = true;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            // 
            // btnExtend
            // 
            this.btnExtend.Location = new System.Drawing.Point(32, 174);
            this.btnExtend.Name = "btnExtend";
            this.btnExtend.Size = new System.Drawing.Size(72, 28);
            this.btnExtend.TabIndex = 12;
            this.btnExtend.Text = "Extend";
            this.btnExtend.UseVisualStyleBackColor = true;
            this.btnExtend.Click += new System.EventHandler(this.btnExtend_Click);
            // 
            // dtpNewDueDate
            // 
            this.dtpNewDueDate.Location = new System.Drawing.Point(21, 147);
            this.dtpNewDueDate.Name = "dtpNewDueDate";
            this.dtpNewDueDate.Size = new System.Drawing.Size(235, 21);
            this.dtpNewDueDate.TabIndex = 12;
            // 
            // lblCurrentDueDate
            // 
            this.lblCurrentDueDate.AutoSize = true;
            this.lblCurrentDueDate.Location = new System.Drawing.Point(88, 101);
            this.lblCurrentDueDate.Name = "lblCurrentDueDate";
            this.lblCurrentDueDate.Size = new System.Drawing.Size(133, 16);
            this.lblCurrentDueDate.TabIndex = 20;
            this.lblCurrentDueDate.Text = "[ (Ngày hết hạn) ]";
            // 
            // lblSelectedBook
            // 
            this.lblSelectedBook.AutoSize = true;
            this.lblSelectedBook.Location = new System.Drawing.Point(88, 26);
            this.lblSelectedBook.Name = "lblSelectedBook";
            this.lblSelectedBook.Size = new System.Drawing.Size(105, 16);
            this.lblSelectedBook.TabIndex = 17;
            this.lblSelectedBook.Text = "[ (Tên sách) ]";
            // 
            // lblSelectedStatus
            // 
            this.lblSelectedStatus.AutoSize = true;
            this.lblSelectedStatus.Location = new System.Drawing.Point(88, 75);
            this.lblSelectedStatus.Name = "lblSelectedStatus";
            this.lblSelectedStatus.Size = new System.Drawing.Size(119, 16);
            this.lblSelectedStatus.TabIndex = 19;
            this.lblSelectedStatus.Text = "[ (Trạng thái) ]";
            // 
            // lblSelectedCustomer
            // 
            this.lblSelectedCustomer.AutoSize = true;
            this.lblSelectedCustomer.Location = new System.Drawing.Point(88, 51);
            this.lblSelectedCustomer.Name = "lblSelectedCustomer";
            this.lblSelectedCustomer.Size = new System.Drawing.Size(112, 16);
            this.lblSelectedCustomer.TabIndex = 18;
            this.lblSelectedCustomer.Text = "[ (Tên khách) ]";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 125);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "New Due Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 15;
            this.label6.Text = "Due Date";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(46, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 16);
            this.label9.TabIndex = 12;
            this.label9.Text = "Book";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 16);
            this.label7.TabIndex = 14;
            this.label7.Text = "Status";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Customer";
            // 
            // btnAddRental
            // 
            this.btnAddRental.Font = new System.Drawing.Font("Cascadia Code", 16F);
            this.btnAddRental.Location = new System.Drawing.Point(931, 493);
            this.btnAddRental.Name = "btnAddRental";
            this.btnAddRental.Size = new System.Drawing.Size(90, 38);
            this.btnAddRental.TabIndex = 23;
            this.btnAddRental.Text = "+ Add";
            this.btnAddRental.UseVisualStyleBackColor = true;
            this.btnAddRental.Click += new System.EventHandler(this.btnAddRental_Click);
            // 
            // btnRentalReport
            // 
            this.btnRentalReport.Font = new System.Drawing.Font("Cascadia Code", 16F);
            this.btnRentalReport.Location = new System.Drawing.Point(1042, 493);
            this.btnRentalReport.Name = "btnRentalReport";
            this.btnRentalReport.Size = new System.Drawing.Size(112, 38);
            this.btnRentalReport.TabIndex = 24;
            this.btnRentalReport.Text = "Report";
            this.btnRentalReport.UseVisualStyleBackColor = true;
            this.btnRentalReport.Click += new System.EventHandler(this.btnRentalReport_Click);
            // 
            // MainForm
            // 
            this.ClientSize = new System.Drawing.Size(1184, 561);
            this.Controls.Add(this.btnRentalReport);
            this.Controls.Add(this.btnAddRental);
            this.Controls.Add(this.grpRentalActions);
            this.Controls.Add(this.groupBox1);
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
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpRentalActions.ResumeLayout(false);
            this.grpRentalActions.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbSearchCustomer;
        private System.Windows.Forms.ComboBox cbSearchStatus;
        private System.Windows.Forms.ComboBox cbSearchBook;
        private System.Windows.Forms.DateTimePicker dtpSearchTo;
        private System.Windows.Forms.DateTimePicker dtpSearchFrom;
        private System.Windows.Forms.Button btnResetSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grpRentalActions;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCurrentDueDate;
        private System.Windows.Forms.Label lblSelectedBook;
        private System.Windows.Forms.Label lblSelectedStatus;
        private System.Windows.Forms.Label lblSelectedCustomer;
        private System.Windows.Forms.Button btnExtend;
        private System.Windows.Forms.DateTimePicker dtpNewDueDate;
        private System.Windows.Forms.Button btnReturnBook;
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
        private System.Windows.Forms.Button btnDeleteRental;
        private System.Windows.Forms.Button btnAddRental;
        private System.Windows.Forms.Button btnRentalReport;
    }
}