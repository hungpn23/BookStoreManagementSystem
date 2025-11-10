namespace BookStoreManagementSystem
{
    partial class BookForm
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.btnShowAll = new System.Windows.Forms.Button();
            this.grpEditBook = new System.Windows.Forms.GroupBox();
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
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currentCustomerId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyRentalFee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.grpEditBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEditDailyRentalFee)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(282, 7);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 26);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(13, 9);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(261, 21);
            this.txtSearchName.TabIndex = 31;
            // 
            // btnShowAll
            // 
            this.btnShowAll.Location = new System.Drawing.Point(365, 7);
            this.btnShowAll.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAll.Name = "btnShowAll";
            this.btnShowAll.Size = new System.Drawing.Size(117, 26);
            this.btnShowAll.TabIndex = 33;
            this.btnShowAll.Text = "Show All";
            this.btnShowAll.UseVisualStyleBackColor = true;
            this.btnShowAll.Click += new System.EventHandler(this.btnShowAll_Click);
            // 
            // grpEditBook
            // 
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
            this.grpEditBook.Location = new System.Drawing.Point(800, 13);
            this.grpEditBook.Margin = new System.Windows.Forms.Padding(4);
            this.grpEditBook.Name = "grpEditBook";
            this.grpEditBook.Padding = new System.Windows.Forms.Padding(4);
            this.grpEditBook.Size = new System.Drawing.Size(345, 624);
            this.grpEditBook.TabIndex = 30;
            this.grpEditBook.TabStop = false;
            this.grpEditBook.Text = "Book ID:";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(181, 261);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(93, 46);
            this.btnDelete.TabIndex = 25;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblSelectedBookId
            // 
            this.lblSelectedBookId.AutoSize = true;
            this.lblSelectedBookId.Location = new System.Drawing.Point(77, 0);
            this.lblSelectedBookId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedBookId.Name = "lblSelectedBookId";
            this.lblSelectedBookId.Size = new System.Drawing.Size(14, 16);
            this.lblSelectedBookId.TabIndex = 24;
            this.lblSelectedBookId.Text = "0";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(80, 261);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(93, 46);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbEditAuthors
            // 
            this.cmbEditAuthors.FormattingEnabled = true;
            this.cmbEditAuthors.Location = new System.Drawing.Point(93, 209);
            this.cmbEditAuthors.Margin = new System.Windows.Forms.Padding(4);
            this.cmbEditAuthors.Name = "cmbEditAuthors";
            this.cmbEditAuthors.Size = new System.Drawing.Size(215, 24);
            this.cmbEditAuthors.TabIndex = 21;
            // 
            // dtpEditPublishedDate
            // 
            this.dtpEditPublishedDate.Location = new System.Drawing.Point(44, 130);
            this.dtpEditPublishedDate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpEditPublishedDate.Name = "dtpEditPublishedDate";
            this.dtpEditPublishedDate.Size = new System.Drawing.Size(282, 21);
            this.dtpEditPublishedDate.TabIndex = 20;
            // 
            // numEditDailyRentalFee
            // 
            this.numEditDailyRentalFee.DecimalPlaces = 2;
            this.numEditDailyRentalFee.Location = new System.Drawing.Point(113, 171);
            this.numEditDailyRentalFee.Margin = new System.Windows.Forms.Padding(4);
            this.numEditDailyRentalFee.Name = "numEditDailyRentalFee";
            this.numEditDailyRentalFee.Size = new System.Drawing.Size(140, 21);
            this.numEditDailyRentalFee.TabIndex = 19;
            // 
            // txtEditType
            // 
            this.txtEditType.Location = new System.Drawing.Point(93, 66);
            this.txtEditType.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditType.Name = "txtEditType";
            this.txtEditType.Size = new System.Drawing.Size(215, 21);
            this.txtEditType.TabIndex = 18;
            // 
            // txtEditName
            // 
            this.txtEditName.Location = new System.Drawing.Point(93, 33);
            this.txtEditName.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditName.Name = "txtEditName";
            this.txtEditName.Size = new System.Drawing.Size(215, 21);
            this.txtEditName.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 213);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 16;
            this.label5.Text = "Author";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 107);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Published Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 174);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Daily Fee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Type";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // dgvBooks
            // 
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AllowUserToResizeRows = false;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.authorId,
            this.currentCustomerId,
            this.name,
            this.type,
            this.authorName,
            this.publishedDate,
            this.dailyRentalFee});
            this.dgvBooks.Location = new System.Drawing.Point(13, 38);
            this.dgvBooks.Margin = new System.Windows.Forms.Padding(4);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dgvBooks.RowHeadersVisible = false;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(779, 599);
            this.dgvBooks.TabIndex = 28;
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
            // btnAddBook
            // 
            this.btnAddBook.ForeColor = System.Drawing.Color.Black;
            this.btnAddBook.Location = new System.Drawing.Point(490, 7);
            this.btnAddBook.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(63, 26);
            this.btnAddBook.TabIndex = 29;
            this.btnAddBook.Text = "Add";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // BookForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 649);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.btnShowAll);
            this.Controls.Add(this.grpEditBook);
            this.Controls.Add(this.dgvBooks);
            this.Controls.Add(this.btnAddBook);
            this.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BookForm";
            this.Load += new System.EventHandler(this.BookForm_Load);
            this.grpEditBook.ResumeLayout(false);
            this.grpEditBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numEditDailyRentalFee)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Button btnShowAll;
        private System.Windows.Forms.GroupBox grpEditBook;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSelectedBookId;
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
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn currentCustomerId;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorName;
        private System.Windows.Forms.DataGridViewTextBoxColumn publishedDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dailyRentalFee;
        private System.Windows.Forms.Button btnAddBook;
    }
}