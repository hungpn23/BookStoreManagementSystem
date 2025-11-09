namespace BookStoreManagementSystem
{
    partial class AuthorForm
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
            this.dgvAuthors = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortBio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowAllAuthors = new System.Windows.Forms.Button();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.txtSearchAuthor = new System.Windows.Forms.TextBox();
            this.grpEditBook = new System.Windows.Forms.GroupBox();
            this.btnAuthorDelete = new System.Windows.Forms.Button();
            this.lblSelectedAuthorId = new System.Windows.Forms.Label();
            this.btnAuthorSave = new System.Windows.Forms.Button();
            this.dtpAuthorBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnAuthorClear = new System.Windows.Forms.Button();
            this.txtAuthorShortBio = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).BeginInit();
            this.grpEditBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAuthors
            // 
            this.dgvAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.birthDate,
            this.shortBio});
            this.dgvAuthors.Dock = System.Windows.Forms.DockStyle.Left;
            this.dgvAuthors.Location = new System.Drawing.Point(0, 0);
            this.dgvAuthors.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAuthors.Name = "dgvAuthors";
            this.dgvAuthors.RowHeadersWidth = 51;
            this.dgvAuthors.RowTemplate.Height = 24;
            this.dgvAuthors.Size = new System.Drawing.Size(568, 553);
            this.dgvAuthors.TabIndex = 0;
            this.dgvAuthors.SelectionChanged += new System.EventHandler(this.dgvAuthors_SelectionChanged);
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
            // birthDate
            // 
            this.birthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.birthDate.DataPropertyName = "birth_date";
            this.birthDate.HeaderText = "Birth Date";
            this.birthDate.MinimumWidth = 6;
            this.birthDate.Name = "birthDate";
            // 
            // shortBio
            // 
            this.shortBio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shortBio.DataPropertyName = "short_bio";
            this.shortBio.HeaderText = "Short Bio";
            this.shortBio.MinimumWidth = 6;
            this.shortBio.Name = "shortBio";
            // 
            // btnShowAllAuthors
            // 
            this.btnShowAllAuthors.Location = new System.Drawing.Point(880, 9);
            this.btnShowAllAuthors.Name = "btnShowAllAuthors";
            this.btnShowAllAuthors.Size = new System.Drawing.Size(90, 29);
            this.btnShowAllAuthors.TabIndex = 32;
            this.btnShowAllAuthors.Text = "Show All";
            this.btnShowAllAuthors.UseVisualStyleBackColor = true;
            this.btnShowAllAuthors.Click += new System.EventHandler(this.btnShowAllAuthors_Click);
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.Location = new System.Drawing.Point(795, 9);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(79, 29);
            this.btnSearchAuthor.TabIndex = 31;
            this.btnSearchAuthor.Text = "Search";
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            this.btnSearchAuthor.Click += new System.EventHandler(this.btnSearchAuthor_Click);
            // 
            // txtSearchAuthor
            // 
            this.txtSearchAuthor.Location = new System.Drawing.Point(585, 12);
            this.txtSearchAuthor.Name = "txtSearchAuthor";
            this.txtSearchAuthor.Size = new System.Drawing.Size(205, 25);
            this.txtSearchAuthor.TabIndex = 30;
            // 
            // grpEditBook
            // 
            this.grpEditBook.Controls.Add(this.btnAuthorDelete);
            this.grpEditBook.Controls.Add(this.lblSelectedAuthorId);
            this.grpEditBook.Controls.Add(this.btnAuthorSave);
            this.grpEditBook.Controls.Add(this.dtpAuthorBirthDate);
            this.grpEditBook.Controls.Add(this.btnAuthorClear);
            this.grpEditBook.Controls.Add(this.txtAuthorShortBio);
            this.grpEditBook.Controls.Add(this.txtAuthorName);
            this.grpEditBook.Controls.Add(this.label4);
            this.grpEditBook.Controls.Add(this.label2);
            this.grpEditBook.Controls.Add(this.label1);
            this.grpEditBook.Location = new System.Drawing.Point(660, 98);
            this.grpEditBook.Name = "grpEditBook";
            this.grpEditBook.Size = new System.Drawing.Size(270, 250);
            this.grpEditBook.TabIndex = 29;
            this.grpEditBook.TabStop = false;
            this.grpEditBook.Text = "Author Details";
            // 
            // btnAuthorDelete
            // 
            this.btnAuthorDelete.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAuthorDelete.ForeColor = System.Drawing.Color.Red;
            this.btnAuthorDelete.Location = new System.Drawing.Point(139, 200);
            this.btnAuthorDelete.Name = "btnAuthorDelete";
            this.btnAuthorDelete.Size = new System.Drawing.Size(72, 34);
            this.btnAuthorDelete.TabIndex = 25;
            this.btnAuthorDelete.Text = "Delete";
            this.btnAuthorDelete.UseVisualStyleBackColor = false;
            this.btnAuthorDelete.Click += new System.EventHandler(this.btnAuthorDelete_Click);
            // 
            // lblSelectedAuthorId
            // 
            this.lblSelectedAuthorId.AutoSize = true;
            this.lblSelectedAuthorId.Location = new System.Drawing.Point(149, 0);
            this.lblSelectedAuthorId.Name = "lblSelectedAuthorId";
            this.lblSelectedAuthorId.Size = new System.Drawing.Size(18, 20);
            this.lblSelectedAuthorId.TabIndex = 24;
            this.lblSelectedAuthorId.Text = "0";
            // 
            // btnAuthorSave
            // 
            this.btnAuthorSave.Location = new System.Drawing.Point(44, 200);
            this.btnAuthorSave.Name = "btnAuthorSave";
            this.btnAuthorSave.Size = new System.Drawing.Size(72, 34);
            this.btnAuthorSave.TabIndex = 22;
            this.btnAuthorSave.Text = "Save";
            this.btnAuthorSave.UseVisualStyleBackColor = true;
            this.btnAuthorSave.Click += new System.EventHandler(this.btnAuthorSave_Click);
            // 
            // dtpAuthorBirthDate
            // 
            this.dtpAuthorBirthDate.Location = new System.Drawing.Point(45, 158);
            this.dtpAuthorBirthDate.Name = "dtpAuthorBirthDate";
            this.dtpAuthorBirthDate.Size = new System.Drawing.Size(180, 25);
            this.dtpAuthorBirthDate.TabIndex = 20;
            // 
            // btnAuthorClear
            // 
            this.btnAuthorClear.Location = new System.Drawing.Point(196, 16);
            this.btnAuthorClear.Name = "btnAuthorClear";
            this.btnAuthorClear.Size = new System.Drawing.Size(68, 34);
            this.btnAuthorClear.TabIndex = 28;
            this.btnAuthorClear.Text = "Clear";
            this.btnAuthorClear.UseVisualStyleBackColor = true;
            this.btnAuthorClear.Click += new System.EventHandler(this.btnAuthorNew_Click);
            // 
            // txtAuthorShortBio
            // 
            this.txtAuthorShortBio.Location = new System.Drawing.Point(21, 90);
            this.txtAuthorShortBio.Multiline = true;
            this.txtAuthorShortBio.Name = "txtAuthorShortBio";
            this.txtAuthorShortBio.Size = new System.Drawing.Size(226, 25);
            this.txtAuthorShortBio.TabIndex = 18;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(72, 25);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(90, 25);
            this.txtAuthorName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 15;
            this.label4.Text = "Birth Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Short Bio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(982, 553);
            this.Controls.Add(this.btnShowAllAuthors);
            this.Controls.Add(this.btnSearchAuthor);
            this.Controls.Add(this.txtSearchAuthor);
            this.Controls.Add(this.grpEditBook);
            this.Controls.Add(this.dgvAuthors);
            this.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AuthorForm";
            this.Load += new System.EventHandler(this.AuthorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).EndInit();
            this.grpEditBook.ResumeLayout(false);
            this.grpEditBook.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuthors;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortBio;
        private System.Windows.Forms.Button btnShowAllAuthors;
        private System.Windows.Forms.Button btnSearchAuthor;
        private System.Windows.Forms.TextBox txtSearchAuthor;
        private System.Windows.Forms.GroupBox grpEditBook;
        private System.Windows.Forms.Button btnAuthorDelete;
        private System.Windows.Forms.Label lblSelectedAuthorId;
        private System.Windows.Forms.Button btnAuthorSave;
        private System.Windows.Forms.DateTimePicker dtpAuthorBirthDate;
        private System.Windows.Forms.TextBox txtAuthorShortBio;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAuthorClear;
        private System.Windows.Forms.Label label1;
    }
}