
namespace SalesWinApp
{
    partial class frmProduct
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.dgvProduct = new System.Windows.Forms.DataGridView();
            this.btnFilter = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cbProductName = new System.Windows.Forms.CheckBox();
            this.cbProductID = new System.Windows.Forms.CheckBox();
            this.lbUnitslnStockTo = new System.Windows.Forms.Label();
            this.lbUnitPriceTo = new System.Windows.Forms.Label();
            this.txtUnitslnStockEnd = new System.Windows.Forms.TextBox();
            this.txtUnitslnStockStart = new System.Windows.Forms.TextBox();
            this.txtUnitPriceEnd = new System.Windows.Forms.TextBox();
            this.txtUnitPriceStart = new System.Windows.Forms.TextBox();
            this.cbUnitslnStock = new System.Windows.Forms.CheckBox();
            this.cbUnitPrice = new System.Windows.Forms.CheckBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.btnCreateOrder = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtUnitslnStock = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.txtProductID = new System.Windows.Forms.TextBox();
            this.lbUnitPrice = new System.Windows.Forms.Label();
            this.lbUnitslnStock = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbProductID = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProduct);
            this.panel1.Location = new System.Drawing.Point(12, 192);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(940, 435);
            this.panel1.TabIndex = 0;
            // 
            // dgvProduct
            // 
            this.dgvProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduct.Location = new System.Drawing.Point(3, 3);
            this.dgvProduct.Name = "dgvProduct";
            this.dgvProduct.RowHeadersWidth = 51;
            this.dgvProduct.RowTemplate.Height = 29;
            this.dgvProduct.Size = new System.Drawing.Size(934, 429);
            this.dgvProduct.TabIndex = 0;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(818, 34);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(107, 33);
            this.btnFilter.TabIndex = 8;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cbProductName);
            this.panel3.Controls.Add(this.cbProductID);
            this.panel3.Controls.Add(this.lbUnitslnStockTo);
            this.panel3.Controls.Add(this.lbUnitPriceTo);
            this.panel3.Controls.Add(this.txtUnitslnStockEnd);
            this.panel3.Controls.Add(this.txtUnitslnStockStart);
            this.panel3.Controls.Add(this.txtUnitPriceEnd);
            this.panel3.Controls.Add(this.txtUnitPriceStart);
            this.panel3.Controls.Add(this.cbUnitslnStock);
            this.panel3.Controls.Add(this.cbUnitPrice);
            this.panel3.Controls.Add(this.txtWeight);
            this.panel3.Controls.Add(this.txtCategory);
            this.panel3.Controls.Add(this.btnCreateOrder);
            this.panel3.Controls.Add(this.btnLoad);
            this.panel3.Controls.Add(this.btnDelete);
            this.panel3.Controls.Add(this.btnAddProduct);
            this.panel3.Controls.Add(this.btnFilter);
            this.panel3.Controls.Add(this.btnUpdate);
            this.panel3.Controls.Add(this.txtUnitPrice);
            this.panel3.Controls.Add(this.txtUnitslnStock);
            this.panel3.Controls.Add(this.txtProductName);
            this.panel3.Controls.Add(this.txtProductID);
            this.panel3.Controls.Add(this.lbUnitPrice);
            this.panel3.Controls.Add(this.lbUnitslnStock);
            this.panel3.Controls.Add(this.lbProductName);
            this.panel3.Controls.Add(this.lbProductID);
            this.panel3.Location = new System.Drawing.Point(12, 15);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(940, 171);
            this.panel3.TabIndex = 2;
            // 
            // cbProductName
            // 
            this.cbProductName.AutoSize = true;
            this.cbProductName.Location = new System.Drawing.Point(132, 72);
            this.cbProductName.Name = "cbProductName";
            this.cbProductName.Size = new System.Drawing.Size(18, 17);
            this.cbProductName.TabIndex = 28;
            this.cbProductName.UseVisualStyleBackColor = true;
            // 
            // cbProductID
            // 
            this.cbProductID.AutoSize = true;
            this.cbProductID.Location = new System.Drawing.Point(132, 16);
            this.cbProductID.Name = "cbProductID";
            this.cbProductID.Size = new System.Drawing.Size(18, 17);
            this.cbProductID.TabIndex = 27;
            this.cbProductID.UseVisualStyleBackColor = true;
            // 
            // lbUnitslnStockTo
            // 
            this.lbUnitslnStockTo.AutoSize = true;
            this.lbUnitslnStockTo.Location = new System.Drawing.Point(630, 69);
            this.lbUnitslnStockTo.Name = "lbUnitslnStockTo";
            this.lbUnitslnStockTo.Size = new System.Drawing.Size(23, 20);
            this.lbUnitslnStockTo.TabIndex = 26;
            this.lbUnitslnStockTo.Text = "to";
            // 
            // lbUnitPriceTo
            // 
            this.lbUnitPriceTo.AutoSize = true;
            this.lbUnitPriceTo.Location = new System.Drawing.Point(630, 13);
            this.lbUnitPriceTo.Name = "lbUnitPriceTo";
            this.lbUnitPriceTo.Size = new System.Drawing.Size(23, 20);
            this.lbUnitPriceTo.TabIndex = 25;
            this.lbUnitPriceTo.Text = "to";
            // 
            // txtUnitslnStockEnd
            // 
            this.txtUnitslnStockEnd.Location = new System.Drawing.Point(671, 66);
            this.txtUnitslnStockEnd.Name = "txtUnitslnStockEnd";
            this.txtUnitslnStockEnd.PlaceholderText = "1000";
            this.txtUnitslnStockEnd.Size = new System.Drawing.Size(89, 27);
            this.txtUnitslnStockEnd.TabIndex = 24;
            // 
            // txtUnitslnStockStart
            // 
            this.txtUnitslnStockStart.Location = new System.Drawing.Point(524, 66);
            this.txtUnitslnStockStart.Name = "txtUnitslnStockStart";
            this.txtUnitslnStockStart.PlaceholderText = "0";
            this.txtUnitslnStockStart.Size = new System.Drawing.Size(89, 27);
            this.txtUnitslnStockStart.TabIndex = 23;
            // 
            // txtUnitPriceEnd
            // 
            this.txtUnitPriceEnd.Location = new System.Drawing.Point(671, 10);
            this.txtUnitPriceEnd.Name = "txtUnitPriceEnd";
            this.txtUnitPriceEnd.PlaceholderText = "1000";
            this.txtUnitPriceEnd.Size = new System.Drawing.Size(89, 27);
            this.txtUnitPriceEnd.TabIndex = 22;
            // 
            // txtUnitPriceStart
            // 
            this.txtUnitPriceStart.Location = new System.Drawing.Point(524, 10);
            this.txtUnitPriceStart.Name = "txtUnitPriceStart";
            this.txtUnitPriceStart.PlaceholderText = "0";
            this.txtUnitPriceStart.Size = new System.Drawing.Size(89, 27);
            this.txtUnitPriceStart.TabIndex = 21;
            // 
            // cbUnitslnStock
            // 
            this.cbUnitslnStock.AutoSize = true;
            this.cbUnitslnStock.Location = new System.Drawing.Point(500, 72);
            this.cbUnitslnStock.Name = "cbUnitslnStock";
            this.cbUnitslnStock.Size = new System.Drawing.Size(18, 17);
            this.cbUnitslnStock.TabIndex = 20;
            this.cbUnitslnStock.UseVisualStyleBackColor = true;
            // 
            // cbUnitPrice
            // 
            this.cbUnitPrice.AutoSize = true;
            this.cbUnitPrice.Location = new System.Drawing.Point(500, 13);
            this.cbUnitPrice.Name = "cbUnitPrice";
            this.cbUnitPrice.Size = new System.Drawing.Size(18, 17);
            this.cbUnitPrice.TabIndex = 19;
            this.cbUnitPrice.UseVisualStyleBackColor = true;
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(709, 136);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(69, 27);
            this.txtWeight.TabIndex = 18;
            // 
            // txtCategory
            // 
            this.txtCategory.Location = new System.Drawing.Point(709, 103);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(69, 27);
            this.txtCategory.TabIndex = 17;
            // 
            // btnCreateOrder
            // 
            this.btnCreateOrder.Location = new System.Drawing.Point(795, 103);
            this.btnCreateOrder.Name = "btnCreateOrder";
            this.btnCreateOrder.Size = new System.Drawing.Size(140, 61);
            this.btnCreateOrder.TabIndex = 16;
            this.btnCreateOrder.Text = "Create new order";
            this.btnCreateOrder.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(19, 123);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(117, 41);
            this.btnLoad.TabIndex = 12;
            this.btnLoad.Text = "Load";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(550, 123);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 41);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(188, 123);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(117, 41);
            this.btnAddProduct.TabIndex = 13;
            this.btnAddProduct.Text = "Add Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(377, 123);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(117, 41);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.Location = new System.Drawing.Point(377, 10);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(24, 27);
            this.txtUnitPrice.TabIndex = 10;
            // 
            // txtUnitslnStock
            // 
            this.txtUnitslnStock.Location = new System.Drawing.Point(377, 66);
            this.txtUnitslnStock.Name = "txtUnitslnStock";
            this.txtUnitslnStock.Size = new System.Drawing.Size(24, 27);
            this.txtUnitslnStock.TabIndex = 9;
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(156, 66);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(219, 27);
            this.txtProductName.TabIndex = 8;
            // 
            // txtProductID
            // 
            this.txtProductID.Location = new System.Drawing.Point(156, 10);
            this.txtProductID.Name = "txtProductID";
            this.txtProductID.Size = new System.Drawing.Size(219, 27);
            this.txtProductID.TabIndex = 6;
            // 
            // lbUnitPrice
            // 
            this.lbUnitPrice.AutoSize = true;
            this.lbUnitPrice.Location = new System.Drawing.Point(407, 13);
            this.lbUnitPrice.Name = "lbUnitPrice";
            this.lbUnitPrice.Size = new System.Drawing.Size(72, 20);
            this.lbUnitPrice.TabIndex = 4;
            this.lbUnitPrice.Text = "Unit Price";
            // 
            // lbUnitslnStock
            // 
            this.lbUnitslnStock.AutoSize = true;
            this.lbUnitslnStock.Location = new System.Drawing.Point(407, 69);
            this.lbUnitslnStock.Name = "lbUnitslnStock";
            this.lbUnitslnStock.Size = new System.Drawing.Size(82, 20);
            this.lbUnitslnStock.TabIndex = 3;
            this.lbUnitslnStock.Text = "Units Stock";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(19, 69);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(104, 20);
            this.lbProductName.TabIndex = 2;
            this.lbProductName.Text = "Product Name";
            // 
            // lbProductID
            // 
            this.lbProductID.AutoSize = true;
            this.lbProductID.Location = new System.Drawing.Point(19, 13);
            this.lbProductID.Name = "lbProductID";
            this.lbProductID.Size = new System.Drawing.Size(79, 20);
            this.lbProductID.TabIndex = 0;
            this.lbProductID.Text = "Product ID";
            // 
            // frmProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 639);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Name = "frmProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmProduct";
            this.Load += new System.EventHandler(this.frmProduct_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduct)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvProduct;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUnitslnStock;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.TextBox txtProductID;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.Label lbUnitslnStock;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbProductID;
        private System.Windows.Forms.Button btnCreateOrder;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.Label lbUnitslnStockTo;
        private System.Windows.Forms.Label lbUnitPriceTo;
        private System.Windows.Forms.TextBox txtUnitslnStockEnd;
        private System.Windows.Forms.TextBox txtUnitslnStockStart;
        private System.Windows.Forms.TextBox txtUnitPriceEnd;
        private System.Windows.Forms.TextBox txtUnitPriceStart;
        private System.Windows.Forms.CheckBox cbUnitslnStock;
        private System.Windows.Forms.CheckBox cbUnitPrice;
        private System.Windows.Forms.CheckBox cbProductName;
        private System.Windows.Forms.CheckBox cbProductID;
    }
}