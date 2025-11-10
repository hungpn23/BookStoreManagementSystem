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
            this.bio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnShowAllAuthors = new System.Windows.Forms.Button();
            this.btnSearchAuthor = new System.Windows.Forms.Button();
            this.txtSearchAuthor = new System.Windows.Forms.TextBox();
            this.grpEditAuthor = new System.Windows.Forms.GroupBox();
            this.btnAuthorDelete = new System.Windows.Forms.Button();
            this.lblSelectedAuthorId = new System.Windows.Forms.Label();
            this.btnAuthorSave = new System.Windows.Forms.Button();
            this.dtpAuthorBirthDate = new System.Windows.Forms.DateTimePicker();
            this.btnAuthorClear = new System.Windows.Forms.Button();
            this.txtAuthorBio = new System.Windows.Forms.TextBox();
            this.txtAuthorName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).BeginInit();
            this.grpEditAuthor.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAuthors
            // 
            this.dgvAuthors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAuthors.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.birthDate,
            this.bio});
            this.dgvAuthors.Location = new System.Drawing.Point(0, 45);
            this.dgvAuthors.Margin = new System.Windows.Forms.Padding(4);
            this.dgvAuthors.Name = "dgvAuthors";
            this.dgvAuthors.ReadOnly = true;
            this.dgvAuthors.RowHeadersWidth = 51;
            this.dgvAuthors.RowTemplate.Height = 24;
            this.dgvAuthors.Size = new System.Drawing.Size(435, 319);
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
            this.id.ReadOnly = true;
            this.id.Visible = false;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.FillWeight = 73.85786F;
            this.name.HeaderText = "Name";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // birthDate
            // 
            this.birthDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.birthDate.DataPropertyName = "birth_date";
            this.birthDate.FillWeight = 73.85786F;
            this.birthDate.HeaderText = "Birth Date";
            this.birthDate.MinimumWidth = 6;
            this.birthDate.Name = "birthDate";
            this.birthDate.ReadOnly = true;
            // 
            // bio
            // 
            this.bio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bio.DataPropertyName = "bio";
            this.bio.FillWeight = 152.2843F;
            this.bio.HeaderText = "Bio";
            this.bio.MinimumWidth = 6;
            this.bio.Name = "bio";
            this.bio.ReadOnly = true;
            // 
            // btnShowAllAuthors
            // 
            this.btnShowAllAuthors.Location = new System.Drawing.Point(284, 9);
            this.btnShowAllAuthors.Name = "btnShowAllAuthors";
            this.btnShowAllAuthors.Size = new System.Drawing.Size(82, 29);
            this.btnShowAllAuthors.TabIndex = 32;
            this.btnShowAllAuthors.Text = "Show All";
            this.btnShowAllAuthors.UseVisualStyleBackColor = true;
            this.btnShowAllAuthors.Click += new System.EventHandler(this.btnShowAllAuthors_Click);
            // 
            // btnSearchAuthor
            // 
            this.btnSearchAuthor.Location = new System.Drawing.Point(217, 9);
            this.btnSearchAuthor.Name = "btnSearchAuthor";
            this.btnSearchAuthor.Size = new System.Drawing.Size(61, 29);
            this.btnSearchAuthor.TabIndex = 31;
            this.btnSearchAuthor.Text = "Search";
            this.btnSearchAuthor.UseVisualStyleBackColor = true;
            this.btnSearchAuthor.Click += new System.EventHandler(this.btnSearchAuthor_Click);
            // 
            // txtSearchAuthor
            // 
            this.txtSearchAuthor.Location = new System.Drawing.Point(7, 12);
            this.txtSearchAuthor.Name = "txtSearchAuthor";
            this.txtSearchAuthor.Size = new System.Drawing.Size(205, 21);
            this.txtSearchAuthor.TabIndex = 30;
            // 
            // grpEditAuthor
            // 
            this.grpEditAuthor.Controls.Add(this.btnAuthorDelete);
            this.grpEditAuthor.Controls.Add(this.lblSelectedAuthorId);
            this.grpEditAuthor.Controls.Add(this.btnAuthorSave);
            this.grpEditAuthor.Controls.Add(this.dtpAuthorBirthDate);
            this.grpEditAuthor.Controls.Add(this.btnAuthorClear);
            this.grpEditAuthor.Controls.Add(this.txtAuthorBio);
            this.grpEditAuthor.Controls.Add(this.txtAuthorName);
            this.grpEditAuthor.Controls.Add(this.label4);
            this.grpEditAuthor.Controls.Add(this.label2);
            this.grpEditAuthor.Controls.Add(this.label1);
            this.grpEditAuthor.Location = new System.Drawing.Point(442, 45);
            this.grpEditAuthor.Name = "grpEditAuthor";
            this.grpEditAuthor.Size = new System.Drawing.Size(271, 319);
            this.grpEditAuthor.TabIndex = 29;
            this.grpEditAuthor.TabStop = false;
            this.grpEditAuthor.Text = "Author ID:";
            // 
            // btnAuthorDelete
            // 
            this.btnAuthorDelete.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnAuthorDelete.ForeColor = System.Drawing.Color.Red;
            this.btnAuthorDelete.Location = new System.Drawing.Point(115, 217);
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
            this.lblSelectedAuthorId.Location = new System.Drawing.Point(81, 1);
            this.lblSelectedAuthorId.Name = "lblSelectedAuthorId";
            this.lblSelectedAuthorId.Size = new System.Drawing.Size(14, 16);
            this.lblSelectedAuthorId.TabIndex = 24;
            this.lblSelectedAuthorId.Text = "0";
            // 
            // btnAuthorSave
            // 
            this.btnAuthorSave.Location = new System.Drawing.Point(37, 217);
            this.btnAuthorSave.Name = "btnAuthorSave";
            this.btnAuthorSave.Size = new System.Drawing.Size(72, 34);
            this.btnAuthorSave.TabIndex = 22;
            this.btnAuthorSave.Text = "Save";
            this.btnAuthorSave.UseVisualStyleBackColor = true;
            this.btnAuthorSave.Click += new System.EventHandler(this.btnAuthorSave_Click);
            // 
            // dtpAuthorBirthDate
            // 
            this.dtpAuthorBirthDate.Location = new System.Drawing.Point(20, 190);
            this.dtpAuthorBirthDate.Name = "dtpAuthorBirthDate";
            this.dtpAuthorBirthDate.Size = new System.Drawing.Size(243, 21);
            this.dtpAuthorBirthDate.TabIndex = 20;
            // 
            // btnAuthorClear
            // 
            this.btnAuthorClear.Location = new System.Drawing.Point(84, 257);
            this.btnAuthorClear.Name = "btnAuthorClear";
            this.btnAuthorClear.Size = new System.Drawing.Size(59, 28);
            this.btnAuthorClear.TabIndex = 28;
            this.btnAuthorClear.Text = "Clear";
            this.btnAuthorClear.UseVisualStyleBackColor = true;
            this.btnAuthorClear.Click += new System.EventHandler(this.btnAuthorNew_Click);
            // 
            // txtAuthorBio
            // 
            this.txtAuthorBio.Location = new System.Drawing.Point(51, 51);
            this.txtAuthorBio.Multiline = true;
            this.txtAuthorBio.Name = "txtAuthorBio";
            this.txtAuthorBio.Size = new System.Drawing.Size(212, 117);
            this.txtAuthorBio.TabIndex = 18;
            // 
            // txtAuthorName
            // 
            this.txtAuthorName.Location = new System.Drawing.Point(58, 24);
            this.txtAuthorName.Name = "txtAuthorName";
            this.txtAuthorName.Size = new System.Drawing.Size(205, 21);
            this.txtAuthorName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Birth Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Name";
            // 
            // AuthorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 370);
            this.Controls.Add(this.btnShowAllAuthors);
            this.Controls.Add(this.btnSearchAuthor);
            this.Controls.Add(this.txtSearchAuthor);
            this.Controls.Add(this.grpEditAuthor);
            this.Controls.Add(this.dgvAuthors);
            this.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AuthorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AuthorForm";
            this.Load += new System.EventHandler(this.AuthorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuthors)).EndInit();
            this.grpEditAuthor.ResumeLayout(false);
            this.grpEditAuthor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAuthors;
        private System.Windows.Forms.Button btnShowAllAuthors;
        private System.Windows.Forms.Button btnSearchAuthor;
        private System.Windows.Forms.TextBox txtSearchAuthor;
        private System.Windows.Forms.GroupBox grpEditAuthor;
        private System.Windows.Forms.Button btnAuthorDelete;
        private System.Windows.Forms.Label lblSelectedAuthorId;
        private System.Windows.Forms.Button btnAuthorSave;
        private System.Windows.Forms.DateTimePicker dtpAuthorBirthDate;
        private System.Windows.Forms.TextBox txtAuthorBio;
        private System.Windows.Forms.TextBox txtAuthorName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAuthorClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn bio;
    }
}