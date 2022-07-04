
namespace SalesWinApp
{
    partial class frmOrdersUpdate
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
            this.txtShippedDate = new System.Windows.Forms.MaskedTextBox();
            this.txtRequiredDate = new System.Windows.Forms.MaskedTextBox();
            this.txtOrderDate = new System.Windows.Forms.MaskedTextBox();
            this.lbOrderID = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lbMemberID = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbOrderDate = new System.Windows.Forms.Label();
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.lbRequiredDate = new System.Windows.Forms.Label();
            this.lbFreight = new System.Windows.Forms.Label();
            this.lbShippedDate = new System.Windows.Forms.Label();
            this.txtOrderID = new System.Windows.Forms.TextBox();
            this.txtMemberID = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtShippedDate);
            this.panel1.Controls.Add(this.txtRequiredDate);
            this.panel1.Controls.Add(this.txtOrderDate);
            this.panel1.Controls.Add(this.lbOrderID);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.lbMemberID);
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.lbOrderDate);
            this.panel1.Controls.Add(this.txtFreight);
            this.panel1.Controls.Add(this.lbRequiredDate);
            this.panel1.Controls.Add(this.lbFreight);
            this.panel1.Controls.Add(this.lbShippedDate);
            this.panel1.Controls.Add(this.txtOrderID);
            this.panel1.Controls.Add(this.txtMemberID);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(408, 391);
            this.panel1.TabIndex = 16;
            // 
            // txtShippedDate
            // 
            this.txtShippedDate.Location = new System.Drawing.Point(137, 219);
            this.txtShippedDate.Mask = "00/00/0000 90:00";
            this.txtShippedDate.Name = "txtShippedDate";
            this.txtShippedDate.Size = new System.Drawing.Size(259, 27);
            this.txtShippedDate.TabIndex = 16;
            this.txtShippedDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtRequiredDate
            // 
            this.txtRequiredDate.Location = new System.Drawing.Point(137, 166);
            this.txtRequiredDate.Mask = "00/00/0000 90:00";
            this.txtRequiredDate.Name = "txtRequiredDate";
            this.txtRequiredDate.Size = new System.Drawing.Size(259, 27);
            this.txtRequiredDate.TabIndex = 15;
            this.txtRequiredDate.ValidatingType = typeof(System.DateTime);
            // 
            // txtOrderDate
            // 
            this.txtOrderDate.Location = new System.Drawing.Point(137, 115);
            this.txtOrderDate.Mask = "00/00/0000 90:00";
            this.txtOrderDate.Name = "txtOrderDate";
            this.txtOrderDate.Size = new System.Drawing.Size(259, 27);
            this.txtOrderDate.TabIndex = 14;
            this.txtOrderDate.ValidatingType = typeof(System.DateTime);
            // 
            // lbOrderID
            // 
            this.lbOrderID.AutoSize = true;
            this.lbOrderID.Location = new System.Drawing.Point(3, 12);
            this.lbOrderID.Name = "lbOrderID";
            this.lbOrderID.Size = new System.Drawing.Size(66, 20);
            this.lbOrderID.TabIndex = 0;
            this.lbOrderID.Text = "Order ID";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(302, 354);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(94, 29);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lbMemberID
            // 
            this.lbMemberID.AutoSize = true;
            this.lbMemberID.Location = new System.Drawing.Point(3, 67);
            this.lbMemberID.Name = "lbMemberID";
            this.lbMemberID.Size = new System.Drawing.Size(80, 20);
            this.lbMemberID.TabIndex = 1;
            this.lbMemberID.Text = "MemberID";
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Location = new System.Drawing.Point(168, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 29);
            this.btnSave.TabIndex = 12;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbOrderDate
            // 
            this.lbOrderDate.AutoSize = true;
            this.lbOrderDate.Location = new System.Drawing.Point(3, 118);
            this.lbOrderDate.Name = "lbOrderDate";
            this.lbOrderDate.Size = new System.Drawing.Size(83, 20);
            this.lbOrderDate.TabIndex = 2;
            this.lbOrderDate.Text = "Order Date";
            // 
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(140, 276);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(256, 27);
            this.txtFreight.TabIndex = 11;
            // 
            // lbRequiredDate
            // 
            this.lbRequiredDate.AutoSize = true;
            this.lbRequiredDate.Location = new System.Drawing.Point(3, 169);
            this.lbRequiredDate.Name = "lbRequiredDate";
            this.lbRequiredDate.Size = new System.Drawing.Size(105, 20);
            this.lbRequiredDate.TabIndex = 3;
            this.lbRequiredDate.Text = "Required Date";
            // 
            // lbFreight
            // 
            this.lbFreight.AutoSize = true;
            this.lbFreight.Location = new System.Drawing.Point(3, 279);
            this.lbFreight.Name = "lbFreight";
            this.lbFreight.Size = new System.Drawing.Size(55, 20);
            this.lbFreight.TabIndex = 10;
            this.lbFreight.Text = "Freight";
            // 
            // lbShippedDate
            // 
            this.lbShippedDate.AutoSize = true;
            this.lbShippedDate.Location = new System.Drawing.Point(3, 226);
            this.lbShippedDate.Name = "lbShippedDate";
            this.lbShippedDate.Size = new System.Drawing.Size(100, 20);
            this.lbShippedDate.TabIndex = 4;
            this.lbShippedDate.Text = "Shipped Date";
            // 
            // txtOrderID
            // 
            this.txtOrderID.Location = new System.Drawing.Point(140, 9);
            this.txtOrderID.Name = "txtOrderID";
            this.txtOrderID.Size = new System.Drawing.Size(256, 27);
            this.txtOrderID.TabIndex = 5;
            // 
            // txtMemberID
            // 
            this.txtMemberID.Location = new System.Drawing.Point(140, 64);
            this.txtMemberID.Name = "txtMemberID";
            this.txtMemberID.Size = new System.Drawing.Size(256, 27);
            this.txtMemberID.TabIndex = 6;
            // 
            // frmOrdersUpdate
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 411);
            this.Controls.Add(this.panel1);
            this.Name = "frmOrdersUpdate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OrdersDetails";
            this.Load += new System.EventHandler(this.frmOrdersUpdate_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbOrderID;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lbMemberID;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbOrderDate;
        private System.Windows.Forms.TextBox txtFreight;
        private System.Windows.Forms.Label lbRequiredDate;
        private System.Windows.Forms.Label lbFreight;
        private System.Windows.Forms.Label lbShippedDate;
        private System.Windows.Forms.TextBox txtOrderID;
        private System.Windows.Forms.TextBox txtMemberID;
        private System.Windows.Forms.MaskedTextBox txtShippedDate;
        private System.Windows.Forms.MaskedTextBox txtRequiredDate;
        private System.Windows.Forms.MaskedTextBox txtOrderDate;
    }
}