
using MemberManagement.Models;
using Microsoft.Data.SqlClient;
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
    public partial class frmMain : Form
    {
        internal Member LoginAccount { get; set; }

        public frmMain()
        {
            InitializeComponent();
        }


        //SqlConnection connection = null;
        //string strConnection = "Server=(local); Database=FStore; uid=sa; pwd=123456";

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            if (checkShowed("frmLogin") == true)
            {
                frm.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMembers frm = new frmMembers();
            if (checkShowed("frmMembers") == true)
            {
                frm.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
            ActiveChildForm("frmMembers");
        }

        private void productsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmProduct frm = new frmProduct();
            if (checkShowed("frmProduct") == true)
            {
                frm.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
            ActiveChildForm("frmProduct");
        }

        private void ordersHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrders frm = new frmOrders();
            if (checkShowed("frmOrders") == true)
            {
                frm.Activate();
            }
            else
            {
                frm.MdiParent = this;
                frm.Show();
            }
            ActiveChildForm("frmOrders");
        }

        private bool checkShowed(string frmName)
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

        private void ActiveChildForm(string frmName)
        {
            foreach (Form frm in this.MdiChildren)
            {
                if (frm.Name == frmName)
                {
                    frm.Activate();
                    break;
                }
            }
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            membersToolStripMenuItem.Enabled = false;
            productsToolStripMenuItem.Enabled = false;
            ordersHistoryToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = false;
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowLoginMenu();
            foreach (Form frm in this.MdiChildren)
            {
                frm.Close();
            }
        }

        public void HideLoginMenu()
        {
            loginToolStripMenuItem.Enabled = false;
            logoutToolStripMenuItem.Enabled = true;
            membersToolStripMenuItem.Enabled = true;
            productsToolStripMenuItem.Enabled = true;
            ordersHistoryToolStripMenuItem.Enabled = true;
        }

        public void ShowLoginMenu()
        {
            loginToolStripMenuItem.Enabled = true;
            logoutToolStripMenuItem.Enabled = false;
            membersToolStripMenuItem.Enabled = false;
            productsToolStripMenuItem.Enabled = false;
            ordersHistoryToolStripMenuItem.Enabled = false;
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult d = MessageBox.Show("Exit program?", "Notification", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (d == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
}
