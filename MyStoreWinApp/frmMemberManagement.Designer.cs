namespace MyStoreWinApp
{
    partial class frmMemberManagement
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
            dgvMember = new DataGridView();
            lbSearch = new Label();
            txtSearch = new TextBox();
            txtMemId = new TextBox();
            lbMemId = new Label();
            txtMemName = new TextBox();
            lbMemName = new Label();
            txtEmail = new TextBox();
            lbEmail = new Label();
            txtCity = new TextBox();
            lbCity = new Label();
            txtCountry = new TextBox();
            lbCountry = new Label();
            lbFilter = new Label();
            btnSort = new Button();
            btnAdd = new Button();
            btnUpdate = new Button();
            btnDelete = new Button();
            cbSearch = new ComboBox();
            cbFilterCountry = new ComboBox();
            cbFilterCity = new ComboBox();
            btnClose = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMember).BeginInit();
            SuspendLayout();
            // 
            // dgvMember
            // 
            dgvMember.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMember.Location = new Point(12, 282);
            dgvMember.Name = "dgvMember";
            dgvMember.RowHeadersWidth = 51;
            dgvMember.RowTemplate.Height = 25;
            dgvMember.Size = new Size(693, 217);
            dgvMember.TabIndex = 0;
            dgvMember.CellClick += dgvMember_CellClick;
            // 
            // lbSearch
            // 
            lbSearch.AutoSize = true;
            lbSearch.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbSearch.Location = new Point(41, 21);
            lbSearch.Name = "lbSearch";
            lbSearch.Size = new Size(63, 19);
            lbSearch.TabIndex = 1;
            lbSearch.Text = "Search";
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(135, 21);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(300, 23);
            txtSearch.TabIndex = 2;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtMemId
            // 
            txtMemId.Location = new Point(143, 100);
            txtMemId.Name = "txtMemId";
            txtMemId.ReadOnly = true;
            txtMemId.Size = new Size(158, 23);
            txtMemId.TabIndex = 4;
            // 
            // lbMemId
            // 
            lbMemId.AutoSize = true;
            lbMemId.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbMemId.Location = new Point(39, 102);
            lbMemId.Name = "lbMemId";
            lbMemId.Size = new Size(67, 15);
            lbMemId.TabIndex = 3;
            lbMemId.Text = "Member ID";
            // 
            // txtMemName
            // 
            txtMemName.Location = new Point(143, 146);
            txtMemName.Name = "txtMemName";
            txtMemName.ReadOnly = true;
            txtMemName.Size = new Size(158, 23);
            txtMemName.TabIndex = 6;
            txtMemName.TextChanged += textBox3_TextChanged;
            // 
            // lbMemName
            // 
            lbMemName.AutoSize = true;
            lbMemName.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbMemName.Location = new Point(39, 148);
            lbMemName.Name = "lbMemName";
            lbMemName.Size = new Size(89, 15);
            lbMemName.TabIndex = 5;
            lbMemName.Text = "Member Name";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(143, 185);
            txtEmail.Name = "txtEmail";
            txtEmail.ReadOnly = true;
            txtEmail.Size = new Size(158, 23);
            txtEmail.TabIndex = 8;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbEmail.Location = new Point(39, 188);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(39, 15);
            lbEmail.TabIndex = 7;
            lbEmail.Text = "Email";
            // 
            // txtCity
            // 
            txtCity.Location = new Point(464, 102);
            txtCity.Name = "txtCity";
            txtCity.ReadOnly = true;
            txtCity.Size = new Size(205, 23);
            txtCity.TabIndex = 10;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbCity.Location = new Point(388, 105);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(27, 15);
            lbCity.TabIndex = 9;
            lbCity.Text = "City";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(464, 142);
            txtCountry.Name = "txtCountry";
            txtCountry.ReadOnly = true;
            txtCountry.Size = new Size(205, 23);
            txtCountry.TabIndex = 12;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point);
            lbCountry.Location = new Point(386, 145);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(49, 15);
            lbCountry.TabIndex = 11;
            lbCountry.Text = "Country";
            // 
            // lbFilter
            // 
            lbFilter.AutoSize = true;
            lbFilter.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lbFilter.Location = new Point(388, 57);
            lbFilter.Name = "lbFilter";
            lbFilter.Size = new Size(47, 19);
            lbFilter.TabIndex = 13;
            lbFilter.Text = "Filter";
            // 
            // btnSort
            // 
            btnSort.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnSort.Location = new Point(584, 20);
            btnSort.Name = "btnSort";
            btnSort.Size = new Size(85, 23);
            btnSort.TabIndex = 14;
            btnSort.Text = "Sort";
            btnSort.UseVisualStyleBackColor = true;
            btnSort.Click += btnSort_Click;
            // 
            // btnAdd
            // 
            btnAdd.FlatStyle = FlatStyle.Flat;
            btnAdd.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnAdd.Location = new Point(125, 231);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 32);
            btnAdd.TabIndex = 15;
            btnAdd.Text = "New";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnUpdate.Location = new Point(322, 231);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(75, 32);
            btnUpdate.TabIndex = 16;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnDelete
            // 
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.Location = new Point(519, 231);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 32);
            btnDelete.TabIndex = 17;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // cbSearch
            // 
            cbSearch.FormattingEnabled = true;
            cbSearch.Items.AddRange(new object[] { "Search", "Member ID", "Member Name" });
            cbSearch.Location = new Point(464, 21);
            cbSearch.Name = "cbSearch";
            cbSearch.Size = new Size(100, 23);
            cbSearch.TabIndex = 18;
            cbSearch.SelectedIndexChanged += cbSearch_SelectedIndexChanged;
            // 
            // cbFilterCountry
            // 
            cbFilterCountry.FormattingEnabled = true;
            cbFilterCountry.Location = new Point(584, 57);
            cbFilterCountry.Name = "cbFilterCountry";
            cbFilterCountry.Size = new Size(85, 23);
            cbFilterCountry.TabIndex = 19;
            cbFilterCountry.SelectedIndexChanged += cbFilterCountry_SelectedIndexChanged;
            // 
            // cbFilterCity
            // 
            cbFilterCity.FormattingEnabled = true;
            cbFilterCity.Location = new Point(464, 57);
            cbFilterCity.Name = "cbFilterCity";
            cbFilterCity.Size = new Size(100, 23);
            cbFilterCity.TabIndex = 20;
            cbFilterCity.SelectedIndexChanged += cbFilterCity_SelectedIndexChanged;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.Location = new Point(322, 515);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 32);
            btnClose.TabIndex = 21;
            btnClose.Text = "Close";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // frmMemberManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(717, 559);
            Controls.Add(btnClose);
            Controls.Add(cbFilterCity);
            Controls.Add(cbFilterCountry);
            Controls.Add(cbSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnUpdate);
            Controls.Add(btnAdd);
            Controls.Add(btnSort);
            Controls.Add(lbFilter);
            Controls.Add(txtCountry);
            Controls.Add(lbCountry);
            Controls.Add(txtCity);
            Controls.Add(lbCity);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtMemName);
            Controls.Add(lbMemName);
            Controls.Add(txtMemId);
            Controls.Add(lbMemId);
            Controls.Add(txtSearch);
            Controls.Add(lbSearch);
            Controls.Add(dgvMember);
            Name = "frmMemberManagement";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Mangement";
            Load += frmMemberManagement_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMember).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgvMember;
        private Label lbSearch;
        private TextBox txtSearch;
        private TextBox txtMemId;
        private Label lbMemId;
        private TextBox txtMemName;
        private Label lbMemName;
        private TextBox txtEmail;
        private Label lbEmail;
        private TextBox txtCity;
        private Label lbCity;
        private TextBox txtCountry;
        private Label lbCountry;
        private Label lbFilter;
        private Button btnSort;
        private Button btnAdd;
        private Button btnUpdate;
        private Button btnDelete;
        private ComboBox cbSearch;
        private ComboBox cbFilterCountry;
        private ComboBox cbFilterCity;
        private Button btnClose;
    }
}