namespace StoreManagementSystem
{
    partial class FormSales
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.panelHeader = new System.Windows.Forms.Panel();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.grpSale = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblTotalLabel = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.lblQtyLabel = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblStockLabel = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblPriceLabel = new System.Windows.Forms.Label();
            this.cboProduct = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.panelHeader.SuspendLayout();
            this.grpSale.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.panelHeader.Controls.Add(this.lblFormTitle);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(500, 55);
            this.panelHeader.TabIndex = 0;
            // 
            // lblFormTitle
            // 
            this.lblFormTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.White;
            this.lblFormTitle.Location = new System.Drawing.Point(0, 0);
            this.lblFormTitle.Name = "lblFormTitle";
            this.lblFormTitle.Size = new System.Drawing.Size(500, 55);
            this.lblFormTitle.TabIndex = 0;
            this.lblFormTitle.Text = "💰 عملية بيع جديدة";
            this.lblFormTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpSale
            // 
            this.grpSale.Controls.Add(this.btnSave);
            this.grpSale.Controls.Add(this.lblTotal);
            this.grpSale.Controls.Add(this.lblTotalLabel);
            this.grpSale.Controls.Add(this.txtQty);
            this.grpSale.Controls.Add(this.lblQtyLabel);
            this.grpSale.Controls.Add(this.lblStock);
            this.grpSale.Controls.Add(this.lblStockLabel);
            this.grpSale.Controls.Add(this.lblPrice);
            this.grpSale.Controls.Add(this.lblPriceLabel);
            this.grpSale.Controls.Add(this.cboProduct);
            this.grpSale.Controls.Add(this.lblProduct);
            this.grpSale.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.grpSale.ForeColor = System.Drawing.Color.White;
            this.grpSale.Location = new System.Drawing.Point(20, 70);
            this.grpSale.Name = "grpSale";
            this.grpSale.Size = new System.Drawing.Size(445, 270);
            this.grpSale.TabIndex = 1;
            this.grpSale.TabStop = false;
            this.grpSale.Text = "تفاصيل البيع";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(210, 230);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(210, 42);
            this.btnSave.TabIndex = 10;
            this.btnSave.Text = "💾 حفظ البيع";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.lblTotal.Location = new System.Drawing.Point(60, 200);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(310, 30);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "0";
            // 
            // lblTotalLabel
            // 
            this.lblTotalLabel.AutoSize = true;
            this.lblTotalLabel.ForeColor = System.Drawing.Color.Black;
            this.lblTotalLabel.Location = new System.Drawing.Point(380, 200);
            this.lblTotalLabel.Name = "lblTotalLabel";
            this.lblTotalLabel.Size = new System.Drawing.Size(63, 19);
            this.lblTotalLabel.TabIndex = 8;
            this.lblTotalLabel.Text = "الإجمالي:";
            // 
            // txtQty
            // 
            this.txtQty.BackColor = System.Drawing.Color.White;
            this.txtQty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtQty.ForeColor = System.Drawing.Color.Black;
            this.txtQty.Location = new System.Drawing.Point(60, 152);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(310, 25);
            this.txtQty.TabIndex = 7;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            // 
            // lblQtyLabel
            // 
            this.lblQtyLabel.AutoSize = true;
            this.lblQtyLabel.ForeColor = System.Drawing.Color.Black;
            this.lblQtyLabel.Location = new System.Drawing.Point(380, 155);
            this.lblQtyLabel.Name = "lblQtyLabel";
            this.lblQtyLabel.Size = new System.Drawing.Size(49, 19);
            this.lblQtyLabel.TabIndex = 6;
            this.lblQtyLabel.Text = "الكمية:";
            // 
            // lblStock
            // 
            this.lblStock.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(7)))));
            this.lblStock.Location = new System.Drawing.Point(60, 115);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(310, 25);
            this.lblStock.TabIndex = 5;
            this.lblStock.Text = "0";
            // 
            // lblStockLabel
            // 
            this.lblStockLabel.AutoSize = true;
            this.lblStockLabel.ForeColor = System.Drawing.Color.Black;
            this.lblStockLabel.Location = new System.Drawing.Point(380, 115);
            this.lblStockLabel.Name = "lblStockLabel";
            this.lblStockLabel.Size = new System.Drawing.Size(59, 19);
            this.lblStockLabel.TabIndex = 4;
            this.lblStockLabel.Text = "المخزون:";
            // 
            // lblPrice
            // 
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(200)))), ((int)(((byte)(83)))));
            this.lblPrice.Location = new System.Drawing.Point(60, 80);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(310, 25);
            this.lblPrice.TabIndex = 3;
            this.lblPrice.Text = "0";
            // 
            // lblPriceLabel
            // 
            this.lblPriceLabel.AutoSize = true;
            this.lblPriceLabel.ForeColor = System.Drawing.Color.Black;
            this.lblPriceLabel.Location = new System.Drawing.Point(380, 80);
            this.lblPriceLabel.Name = "lblPriceLabel";
            this.lblPriceLabel.Size = new System.Drawing.Size(48, 19);
            this.lblPriceLabel.TabIndex = 2;
            this.lblPriceLabel.Text = "السعر:";
            // 
            // cboProduct
            // 
            this.cboProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(63)))));
            this.cboProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProduct.ForeColor = System.Drawing.Color.White;
            this.cboProduct.Location = new System.Drawing.Point(60, 32);
            this.cboProduct.Name = "cboProduct";
            this.cboProduct.Size = new System.Drawing.Size(310, 25);
            this.cboProduct.TabIndex = 1;
            this.cboProduct.SelectedIndexChanged += new System.EventHandler(this.cboProduct_SelectedIndexChanged);
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.ForeColor = System.Drawing.Color.Black;
            this.lblProduct.Location = new System.Drawing.Point(380, 35);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(48, 19);
            this.lblProduct.TabIndex = 0;
            this.lblProduct.Text = "المنتج:";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(105)))));
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(20, 355);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 38);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FormSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.grpSale);
            this.Controls.Add(this.panelHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormSales";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "عملية بيع جديدة - New Sale";
            this.Load += new System.EventHandler(this.FormSales_Load);
            this.panelHeader.ResumeLayout(false);
            this.grpSale.ResumeLayout(false);
            this.grpSale.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.GroupBox grpSale;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblTotalLabel;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label lblQtyLabel;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblStockLabel;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblPriceLabel;
        private System.Windows.Forms.ComboBox cboProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Button btnClose;
    }
}
