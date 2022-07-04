
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using System.Windows.Forms;
using MemberManagement.DataAccess.Repository;
using MemberManagement.Models;

namespace SalesWinApp
{
    public partial class frmMembers : Form
    {
        IMemberRepository memberRepository = new MemberRepository();
        BindingSource source;
        internal Member LoginAccount { get; set; }
        List<Member> listMember = new MemberRepository().GetList();
        public frmMembers()
        {
            InitializeComponent();
        }

        private void frmMembers_Load(object sender, EventArgs e)
        {
            txtPassword.Hide();
            var parent = (MdiParent as frmMain);
            LoginAccount = parent.LoginAccount;
            var adminDefaultSettings = Program.Configuration.GetSection("AdminAccount").Get<Member>();
            string adminEmail = adminDefaultSettings.Email;
            if (LoginAccount.Email != adminEmail)
            {
                btnAdd.Enabled = false;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnFilter.Enabled = false;
            }
            else
            {
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                btnFilter.Enabled = false;
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var adminDefaultSettings = Program.Configuration.GetSection("AdminAccount").Get<Member>();
            string adminEmail = adminDefaultSettings.Email;
            if (LoginAccount.Email != adminEmail)
            {
                LoadMemberLogin();
            }
            else
            {
                LoadMemberList();
            }
        }

        private void ClearText()
        {
            txtMemberID.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtCompanyName.Text = string.Empty;
            txtCity.Text = string.Empty;
            txtCountry.Text = string.Empty;
            txtPassword.Text = string.Empty;
            //txtPassword.Hide();
        }

        public Member GetMemberObject()
        {
            Member member = null;
            try
            {
                //txtPassword.Hide();
                member = new Member
                {
                    MemberId = int.Parse(txtMemberID.Text),
                    Email = txtEmail.Text,
                    CompanyName = txtCompanyName.Text,
                    City = txtCity.Text,
                    Country = txtCountry.Text,
                    Password = txtPassword.Text
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get member");
            }
            return member;
        }

        public void LoadMemberList()
        {
            var members = memberRepository.GetList();
            try
            {
                //txtPassword.Hide();
                source = new BindingSource();
                source.DataSource = members;
                txtMemberID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgvMember.DataSource = null;
                dgvMember.DataSource = source;
                if (members.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    btnFilter.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member list");
            }
        }

        public void LoadMemberLogin()
        {
            try
            {
                //txtPassword.Hide();
                source = new BindingSource();
                source.DataSource = LoginAccount;
                txtMemberID.DataBindings.Clear();
                txtEmail.DataBindings.Clear();
                txtCompanyName.DataBindings.Clear();
                txtCity.DataBindings.Clear();
                txtCountry.DataBindings.Clear();
                txtPassword.DataBindings.Clear();

                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtEmail.DataBindings.Add("Text", source, "Email");
                txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                txtCity.DataBindings.Add("Text", source, "City");
                txtCountry.DataBindings.Add("Text", source, "Country");
                txtPassword.DataBindings.Add("Text", source, "Password");

                dgvMember.DataSource = null;
                dgvMember.DataSource = source;
                btnUpdate.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member login");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmMemberDetails f = new frmMemberDetails
            {
                Text = "Add Member",
                InsertOrUpdate = false,
                MemberRepository = memberRepository
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadMemberList();
                source.Position = source.Count - 1;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var adminDefaultSettings = Program.Configuration.GetSection("AdminAccount").Get<Member>();
            string adminEmail = adminDefaultSettings.Email;
            if (LoginAccount.Email == adminEmail)
            {
                if (btnDelete.Enabled == true)
                {
                    frmMemberDetails f = new frmMemberDetails
                    {
                        Text = "Update Information",
                        InsertOrUpdate = true,
                        memberInfo = GetMemberObject(),
                        MemberRepository = memberRepository
                    };
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        LoadMemberList();
                        source.Position = source.Count - 1;
                    }
                }
                else
                {
                    MessageBox.Show("Empty list member");
                }
            }
            else
            {
                frmMemberDetails f = new frmMemberDetails
                {
                    Text = "Update Information",
                    InsertOrUpdate = true,
                    memberInfo = GetMemberObject(),
                    MemberRepository = memberRepository
                };
                if (f.ShowDialog() == DialogResult.OK)
                {
                    LoginAccount = memberRepository.GetMemberById(LoginAccount.MemberId);
                    LoadMemberLogin();
                    source.Position = source.Count - 1;
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var member = GetMemberObject();
                if (MessageBox.Show("Do you want to delete?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    memberRepository.DeleteMember(member.MemberId);
                    LoadMemberList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Employee");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            string filterCity = txtCity.Text;
            string filterCountry = txtCountry.Text;
            if (!string.IsNullOrWhiteSpace(filterCity) && !string.IsNullOrWhiteSpace(filterCountry))
            {
                LoadMemberList();
                List<Member> filter = new List<Member>();
                for (int i = 0; i < dgvMember.Rows.Count - 1; i++)
                {
                    if (dgvMember.Rows[i].Cells[3].Value.ToString().ToLower().Equals(filterCity.ToLower()) && dgvMember.Rows[i].Cells[4].Value.ToString().ToLower().Equals(filterCountry.ToLower()))
                    {
                        filter.Add(listMember[i]);
                    }

                }
                if (filter.Count > 0)
                {
                    source = new BindingSource();
                    source.DataSource = filter;
                    txtMemberID.DataBindings.Clear();
                    txtEmail.DataBindings.Clear();
                    txtCompanyName.DataBindings.Clear();
                    txtCity.DataBindings.Clear();
                    txtCountry.DataBindings.Clear();
                    txtPassword.DataBindings.Clear();

                    txtMemberID.DataBindings.Add("Text", source, "MemberID");
                    txtEmail.DataBindings.Add("Text", source, "Email");
                    txtCompanyName.DataBindings.Add("Text", source, "CompanyName");
                    txtCity.DataBindings.Add("Text", source, "City");
                    txtCountry.DataBindings.Add("Text", source, "Country");
                    txtPassword.DataBindings.Add("Text", source, "Password");

                    dgvMember.DataSource = null;
                    dgvMember.DataSource = filter;
                }
                else
                {
                    dgvMember.DataSource = null;
                    dgvMember.DataSource = source;
                }
            }
            else
            {
                LoadMemberList();
            }
        }
    }
}
