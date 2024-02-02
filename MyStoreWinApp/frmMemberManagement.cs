using BusinessObject;
using DataAccess;
using DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MyStoreWinApp
{
    public partial class frmMemberManagement : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        public frmMemberManagement()
        {
            InitializeComponent();
        }
        private void loadData()
        {
            var members = memberRepository.GetMembers();
            try
            {
                source = new BindingSource();
                source.DataSource = members;

                txtMemId.DataBindings.Clear();
                txtMemName.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();

                txtMemId.DataBindings.Add("Text", source, "MemberID");
                txtMemName.DataBindings.Add("Text", source, "MemberName");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");

                dgvMember.DataSource = null;
                dgvMember.DataSource = source;
                dgvMember.Columns["Password"].Visible = false;
                if (members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List.");
            }
        }

        private void search()
        {

            var members = memberRepository.GetMembers();
            string country, city, filterKey, keyword;
            bool id = false, name = false;
            if (cbFilterCity.Text == "City" || string.IsNullOrEmpty(cbFilterCity.Text))
            {
                city = null;
            }
            else
            {
                city = cbFilterCity.Text;
            }

            if (cbFilterCountry.Text == "Country" || string.IsNullOrEmpty(cbFilterCountry.Text))
            {
                country = null;
            }
            else
            {
                country = cbFilterCountry.Text;
            }

            if (cbSearch.Text == "Search" || string.IsNullOrEmpty(cbSearch.Text))
            {
                filterKey = null;
                id = true;
                name = true;
            }
            else
            {
                filterKey = cbSearch.Text;
                if (filterKey == "Member ID")
                {
                    id = false;
                    name = true;
                }
                else if (filterKey == "Member Name")
                {
                    name = false;
                    id = true;
                }
            }

            keyword = txtSearch.Text.Trim();


            members = members.Where(member => (string.IsNullOrEmpty(city) || member.City == city) &&
                                              (string.IsNullOrEmpty(country) || member.Country == country) &&
                                              (member.MemberName.ToLower().Contains(keyword.ToLower()) || name) &&
                                              (member.MemberID.ToString().Contains(keyword) || id));
            // &&
            //(id || member.MemberID.ToString().Contains(keyword) || member.MemberID.ToString() == keyword) &&
            //                                  (name || member.MemberName.ToString().Contains(keyword))
            if (members.Count() > 1)
            {
                if (btnSort.Text == "ASC")
                {
                    members = members.OrderBy(m => m.MemberName);
                }
                else if (btnSort.Text == "DESC")
                {
                    members = members.OrderByDescending(m => m.MemberName);
                }
                else if (btnSort.Text == "Sort")
                {
                    members = members.OrderBy(m => m.MemberID);
                }
            }
            try
            {
                if (members.Count() > 0)
                {
                    source = new BindingSource();
                    source.DataSource = members;

                    txtMemId.DataBindings.Clear();
                    txtMemName.DataBindings.Clear();
                    txtEmail.DataBindings.Clear();
                    txtCity.DataBindings.Clear();
                    txtCountry.DataBindings.Clear();

                    txtMemId.DataBindings.Add("Text", source, "MemberID");
                    txtMemName.DataBindings.Add("Text", source, "MemberName");
                    txtEmail.DataBindings.Add("Text", source, "Email");
                    txtCity.DataBindings.Add("Text", source, "City");
                    txtCountry.DataBindings.Add("Text", source, "Country");

                    dgvMember.DataSource = null;
                    dgvMember.DataSource = source;
                    dgvMember.Columns["Password"].Visible = false;
                }
                if (members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load Member List.");
            }
        }

        

        private void ClearText()
        {
            txtMemId.Text = string.Empty;
            txtMemName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
        }

        private void frmMemberManagement_Load(object sender, EventArgs e)
        {
            loadData();
            loadCity();
            loadCountry();
            cbSearch.SelectedIndex = 0;
        }

        private void loadCity()
        {
            var members = memberRepository.GetMembers();
            var cities = members.Select(x => x.City).Distinct().ToList();
            cbFilterCity.DisplayMember = "City";
            cbFilterCity.ValueMember = "City";
            cities.Insert(0, "City");
            cbFilterCity.DataSource = cities;
            cbFilterCity.SelectedIndex = 0;
        }
        private void loadCountry()
        {
            var members = memberRepository.GetMembers();
            var countries = members.Select(x => x.Country).Distinct().ToList();
            cbFilterCountry.DisplayMember = "Country";
            cbFilterCountry.ValueMember = "Country";
            countries.Insert(0, "Country");
            cbFilterCountry.DataSource = countries;
            cbFilterCountry.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbFilterCountry_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var Member = memberRepository.GetMemberByID(int.Parse(txtMemId.Text));
                memberRepository.DeleteMember(Member.MemberID);
                loadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete a Member.");
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dgvMember_CellClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail
            {
                Text = "Add new",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                loadData();
                source.Position = source.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            frmMemberDetail frmMemberDetail = new frmMemberDetail()
            {
                Text = "Update Member",
                InsertOrUpdate = true,
                MemberRepository = memberRepository,
                member = memberRepository.GetMemberByID(int.Parse(txtMemId.Text))
            };
            if (frmMemberDetail.ShowDialog() == DialogResult.OK)
            {
                loadData();
                source.Position = source.Count - 1;
            }
        }


        private void btnSort_Click(object sender, EventArgs e)
        {

            if (btnSort.Text == "Sort")
            {
                btnSort.Text = "ASC";
            }
            else if (btnSort.Text == "ASC")
            {
                btnSort.Text = "DESC";
            }
            else if (btnSort.Text == "DESC")
            {
                btnSort.Text = "Sort";
            }
            search();
        }

        private void cbSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void cbFilterCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            search();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            search();
        }
    }

}
