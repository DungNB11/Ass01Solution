using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyStoreWinApp
{
    public partial class frmMemberDetail : Form
    {
        public frmMemberDetail()
        {
            InitializeComponent();
        }
        public Member member { get; set; }
        public bool InsertOrUpdate { get; set; }
        public IMemberRepository MemberRepository { get; set; }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmMemberDetail_Load(object sender, EventArgs e)
        {
            txtMemId.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true)
            {
                txtMemId.Text = member.MemberID.ToString();
                txtMemName.Text = member.MemberName.ToString();
                txtEmail.Text = member.Email.ToString();
                txtPassword.Text = member.Password.ToString();
                txtCity.Text = member.City.ToString();
                txtCountry.Text = member.Country.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var mem = new Member
                {
                    MemberID = int.Parse(txtMemId.Text),
                    MemberName = txtMemName.Text,
                    Email = txtEmail.Text,
                    Password = txtPassword.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,

                };
                if(InsertOrUpdate == false)
                {
                    MemberRepository.InsertMember(mem);
                }
                else
                {
                    MemberRepository.UpdateMember(mem);
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate==false?"Insert a new member!":"Update a member!");
            }
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e) => Close();
    }
}
