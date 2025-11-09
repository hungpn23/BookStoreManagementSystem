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
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.authorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listAuthorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.grpEditBook = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSelectedBookId = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbEditAuthors = new System.Windows.Forms.ComboBox();
            this.dtpEditPublishedDate = new System.Windows.Forms.DateTimePicker();
            this.numEditPrice = new System.Windows.Forms.NumericUpDown();
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
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.grpEditBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEditPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBooks
            // 
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.authorName,
            this.bookType,
            this.publishedDate,
            this.price,
            this.authorId});
            this.dgvBooks.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvBooks.Location = new System.Drawing.Point(0, 28);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.Size = new System.Drawing.Size(646, 525);
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
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // authorName
            // 
            this.authorName.DataPropertyName = "author_name";
            this.authorName.HeaderText = "Author Name";
            this.authorName.MinimumWidth = 6;
            this.authorName.Name = "authorName";
            this.authorName.Width = 125;
            // 
            // bookType
            // 
            this.bookType.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookType.DataPropertyName = "book_type";
            this.bookType.HeaderText = "Type";
            this.bookType.MinimumWidth = 6;
            this.bookType.Name = "bookType";
            // 
            // publishedDate
            // 
            this.publishedDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.publishedDate.DataPropertyName = "published_date";
            this.publishedDate.HeaderText = "Published Date";
            this.publishedDate.MinimumWidth = 6;
            this.publishedDate.Name = "publishedDate";
            // 
            // price
            // 
            this.price.DataPropertyName = "price";
            this.price.HeaderText = "Price";
            this.price.MinimumWidth = 6;
            this.price.Name = "price";
            this.price.Width = 125;
            // 
            // authorId
            // 
            this.authorId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.authorId.DataPropertyName = "author_id";
            this.authorId.HeaderText = "Author ID";
            this.authorId.MinimumWidth = 6;
            this.authorId.Name = "authorId";
            this.authorId.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.authorsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(982, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // authorsToolStripMenuItem
            // 
            this.authorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listAuthorsToolStripMenuItem});
            this.authorsToolStripMenuItem.Name = "authorsToolStripMenuItem";
            this.authorsToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.authorsToolStripMenuItem.Text = "Authors";
            // 
            // listAuthorsToolStripMenuItem
            // 
            this.listAuthorsToolStripMenuItem.Name = "listAuthorsToolStripMenuItem";
            this.listAuthorsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.listAuthorsToolStripMenuItem.Text = "List Authors";
            this.listAuthorsToolStripMenuItem.Click += new System.EventHandler(this.listAuthorsToolStripMenuItem_Click);
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(674, 151);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(51, 33);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // grpEditBook
            // 
            this.grpEditBook.Controls.Add(this.btnDelete);
            this.grpEditBook.Controls.Add(this.lblSelectedBookId);
            this.grpEditBook.Controls.Add(this.btnUpdate);
            this.grpEditBook.Controls.Add(this.cmbEditAuthors);
            this.grpEditBook.Controls.Add(this.dtpEditPublishedDate);
            this.grpEditBook.Controls.Add(this.numEditPrice);
            this.grpEditBook.Controls.Add(this.txtEditType);
            this.grpEditBook.Controls.Add(this.txtEditName);
            this.grpEditBook.Controls.Add(this.label5);
            this.grpEditBook.Controls.Add(this.label4);
            this.grpEditBook.Controls.Add(this.label3);
            this.grpEditBook.Controls.Add(this.label2);
            this.grpEditBook.Controls.Add(this.label1);
            this.grpEditBook.Location = new System.Drawing.Point(652, 191);
            this.grpEditBook.Name = "grpEditBook";
            this.grpEditBook.Size = new System.Drawing.Size(318, 350);
            this.grpEditBook.TabIndex = 4;
            this.grpEditBook.TabStop = false;
            this.grpEditBook.Text = "Book Details";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(170, 294);
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
            this.lblSelectedBookId.Location = new System.Drawing.Point(126, 0);
            this.lblSelectedBookId.Name = "lblSelectedBookId";
            this.lblSelectedBookId.Size = new System.Drawing.Size(18, 20);
            this.lblSelectedBookId.TabIndex = 24;
            this.lblSelectedBookId.Text = "0";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(64, 294);
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
            this.cmbEditAuthors.Location = new System.Drawing.Point(92, 232);
            this.cmbEditAuthors.Name = "cmbEditAuthors";
            this.cmbEditAuthors.Size = new System.Drawing.Size(121, 28);
            this.cmbEditAuthors.TabIndex = 21;
            // 
            // dtpEditPublishedDate
            // 
            this.dtpEditPublishedDate.Location = new System.Drawing.Point(50, 186);
            this.dtpEditPublishedDate.Name = "dtpEditPublishedDate";
            this.dtpEditPublishedDate.Size = new System.Drawing.Size(200, 25);
            this.dtpEditPublishedDate.TabIndex = 20;
            // 
            // numEditPrice
            // 
            this.numEditPrice.DecimalPlaces = 2;
            this.numEditPrice.Location = new System.Drawing.Point(92, 117);
            this.numEditPrice.Name = "numEditPrice";
            this.numEditPrice.Size = new System.Drawing.Size(120, 25);
            this.numEditPrice.TabIndex = 19;
            // 
            // txtEditType
            // 
            this.txtEditType.Location = new System.Drawing.Point(80, 71);
            this.txtEditType.Name = "txtEditType";
            this.txtEditType.Size = new System.Drawing.Size(100, 25);
            this.txtEditType.TabIndex = 18;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(80, 27);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(100, 25);
            this.txtEditName.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 235);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 20);
            this.label5.TabIndex = 16;
            this.label5.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(135, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Published Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Price";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(662, 45);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(227, 25);
            this.txtSearchName.TabIndex = 6;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(895, 42);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 32);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(744, 151);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(100, 32);
            this.btnShowAll.TabIndex = 27;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // btnBookReport
            // 
            this.btnBookReport.Location = new System.Drawing.Point(865, 151);
            this.btnBookReport.Name = "btnBookReport";
            this.btnBookReport.Size = new System.Drawing.Size(93, 32);
            this.btnBookReport.TabIndex = 29;
            this.btnBookReport.Text = "Report";
            this.btnBookReport.UseVisualStyleBackColor = true;
            this.btnBookReport.Click += new System.EventHandler(this.btnBookReport_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnBookReport);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.grpEditBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.menuStrip1);
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
            ((System.ComponentModel.ISupportInitialize)(this.numEditPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookType;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorId;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem authorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listAuthorsToolStripMenuItem;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.GroupBox grpEditBook;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox cmbEditAuthors;
        private System.Windows.Forms.DateTimePicker dtpEditPublishedDate;
        private System.Windows.Forms.NumericUpDown numEditPrice;
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
    }
}