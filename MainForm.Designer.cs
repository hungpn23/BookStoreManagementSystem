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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyRentalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.grpEditBook = new System.Windows.Forms.GroupBox();
            this.cmbEditCustomers = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSelectedBookId = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbEditAuthors = new System.Windows.Forms.ComboBox();
            this.dtpEditPublishedDate = new System.Windows.Forms.DateTimePicker();
            this.numEditDailyRentalFee = new System.Windows.Forms.NumericUpDown();
            this.txtEditType = new System.Windows.Forms.TextBox();
            this.txtEditName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.btnBookReport = new System.Windows.Forms.Button();
            this.customerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpEditBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEditDailyRentalFee)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.authorId,
            this.currentCustomerId,
            this.name,
            this.type,
            this.authorName,
            this.publishedDate,
            this.dailyRentalFee,
            this.customerName});
            this.dgvBooks.Location = new System.Drawing.Point(0, 66);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(668, 487);
            this.dgvBooks.TabIndex = 0;
            this.dgvBooks.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvBooks_CellDoubleClick);
            this.dgvBooks.SelectionChanged += new System.EventHandler(this.dgvBooks_SelectionChanged);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // authorId
            // 
            this.authorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.authorId.DataPropertyName = "author_id";
            this.authorId.HeaderText = "Author ID";
            this.authorId.MinimumWidth = 6;
            this.authorId.Name = "authorId";
            this.authorId.ReadOnly = true;
            this.authorId.Visible = false;
            // 
            // currentCustomerId
            // 
            this.currentCustomerId.DataPropertyName = "current_customer_id";
            this.currentCustomerId.HeaderText = "Current Customer ID";
            this.currentCustomerId.Name = "currentCustomerId";
            this.currentCustomerId.ReadOnly = true;
            this.currentCustomerId.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.type.DataPropertyName = "type";
            this.type.HeaderText = "Type";
            this.type.MinimumWidth = 6;
            this.type.Name = "type";
            this.type.ReadOnly = true;
            // 
            // authorName
            // 
            this.authorName.DataPropertyName = "author_name";
            this.authorName.HeaderText = "Author";
            this.authorName.MinimumWidth = 6;
            this.authorName.Name = "authorName";
            this.authorName.ReadOnly = true;
            this.authorName.Width = 125;
            // 
            // publishedDate
            // 
            this.publishedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.publishedDate.DataPropertyName = "published_date";
            this.publishedDate.HeaderText = "Published Date";
            this.publishedDate.MinimumWidth = 6;
            this.publishedDate.Name = "publishedDate";
            this.publishedDate.ReadOnly = true;
            // 
            // dailyRentalFee
            // 
            this.dailyRentalFee.DataPropertyName = "daily_rental_fee";
            this.dailyRentalFee.HeaderText = "Daily Fee";
            this.dailyRentalFee.Name = "dailyRentalFee";
            this.dailyRentalFee.ReadOnly = true;
            // 
            // customerName
            // 
            this.customerName.DataPropertyName = "customer_name";
            this.customerName.HeaderText = "Customer";
            this.customerName.Name = "customerName";
            this.customerName.ReadOnly = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorsToolStripMenuItem,
            this.customerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(982, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.authorsToolStripMenuItem.Text = "Authors";
            this.authorsToolStripMenuItem.Click += new System.EventHandler(this.authorsToolStripMenuItem_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(406, 30);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(54, 30);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // grpEditBook
            // 
            this.grpEditBook.Controls.Add(this.cmbEditCustomers);
            this.grpEditBook.Controls.Add(this.label6);
            this.grpEditBook.Controls.Add(this.btnDelete);
            this.grpEditBook.Controls.Add(this.lblSelectedBookId);
            this.grpEditBook.Controls.Add(this.btnUpdate);
            this.grpEditBook.Controls.Add(this.cmbEditAuthors);
            this.grpEditBook.Controls.Add(this.dtpEditPublishedDate);
            this.grpEditBook.Controls.Add(this.numEditDailyRentalFee);
            this.grpEditBook.Controls.Add(this.txtEditType);
            this.grpEditBook.Controls.Add(this.txtEditName);
            this.grpEditBook.Controls.Add(this.label5);
            this.grpEditBook.Controls.Add(this.label4);
            this.grpEditBook.Controls.Add(this.label3);
            this.grpEditBook.Controls.Add(this.label2);
            this.grpEditBook.Controls.Add(this.label1);
            this.grpEditBook.Location = new System.Drawing.Point(674, 34);
            this.grpEditBook.Name = "grpEditBook";
            this.grpEditBook.Size = new System.Drawing.Size(296, 507);
            this.grpEditBook.TabIndex = 4;
            this.grpEditBook.TabStop = false;
            this.grpEditBook.Text = "Book ID:";
            // 
            // cmbEditCustomers
            // 
            this.cmbEditCustomers.FormattingEnabled = true;
            this.cmbEditCustomers.Location = new System.Drawing.Point(94, 203);
            this.cmbEditCustomers.Name = "cmbEditCustomers";
            this.cmbEditCustomers.Size = new System.Drawing.Size(186, 24);
            this.cmbEditCustomers.TabIndex = 28;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 206);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Customer";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(146, 233);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(80, 37);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSelectedBookId
            // 
            this.lblSelectedBookId.AutoSize = true;
            this.lblSelectedBookId.Location = new System.Drawing.Point(66, 0);
            this.lblSelectedBookId.Name = "lblSelectedBookId";
            this.lblSelectedBookId.Size = new System.Drawing.Size(14, 16);
            this.lblSelectedBookId.TabIndex = 24;
            this.lblSelectedBookId.Text = "0";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(60, 233);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(80, 37);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbEditAuthors
            // 
            this.cmbEditAuthors.FormattingEnabled = true;
            this.cmbEditAuthors.Location = new System.Drawing.Point(80, 170);
            this.cmbEditAuthors.Name = "cmbEditAuthors";
            this.cmbEditAuthors.Size = new System.Drawing.Size(185, 24);
            this.cmbEditAuthors.TabIndex = 21;
            // 
            // dtpEditPublishedDate
            // 
            this.dtpEditPublishedDate.Location = new System.Drawing.Point(38, 106);
            this.dtpEditPublishedDate.Name = "dtpEditPublishedDate";
            this.dtpEditPublishedDate.Size = new System.Drawing.Size(242, 21);
            this.dtpEditPublishedDate.TabIndex = 20;
            // 
            // numEditDailyRentalFee
            // 
            this.numEditDailyRentalFee.DecimalPlaces = 2;
            this.numEditDailyRentalFee.Location = new System.Drawing.Point(97, 139);
            this.numEditDailyRentalFee.Name = "numEditDailyRentalFee";
            this.numEditDailyRentalFee.Size = new System.Drawing.Size(120, 21);
            this.numEditDailyRentalFee.TabIndex = 19;
            // 
            // txtEditType
            // 
            this.txtEditType.Location = new System.Drawing.Point(80, 54);
            this.txtEditType.Name = "txtEditType";
            this.txtEditType.Size = new System.Drawing.Size(185, 21);
            this.txtEditType.TabIndex = 18;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(80, 27);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(185, 21);
            this.txtEditName.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Published Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Daily Fee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(9, 34);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(215, 21);
            this.txtSearchName.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(230, 30);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(64, 30);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(300, 30);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(100, 30);
            this.btnShowAll.TabIndex = 27;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnBookReport
            // 
            this.btnBookReport.Location = new System.Drawing.Point(466, 30);
            this.btnBookReport.Name = "btnBookReport";
            this.btnBookReport.Size = new System.Drawing.Size(81, 30);
            this.btnBookReport.TabIndex = 29;
            this.btnBookReport.Text = "Report";
            this.btnBookReport.UseVisualStyleBackColor = true;
            this.btnBookReport.Click += new System.EventHandler(this.btnBookReport_Click);
            // 
            // customerToolStripMenuItem
            // 
            this.customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            this.customerToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.customerToolStripMenuItem.Text = "Customer";
            this.customerToolStripMenuItem.Click += new System.EventHandler(this.customerToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnBookReport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.grpEditBook);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnAddBook);
            this.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Book store management system";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpEditBook.ResumeLayout(false);
            this.grpEditBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEditDailyRentalFee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.GroupBox grpEditBook;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbEditAuthors;
        private System.Windows.Forms.DateTimePicker dtpEditPublishedDate;
        private System.Windows.Forms.NumericUpDown numEditDailyRentalFee;
        private System.Windows.Forms.TextBox txtEditType;
        private System.Windows.Forms.TextBox txtEditName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSelectedBookId;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.Button btnBookReport;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cmbEditCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyRentalFee;
        private System.Windows.Forms.DataGridViewTextBoxColumn customerName;
        private System.Windows.Forms.ToolStripMenuItem customerToolStripMenuItem;
    }
}