namespace MyStoreWinApp
{
    partial class frmMemberDetail
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
            lbMemId = new Label();
            txtMemId = new TextBox();
            txtMemName = new TextBox();
            lbMemName = new Label();
            txtCity = new TextBox();
            lbCity = new Label();
            txtEmail = new TextBox();
            lbEmail = new Label();
            txtPassword = new TextBox();
            lbPassword = new Label();
            txtCountry = new TextBox();
            lbCountry = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // lbMemId
            // 
            lbMemId.AutoSize = true;
            lbMemId.Location = new Point(27, 37);
            lbMemId.Name = "lbMemId";
            lbMemId.Size = new Size(66, 15);
            lbMemId.TabIndex = 0;
            lbMemId.Text = "Member ID";
            // 
            // txtMemId
            // 
            txtMemId.Location = new Point(120, 37);
            txtMemId.Name = "txtMemId";
            txtMemId.Size = new Size(143, 23);
            txtMemId.TabIndex = 1;
            // 
            // txtMemName
            // 
            txtMemName.Location = new Point(120, 85);
            txtMemName.Name = "txtMemName";
            txtMemName.Size = new Size(143, 23);
            txtMemName.TabIndex = 3;
            // 
            // lbMemName
            // 
            lbMemName.AutoSize = true;
            lbMemName.Location = new Point(27, 88);
            lbMemName.Name = "lbMemName";
            lbMemName.Size = new Size(87, 15);
            lbMemName.TabIndex = 2;
            lbMemName.Text = "Member Name";
            lbMemName.Click += label2_Click;
            // 
            // txtCity
            // 
            txtCity.Location = new Point(120, 135);
            txtCity.Name = "txtCity";
            txtCity.Size = new Size(143, 23);
            txtCity.TabIndex = 5;
            // 
            // lbCity
            // 
            lbCity.AutoSize = true;
            lbCity.Location = new Point(27, 138);
            lbCity.Name = "lbCity";
            lbCity.Size = new Size(28, 15);
            lbCity.TabIndex = 4;
            lbCity.Text = "City";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(380, 34);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(143, 23);
            txtEmail.TabIndex = 7;
            // 
            // lbEmail
            // 
            lbEmail.AutoSize = true;
            lbEmail.Location = new Point(317, 37);
            lbEmail.Name = "lbEmail";
            lbEmail.Size = new Size(36, 15);
            lbEmail.TabIndex = 6;
            lbEmail.Text = "Email";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(380, 85);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(143, 23);
            txtPassword.TabIndex = 9;
            // 
            // lbPassword
            // 
            lbPassword.AutoSize = true;
            lbPassword.Location = new Point(317, 88);
            lbPassword.Name = "lbPassword";
            lbPassword.Size = new Size(57, 15);
            lbPassword.TabIndex = 8;
            lbPassword.Text = "Password";
            // 
            // txtCountry
            // 
            txtCountry.Location = new Point(380, 135);
            txtCountry.Name = "txtCountry";
            txtCountry.Size = new Size(143, 23);
            txtCountry.TabIndex = 11;
            // 
            // lbCountry
            // 
            lbCountry.AutoSize = true;
            lbCountry.Location = new Point(317, 138);
            lbCountry.Name = "lbCountry";
            lbCountry.Size = new Size(50, 15);
            lbCountry.TabIndex = 10;
            lbCountry.Text = "Country";
            // 
            // btnSave
            // 
            btnSave.DialogResult = DialogResult.OK;
            btnSave.Location = new Point(150, 194);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "&Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.DialogResult = DialogResult.Cancel;
            btnCancel.Location = new Point(344, 194);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 13;
            btnCancel.Text = "&Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // frmMemberDetail
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(561, 254);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtCountry);
            Controls.Add(lbCountry);
            Controls.Add(txtPassword);
            Controls.Add(lbPassword);
            Controls.Add(txtEmail);
            Controls.Add(lbEmail);
            Controls.Add(txtCity);
            Controls.Add(lbCity);
            Controls.Add(txtMemName);
            Controls.Add(lbMemName);
            Controls.Add(txtMemId);
            Controls.Add(lbMemId);
            Name = "frmMemberDetail";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Member Detail";
            Load += frmMemberDetail_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbMemId;
        private TextBox txtMemId;
        private TextBox txtMemName;
        private Label lbMemName;
        private TextBox txtCity;
        private Label lbCity;
        private TextBox txtEmail;
        private Label lbEmail;
        private TextBox txtPassword;
        private Label lbPassword;
        private TextBox txtCountry;
        private Label lbCountry;
        private Button btnSave;
        private Button btnCancel;
    }
}