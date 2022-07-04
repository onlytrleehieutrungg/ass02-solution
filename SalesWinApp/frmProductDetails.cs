
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
    public partial class frmProductDetails : Form
    {
        public IProductRepository ProductRepository { get; set; }
        public bool InsertOrUpdate { get; set; }
        public Product productInfo { get; set; }
        public frmProductDetails()
        {
            InitializeComponent();
        }

        private void frmProductDetails_Load(object sender, EventArgs e)
        {
            txtProductID.Enabled = !InsertOrUpdate;
            if (InsertOrUpdate == true)
            {
                txtProductID.Text = productInfo.ProductId.ToString();
                //txtCategory.Text = productInfo.Category;
                txtProductName.Text = productInfo.ProductName;
                txtWeight.Text = productInfo.Weight;
                txtUnitPrice.Text = productInfo.UnitPrice.ToString();
                txtUnitslnStock.Text = productInfo.UnitsInStock.ToString();
            }
        }

        public bool CheckData()
        {
            if (string.IsNullOrWhiteSpace(txtProductID.Text))
            {
                MessageBox.Show("Product ID is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductID.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                MessageBox.Show("Category is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCategory.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Product Name is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProductName.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtWeight.Text))
            {
                MessageBox.Show("Weight is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtWeight.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUnitPrice.Text))
            {
                MessageBox.Show("Unit Price is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitPrice.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(txtUnitslnStock.Text))
            {
                MessageBox.Show("Units Stock is blank", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUnitslnStock.Focus();
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
                    var product = new Product
                    {
                        ProductId = int.Parse(txtProductID.Text),
                        //Category = txtCategory.Text,
                        ProductName = txtProductName.Text,
                        Weight = txtWeight.Text,
                        UnitPrice = decimal.Parse(txtUnitPrice.Text),
                        UnitsInStock = int.Parse(txtUnitslnStock.Text)
                    };
                    if (InsertOrUpdate == false)
                    {
                        ProductRepository.AddProduct(product);
                    }
                    else
                    {
                        ProductRepository.UpdateProduct(product);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, InsertOrUpdate == false ? "Add new product" : "Update product");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
