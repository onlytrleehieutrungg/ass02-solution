
using MemberManagement.DataAccess.Repository;
using MemberManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesWinApp
{
    public partial class frmMemberDetails : Form
    {
        public IMemberRepository MemberRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Member memberInfo { get; set; }
        public frmMemberDetails()
        {
            InitializeComponent();
        }

        private void frmMemberDetails_Load(object sender, EventArgs e)
        {
            txtMemberID.Enabled = !InsertOrUpdate;
            if(InsertOrUpdate == true)
            {
                txtMemberID.Text = memberInfo.MemberId.ToString();
                txtEmail.Text = memberInfo.Email;
                txtCompanyName.Text = memberInfo.CompanyName;
                txtCity.Text = memberInfo.City;
                txtCountry.Text = memberInfo.Country;
                txtPassword.Text = memberInfo.Password;
            }
        }

        public bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(txtMemberID.Text))
            {
                MessageBox.Show("Member ID is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMemberID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("Email is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtEmail.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
            {
                MessageBox.Show("Company Name is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCompanyName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCity.Text))
            {
                MessageBox.Show("City is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCity.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCountry.Text))
            {
                MessageBox.Show("Country is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCountry.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Password is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckData())
                {
                    var member = new Member
                    {
                        MemberId = int.Parse(txtMemberID.Text),
                        Email = txtEmail.Text,
                        CompanyName = txtCompanyName.Text,
                        City = txtCity.Text,
                        Country = txtCountry.Text,
                        Password = txtPassword.Text
                    };
                    if (InsertOrUpdate == false)
                    {
                        MemberRepository.AddMember(member);
                    }
                    else
                    {
                        MemberRepository.UpdateMember(member);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new member" : "Update member");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
