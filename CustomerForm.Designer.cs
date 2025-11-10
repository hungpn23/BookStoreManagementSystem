namespace BookStoreManagementSystem
{
    partial class CustomerForm
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
            this.btnShowAllCustomers = new System.Windows.Forms.Button();
            this.btnSearchCustomer = new System.Windows.Forms.Button();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.grpEditCustomer = new System.Windows.Forms.GroupBox();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.lblSelectedCustomer = new System.Windows.Forms.Label();
            this.btnCustomerSave = new System.Windows.Forms.Button();
            this.btnCustomerClear = new System.Windows.Forms.Button();
            this.txtCustomerEmail = new System.Windows.Forms.TextBox();
            this.txtCustomerFullName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvCustomers = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpEditCustomer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).BeginInit();
            this.SuspendLayout();
            // 
            // btnShowAllCustomers
            // 
            this.btnShowAllCustomers.Location = new System.Drawing.Point(337, 11);
            this.btnShowAllCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowAllCustomers.Name = "btnShowAllCustomers";
            this.btnShowAllCustomers.Size = new System.Drawing.Size(96, 36);
            this.btnShowAllCustomers.TabIndex = 37;
            this.btnShowAllCustomers.Text = "Show All";
            this.btnShowAllCustomers.UseVisualStyleBackColor = true;
            this.btnShowAllCustomers.Click += new System.EventHandler(this.btnShowAllCustomers_Click);
            // 
            // btnSearchCustomer
            // 
            this.btnSearchCustomer.Location = new System.Drawing.Point(259, 11);
            this.btnSearchCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearchCustomer.Name = "btnSearchCustomer";
            this.btnSearchCustomer.Size = new System.Drawing.Size(71, 36);
            this.btnSearchCustomer.TabIndex = 36;
            this.btnSearchCustomer.Text = "Search";
            this.btnSearchCustomer.UseVisualStyleBackColor = true;
            this.btnSearchCustomer.Click += new System.EventHandler(this.btnSearchCustomer_Click);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Location = new System.Drawing.Point(6, 17);
            this.txtSearchCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(245, 21);
            this.txtSearchCustomer.TabIndex = 35;
            // 
            // grpEditCustomer
            // 
            this.grpEditCustomer.Controls.Add(this.btnCustomerDelete);
            this.grpEditCustomer.Controls.Add(this.lblSelectedCustomer);
            this.grpEditCustomer.Controls.Add(this.btnCustomerSave);
            this.grpEditCustomer.Controls.Add(this.btnCustomerClear);
            this.grpEditCustomer.Controls.Add(this.txtCustomerEmail);
            this.grpEditCustomer.Controls.Add(this.txtCustomerFullName);
            this.grpEditCustomer.Controls.Add(this.label2);
            this.grpEditCustomer.Controls.Add(this.label1);
            this.grpEditCustomer.Location = new System.Drawing.Point(522, 55);
            this.grpEditCustomer.Margin = new System.Windows.Forms.Padding(4);
            this.grpEditCustomer.Name = "grpEditCustomer";
            this.grpEditCustomer.Padding = new System.Windows.Forms.Padding(4);
            this.grpEditCustomer.Size = new System.Drawing.Size(274, 393);
            this.grpEditCustomer.TabIndex = 34;
            this.grpEditCustomer.TabStop = false;
            this.grpEditCustomer.Text = "Customer ID:";
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.BackColor = System.Drawing.SystemColors.HighlightText;
            this.btnCustomerDelete.ForeColor = System.Drawing.Color.Red;
            this.btnCustomerDelete.Location = new System.Drawing.Point(116, 92);
            this.btnCustomerDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(60, 28);
            this.btnCustomerDelete.TabIndex = 25;
            this.btnCustomerDelete.Text = "Delete";
            this.btnCustomerDelete.UseVisualStyleBackColor = false;
            this.btnCustomerDelete.Click += new System.EventHandler(this.btnCustomerDelete_Click);
            // 
            // lblSelectedCustomer
            // 
            this.lblSelectedCustomer.AutoSize = true;
            this.lblSelectedCustomer.Location = new System.Drawing.Point(95, 0);
            this.lblSelectedCustomer.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSelectedCustomer.Name = "lblSelectedCustomer";
            this.lblSelectedCustomer.Size = new System.Drawing.Size(14, 16);
            this.lblSelectedCustomer.TabIndex = 24;
            this.lblSelectedCustomer.Text = "0";
            // 
            // btnCustomerSave
            // 
            this.btnCustomerSave.Location = new System.Drawing.Point(44, 92);
            this.btnCustomerSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomerSave.Name = "btnCustomerSave";
            this.btnCustomerSave.Size = new System.Drawing.Size(64, 28);
            this.btnCustomerSave.TabIndex = 22;
            this.btnCustomerSave.Text = "Save";
            this.btnCustomerSave.UseVisualStyleBackColor = true;
            this.btnCustomerSave.Click += new System.EventHandler(this.btnCustomerSave_Click);
            // 
            // btnCustomerClear
            // 
            this.btnCustomerClear.Location = new System.Drawing.Point(182, 92);
            this.btnCustomerClear.Margin = new System.Windows.Forms.Padding(4);
            this.btnCustomerClear.Name = "btnCustomerClear";
            this.btnCustomerClear.Size = new System.Drawing.Size(69, 28);
            this.btnCustomerClear.TabIndex = 28;
            this.btnCustomerClear.Text = "Clear";
            this.btnCustomerClear.UseVisualStyleBackColor = true;
            this.btnCustomerClear.Click += new System.EventHandler(this.btnCustomerClear_Click);
            // 
            // txtCustomerEmail
            // 
            this.txtCustomerEmail.Location = new System.Drawing.Point(70, 63);
            this.txtCustomerEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerEmail.Name = "txtCustomerEmail";
            this.txtCustomerEmail.Size = new System.Drawing.Size(197, 21);
            this.txtCustomerEmail.TabIndex = 18;
            // 
            // txtCustomerFullName
            // 
            this.txtCustomerFullName.Location = new System.Drawing.Point(90, 30);
            this.txtCustomerFullName.Margin = new System.Windows.Forms.Padding(4);
            this.txtCustomerFullName.Name = "txtCustomerFullName";
            this.txtCustomerFullName.Size = new System.Drawing.Size(177, 21);
            this.txtCustomerFullName.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 66);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Email";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Full Name";
            // 
            // dgvCustomers
            // 
            this.dgvCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.fullName,
            this.email});
            this.dgvCustomers.Location = new System.Drawing.Point(6, 55);
            this.dgvCustomers.Margin = new System.Windows.Forms.Padding(5);
            this.dgvCustomers.Name = "dgvCustomers";
            this.dgvCustomers.ReadOnly = true;
            this.dgvCustomers.RowHeadersWidth = 51;
            this.dgvCustomers.RowTemplate.Height = 24;
            this.dgvCustomers.Size = new System.Drawing.Size(507, 393);
            this.dgvCustomers.TabIndex = 33;
            this.dgvCustomers.SelectionChanged += new System.EventHandler(this.dgvCustomers_SelectionChanged);
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
            // fullName
            // 
            this.fullName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullName.DataPropertyName = "full_name";
            this.fullName.FillWeight = 73.85786F;
            this.fullName.HeaderText = "Full Name";
            this.fullName.MinimumWidth = 6;
            this.fullName.Name = "fullName";
            this.fullName.ReadOnly = true;
            // 
            // email
            // 
            this.email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.email.DataPropertyName = "email";
            this.email.FillWeight = 152.2843F;
            this.email.HeaderText = "Email";
            this.email.MinimumWidth = 6;
            this.email.Name = "email";
            this.email.ReadOnly = true;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 452);
            this.Controls.Add(this.btnShowAllCustomers);
            this.Controls.Add(this.btnSearchCustomer);
            this.Controls.Add(this.txtSearchCustomer);
            this.Controls.Add(this.grpEditCustomer);
            this.Controls.Add(this.dgvCustomers);
            this.Font = new System.Drawing.Font("Cascadia Code", 9F);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CustomerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.grpEditCustomer.ResumeLayout(false);
            this.grpEditCustomer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnShowAllCustomers;
        private System.Windows.Forms.Button btnSearchCustomer;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.GroupBox grpEditCustomer;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Label lblSelectedCustomer;
        private System.Windows.Forms.Button btnCustomerSave;
        private System.Windows.Forms.Button btnCustomerClear;
        private System.Windows.Forms.TextBox txtCustomerEmail;
        private System.Windows.Forms.TextBox txtCustomerFullName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvCustomers;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
    }
}