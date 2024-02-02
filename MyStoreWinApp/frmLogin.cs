using BusinessObject;
using DataAccess.Repository;
using DataAccess;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmLogin : Form
    {
        IMemberRepository repo = new MemberRepository();
        public frmLogin()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            var builder = new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);

            IConfiguration config = builder.Build();

            // Đọc email, password admin
            string adminEmail = config["AdminAccount:Email"];
            string adminPassword = config["AdminAccount:Password"];


            string email = txtEmail.Text;
            string password = txtPassword.Text;
            if (email == adminEmail && password == adminPassword)
            {
                // Admin login 
                frmMemberManagement f = new frmMemberManagement();
                f.Show();
                this.Hide();
            }
            else if (MemberDAO.Instance.CheckLogin(email, password))
            {
                frmMemberDetail f = new frmMemberDetail()
                {
                    MemberRepository = repo,
                    Text = "Update Member.",
                    InsertOrUpdate = true
                };
                f.member = MemberDAO.Instance.GetMemberByEmail(email);
                f.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu!");

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
