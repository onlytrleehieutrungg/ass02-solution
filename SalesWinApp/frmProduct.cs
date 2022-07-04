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
using MemberManagement.Models;
using MemberManagement.DataAccess.Repository;

namespace SalesWinApp
{
    public partial class frmProduct : Form
    {
        internal Member LoginAccount { get; set; }
        IProductRepository productRepository = new ProductRepository();
        BindingSource source;
        IEnumerable<Product> listProduct = new ProductRepository().GetProducts();
        public frmProduct()
        {
            InitializeComponent();
        }

        private void frmProduct_Load(object sender, EventArgs e)
        {
            txtCategory.Hide();
            txtWeight.Hide();
            txtUnitPrice.Hide();
            txtUnitslnStock.Hide();
            var parent = (MdiParent as frmMain);
            LoginAccount = parent.LoginAccount;
            var adminDefaultSettings = Program.Configuration.GetSection("AdminAccount").Get<Member>();
            string adminEmail = adminDefaultSettings.Email;
            if (LoginAccount.Email != adminEmail)
            {
                btnAddProduct.Enabled = false;
                btnCreateOrder.Enabled = false;
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
            LoadProductList();
        }

        private void ClearText()
        {
            txtProductID.Text = string.Empty;
            txtCategory.Text = string.Empty;
            txtProductName.Text = string.Empty;
            txtWeight.Text = string.Empty;
            txtUnitPrice.Text = string.Empty;
            txtUnitslnStock.Text = string.Empty;
            //txtPassword.Hide();
        }

        public Product GetProductObject()
        {
            Product product = null;
            try
            {
                //txtPassword.Hide();
                product = new Product
                {
                    ProductId = int.Parse(txtProductID.Text),
                    //Category = txtCategory.Text,
                    ProductName = txtProductName.Text,
                    Weight = txtWeight.Text,
                    UnitPrice = decimal.Parse(txtUnitPrice.Text),
                    //UnitslnStock = int.Parse(txtUnitslnStock.Text)
                };
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Get product");
            }
            return product;
        }

        public void LoadProductList()
        {
            var adminDefaultSettings = Program.Configuration.GetSection("AdminAccount").Get<Member>();
            string adminEmail = adminDefaultSettings.Email;
            var products = productRepository.GetProducts();
            try
            {
                //txtPassword.Hide();
                source = new BindingSource();
                source.DataSource = products;
                txtProductID.DataBindings.Clear();
                txtCategory.DataBindings.Clear();
                txtProductName.DataBindings.Clear();
                txtWeight.DataBindings.Clear();
                txtUnitPrice.DataBindings.Clear();
                txtUnitslnStock.DataBindings.Clear();

                txtProductID.DataBindings.Add("Text", source, "ProductID");
                txtCategory.DataBindings.Add("Text", source, "Category");
                txtProductName.DataBindings.Add("Text", source, "ProductName");
                txtWeight.DataBindings.Add("Text", source, "Weight");
                txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
                txtUnitslnStock.DataBindings.Add("Text", source, "UnitslnStock");

                dgvProduct.DataSource = null;
                dgvProduct.DataSource = source;
                if (products.Count() == 0)
                {
                    ClearText();
                    btnDelete.Enabled = false;
                }
                else if (LoginAccount.Email == adminEmail)
                {
                    btnDelete.Enabled = true;
                    btnFilter.Enabled = true;
                    btnUpdate.Enabled = true;
                }
                else
                {
                    btnFilter.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Load product list");
            }
        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmProductDetails f = new frmProductDetails
            {
                Text = "Add Product",
                InsertOrUpdate = false,
                ProductRepository = productRepository
            };
            if (f.ShowDialog() == DialogResult.OK)
            {
                LoadProductList();
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
                    frmProductDetails f = new frmProductDetails
                    {
                        Text = "Update Information",
                        InsertOrUpdate = true,
                        productInfo = GetProductObject(),
                        ProductRepository = productRepository
                    };
                    if (f.ShowDialog() == DialogResult.OK)
                    {
                        LoadProductList();
                        source.Position = source.Count - 1;
                    }
                }
                else
                {
                    MessageBox.Show("Empty list product");
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                var product = GetProductObject();
                if (MessageBox.Show("Do you want to delete?", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    productRepository.DeleteProduct(product.ProductId);
                    LoadProductList();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Delete Product");
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //int filterProductID = int.Parse(txtProductID.Text);
            //string filterProductName = txtProductName.Text;


            //if (cbProductID.Checked == true)
            //{
            //    LoadProductList();
            //    List<Product> filterID = new List<Product>();
            //    for (int i = 0; i < dgvProduct.Rows.Count - 1; i++)
            //    {
            //        if (dgvProduct.Rows[i].Cells[0].Value.Equals(filterProductID))
            //        {
            //            //filterID.Add(listProduct[i]);
            //        }

            //    }
            //    if (filterID.Count > 0)
            //    {
            //        source = new BindingSource();
            //        source.DataSource = filterID;
            //        txtProductID.DataBindings.Clear();
            //        txtCategory.DataBindings.Clear();
            //        txtProductName.DataBindings.Clear();
            //        txtWeight.DataBindings.Clear();
            //        txtUnitPrice.DataBindings.Clear();
            //        txtUnitslnStock.DataBindings.Clear();

            //        txtProductID.DataBindings.Add("Text", source, "ProductID");
            //        txtCategory.DataBindings.Add("Text", source, "Category");
            //        txtProductName.DataBindings.Add("Text", source, "ProductName");
            //        txtWeight.DataBindings.Add("Text", source, "Weight");
            //        txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
            //        txtUnitslnStock.DataBindings.Add("Text", source, "UnitslnStock");

            //        dgvProduct.DataSource = null;
            //        dgvProduct.DataSource = filterID;
            //    }
            //    else
            //    {
            //        dgvProduct.DataSource = null;
            //        dgvProduct.DataSource = source;
            //    }
            //}
            //else if (cbProductName.Checked == true)
            //{
            //    LoadProductList();
            //    List<Product> filterName = new List<Product>();
            //    for (int i = 0; i < dgvProduct.Rows.Count - 1; i++)
            //    {
            //        if (dgvProduct.Rows[i].Cells[2].Value.ToString().ToLower().Contains(filterProductName.ToLower()))
            //        {
            //            //filterName.Add(listProduct[i]);
            //        }

            //    }
            //    if (filterName.Count > 0)
            //    {
            //        source = new BindingSource();
            //        source.DataSource = filterName;
            //        txtProductID.DataBindings.Clear();
            //        txtCategory.DataBindings.Clear();
            //        txtProductName.DataBindings.Clear();
            //        txtWeight.DataBindings.Clear();
            //        txtUnitPrice.DataBindings.Clear();
            //        txtUnitslnStock.DataBindings.Clear();

            //        txtProductID.DataBindings.Add("Text", source, "ProductID");
            //        txtCategory.DataBindings.Add("Text", source, "Category");
            //        txtProductName.DataBindings.Add("Text", source, "ProductName");
            //        txtWeight.DataBindings.Add("Text", source, "Weight");
            //        txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
            //        txtUnitslnStock.DataBindings.Add("Text", source, "UnitslnStock");

            //        dgvProduct.DataSource = null;
            //        dgvProduct.DataSource = filterName;
            //    }
            //    else
            //    {
            //        dgvProduct.DataSource = null;
            //        dgvProduct.DataSource = source;
            //    }
            //}
            //else if (cbUnitPrice.Checked == true)
            //{
            //    decimal filterUnitPriceStart = decimal.Parse(txtUnitPriceStart.Text);
            //    decimal filterUnitPriceEnd = decimal.Parse(txtUnitPriceEnd.Text);
            //    LoadProductList();
            //    List<Product> filterByUnitPrice = new ProductRepository().GetProductByUnitPrice(filterUnitPriceStart, filterUnitPriceEnd);

            //    listProduct = filterByUnitPrice;
            //    if (filterByUnitPrice.Count > 0)
            //    {
            //        source = new BindingSource();
            //        source.DataSource = filterByUnitPrice;
            //        txtProductID.DataBindings.Clear();
            //        txtCategory.DataBindings.Clear();
            //        txtProductName.DataBindings.Clear();
            //        txtWeight.DataBindings.Clear();
            //        txtUnitPrice.DataBindings.Clear();
            //        txtUnitslnStock.DataBindings.Clear();

            //        txtProductID.DataBindings.Add("Text", source, "ProductID");
            //        txtCategory.DataBindings.Add("Text", source, "Category");
            //        txtProductName.DataBindings.Add("Text", source, "ProductName");
            //        txtWeight.DataBindings.Add("Text", source, "Weight");
            //        txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
            //        txtUnitslnStock.DataBindings.Add("Text", source, "UnitslnStock");

            //        dgvProduct.DataSource = null;
            //        dgvProduct.DataSource = filterByUnitPrice;
            //    }
            //    else
            //    {
            //        dgvProduct.DataSource = null;
            //        dgvProduct.DataSource = source;
            //    }
            //}
            //else if (cbUnitslnStock.Checked == true)
            //{
            //    int filterUnitslnStockStart = int.Parse(txtUnitslnStockStart.Text);
            //    int filterUnitslnStockEnd = int.Parse(txtUnitslnStockEnd.Text);
            //    LoadProductList();
            //    List<ProductObject> filterByUnitStock = new ProductRepository().GetProductByUnitStock(filterUnitslnStockStart, filterUnitslnStockEnd);
            //    listProduct = filterByUnitStock;
            //    if (filterByUnitStock.Count > 0)
            //    {
            //        source = new BindingSource();
            //        source.DataSource = filterByUnitStock;
            //        txtProductID.DataBindings.Clear();
            //        txtCategory.DataBindings.Clear();
            //        txtProductName.DataBindings.Clear();
            //        txtWeight.DataBindings.Clear();
            //        txtUnitPrice.DataBindings.Clear();
            //        txtUnitslnStock.DataBindings.Clear();

            //        txtProductID.DataBindings.Add("Text", source, "ProductID");
            //        txtCategory.DataBindings.Add("Text", source, "Category");
            //        txtProductName.DataBindings.Add("Text", source, "ProductName");
            //        txtWeight.DataBindings.Add("Text", source, "Weight");
            //        txtUnitPrice.DataBindings.Add("Text", source, "UnitPrice");
            //        txtUnitslnStock.DataBindings.Add("Text", source, "UnitslnStock");

            //        dgvProduct.DataSource = null;
            //        dgvProduct.DataSource = filterByUnitStock;
            //    }
            //    else
            //    {
            //        dgvProduct.DataSource = null;
            //        dgvProduct.DataSource = source;
            //    }
            //}
            //else
            //{
            //    LoadProductList();
            //}
        }
    }
}
