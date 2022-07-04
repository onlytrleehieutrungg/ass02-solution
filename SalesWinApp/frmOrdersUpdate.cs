
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
    public partial class frmOrdersUpdate : Form
    {
        public IOrderRepository OrderRepository { get; set; }
        public Order orderInfo { get; set; }
        public frmOrdersUpdate()
        {
            InitializeComponent();
        }

        private void frmOrdersUpdate_Load(object sender, EventArgs e)
        {
            txtOrderID.Enabled = false;
            txtOrderID.Text = orderInfo.OrderId.ToString();
            txtMemberID.Text = orderInfo.MemberId.ToString();
            txtOrderDate.Text = orderInfo.OrderDate.ToString();
            txtRequiredDate.Text = orderInfo.RequiredDate.ToString();
            txtShippedDate.Text = orderInfo.ShippedDate.ToString();
            txtFreight.Text = orderInfo.Freight.ToString();
        }

        public bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(txtOrderID.Text))
            {
                MessageBox.Show("Order ID is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOrderID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtMemberID.Text))
            {
                MessageBox.Show("Member ID is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMemberID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtOrderDate.Text))
            {
                MessageBox.Show("Order Date Name is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOrderDate.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtRequiredDate.Text))
            {
                MessageBox.Show("Weight is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtRequiredDate.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtShippedDate.Text))
            {
                MessageBox.Show("Shipped Date is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtShippedDate.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtFreight.Text))
            {
                MessageBox.Show("Freight is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtFreight.Focus();
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
                    var order = new Order
                    {
                        OrderId = int.Parse(txtOrderID.Text),
                        MemberId = int.Parse(txtMemberID.Text),
                        OrderDate = DateTime.Parse(txtOrderDate.Text),
                        RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                        ShippedDate = DateTime.Parse(txtShippedDate.Text),
                        Freight = decimal.Parse(txtFreight.Text)
                    };
                    OrderRepository.UpdateOrder(order);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Update product");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
