using System;
using System.Collections.Generic;
using System.ComponentModel;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using MemberManagement.Models;
using MemberManagement.DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmLogin : Form
    {
        List<Member> listMember = new MemberRepository().GetList();
        private Member loginMember;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var adminDefaultSettings = Program.Configuration.GetSection("AdminAccount").Get<Member>();
            string adminEmail = adminDefaultSettings.Email;
            string adminPassword = adminDefaultSettings.Password;

            string Email = txtEmail.Text;
            string Password = txtPassword.Text;

            if (checkLogin(Email, Password))
            {
                var main = (MdiParent as frmMain);
                main.LoginAccount = loginMember;
                main.HideLoginMenu();
                Close();
            }
            else if (Email == adminEmail && Password == adminPassword)
            {
                loginMember = adminDefaultSettings;
                var main = (MdiParent as frmMain);
                main.LoginAccount = loginMember;
                main.HideLoginMenu();
                Close();
            }
            else
            {
                MessageBox.Show("Wrong Email or Password");
            }
        }

        bool checkLogin(string Email, string Password)
        {
            for (int i = 0; i < listMember.Count; i++)
            {
                if (Email == listMember[i].Email && Password == listMember[i].Password)
                {
                    loginMember = listMember[i];
                    return true;
                }
            }
            return false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        public bool checkShowed(string frmName)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name.Equals(frmName))
                {
                    return true;
                }
            }
            return false;
        }

        //public void Load()
        //{
        //    var memberList = memberRepository.GetMembers();
        //}
    }
}
