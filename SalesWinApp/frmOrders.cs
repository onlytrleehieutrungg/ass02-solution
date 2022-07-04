
using MemberManagement.DataAccess.Repository;
using MemberManagement.Models;
using Microsoft.Extensions.Configuration;
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
    public partial class frmOrders : Form
    {

        IOrderRepository orderRepository = new OrderRepository();
        BindingSource source;
        IEnumerable<Order> listOrder = new OrderRepository().GetOrders();
        internal Member LoginAccount { get; set; }
        public frmOrders()
        {
            InitializeComponent();
        }

        private void frmOrders_Load(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            txtOrderID.Hide();
            txtMemberID.Hide();
            txtOrderDate.Hide();
            txtRequiredDate.Hide();
            txtShippedDate.Hide();
            txtFreight.Hide();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            var parent = (MdiParent as frmMain);
            LoginAccount = parent.LoginAccount;
            var adminDefaultSettings = Program.Configuration.GetSection("AdminAccount").Get<Member>();
            string adminEmail = adminDefaultSettings.Email;
            if (LoginAccount.Email == adminEmail)
            {
                LoadOrderList();
            }
            else
            {
                LoadOrderListByMember();
            }
        }

        private void ClearText()
        {
            txtOrderID.Text = string.Empty;
            txtMemberID.Text = string.Empty;
            txtOrderDate.Text = string.Empty;
            txtRequiredDate.Text = string.Empty;
            txtShippedDate.Text = string.Empty;
            txtFreight.Text = string.Empty;
            //txtPassword.Hide();
        }

        public Order GetOrderObject()
        {
            Order order = null;
            try
            {
                //txtPassword.Hide();
                order = new Order
                {
                    OrderId = int.Parse(txtOrderID.Text),
                    MemberId = int.Parse(txtMemberID.Text),
                    OrderDate = DateTime.Parse(txtOrderDate.Text),
                    RequiredDate = DateTime.Parse(txtRequiredDate.Text),
                    ShippedDate = DateTime.Parse(txtShippedDate.Text),
                    Freight = decimal.Parse(txtFreight.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get order");
            }
            return order;
        }

        public void LoadOrderList()
        {
            var adminDefaultSettings = Program.Configuration.GetSection("AdminAccount").Get<Member>();
            string adminEmail = adminDefaultSettings.Email;
            var orders = orderRepository.GetOrders();
            try
            {
                //txtPassword.Hide();
                source = new BindingSource();
                source.DataSource = orders;
                txtOrderID.DataBindings.Clear();
                txtMemberID.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderID");
                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                txtFreight.DataBindings.Add("Text", source, "Freight");

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = source;
                if (orders.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else if (LoginAccount.Email == adminEmail)
                {
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load order list");
            }
        }

        public void LoadOrderListByMember()
        {
            //List<Order> orderByMember = orderRepository.GetOrder(LoginAccount.MemberId);
            try
            {
                //txtPassword.Hide();
                source = new BindingSource();
                source.DataSource = listOrder;
                txtOrderID.DataBindings.Clear();
                txtMemberID.DataBindings.Clear();
                txtOrderDate.DataBindings.Clear();
                txtRequiredDate.DataBindings.Clear();
                txtShippedDate.DataBindings.Clear();
                txtFreight.DataBindings.Clear();

                txtOrderID.DataBindings.Add("Text", source, "OrderID");
                txtMemberID.DataBindings.Add("Text", source, "MemberID");
                txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
                txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
                txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
                txtFreight.DataBindings.Add("Text", source, "Freight");

                dgvOrders.DataSource = null;
                dgvOrders.DataSource = source;
                //if(orderByMember.Count() == 0)
                //{
                //    ClearText();
                //    MessageBox.Show("You do not have any orders");
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load member login");
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
                    frmOrdersUpdate f = new frmOrdersUpdate
                    {
                        Text = "Update Information",
                        orderInfo = GetOrderObject(),
                        OrderRepository = orderRepository
                    };
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        LoadOrderList();
                        source.Position = source.Count - 1;
                    }
                }
                else
                {
                    MessageBox.Show("Empty list order");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var order = GetOrderObject();
                if (MessageBox.Show("Do you want to delete?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    orderRepository.DeleteOrder(order.OrderId);
                    LoadOrderList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Order");
            }
        }

        private void btnSearchDate_Click(object sender, EventArgs e)
        {
            //DateTime start = dtpStart.Value.Date;
            //DateTime end = dtpEnd.Value.Date;
            //var adminDefaultSettings = Program.Configuration.GetSection("AdminAccount").Get<Member>();
            //string adminEmail = adminDefaultSettings.Email;
            //if (LoginAccount.Email == adminEmail)
            //{
            //    LoadOrderList();
            //    List<OrderObject> searchOrder = new OrderRepository().GetOrderListByDate(start, end);
            //    listOrder = searchOrder;
            //    if (searchOrder.Count > 0)
            //    {
            //        source = new BindingSource();
            //        source.DataSource = searchOrder;
            //        txtOrderID.DataBindings.Clear();
            //        txtMemberID.DataBindings.Clear();
            //        txtOrderDate.DataBindings.Clear();
            //        txtRequiredDate.DataBindings.Clear();
            //        txtShippedDate.DataBindings.Clear();
            //        txtFreight.DataBindings.Clear();

            //        txtOrderID.DataBindings.Add("Text", source, "OrderID");
            //        txtMemberID.DataBindings.Add("Text", source, "MemberID");
            //        txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
            //        txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
            //        txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
            //        txtFreight.DataBindings.Add("Text", source, "Freight");

            //        dgvOrders.DataSource = null;
            //        dgvOrders.DataSource = searchOrder;
            //    }
            //    else
            //    {
            //        dgvOrders.DataSource = null;
            //        dgvOrders.DataSource = source;
            //    }
            //}
            //else if(LoginAccount.Email != adminEmail)
            //{
            //    LoadOrderList();
            //    List<OrderObject> searchOrder = new OrderRepository().GetOrderListByDateByID(LoginAccount.MemberID, start, end);
            //    listOrder = searchOrder;
            //    if (searchOrder.Count > 0)
            //    {
            //        source = new BindingSource();
            //        source.DataSource = searchOrder;
            //        txtOrderID.DataBindings.Clear();
            //        txtMemberID.DataBindings.Clear();
            //        txtOrderDate.DataBindings.Clear();
            //        txtRequiredDate.DataBindings.Clear();
            //        txtShippedDate.DataBindings.Clear();
            //        txtFreight.DataBindings.Clear();

            //        txtOrderID.DataBindings.Add("Text", source, "OrderID");
            //        txtMemberID.DataBindings.Add("Text", source, "MemberID");
            //        txtOrderDate.DataBindings.Add("Text", source, "OrderDate");
            //        txtRequiredDate.DataBindings.Add("Text", source, "RequiredDate");
            //        txtShippedDate.DataBindings.Add("Text", source, "ShippedDate");
            //        txtFreight.DataBindings.Add("Text", source, "Freight");

            //        dgvOrders.DataSource = null;
            //        dgvOrders.DataSource = searchOrder;
            //        if (searchOrder.Count() == 0)
            //        {
            //            ClearText();
            //            MessageBox.Show("You do not have any orders");
            //        }
            //    }
            //    else
            //    {
            //        LoadOrderListByMember();
            //    }
            //}
            //else
            //{
            //    LoadOrderList();
            //}
        }
    }
}
