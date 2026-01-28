namespace Stock_Checker
{
    partial class frmStockInput
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPurchasePrice = new System.Windows.Forms.TextBox();
            this.txtSellingPrice = new System.Windows.Forms.TextBox();
            this.txtSharesPurchased = new System.Windows.Forms.TextBox();
            this.lblPurchaseCostValue = new System.Windows.Forms.Label();
            this.lblPurFeeValue = new System.Windows.Forms.Label();
            this.lblGrossProfitValue = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblSellFeeValue = new System.Windows.Forms.Label();
            this.grpStockInfo = new System.Windows.Forms.GroupBox();
            this.lblSellingPrice = new System.Windows.Forms.Label();
            this.lblShares = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.lblSockName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSellFeeText = new System.Windows.Forms.Label();
            this.lblBuyFeeText = new System.Windows.Forms.Label();
            this.lblPurCostText = new System.Windows.Forms.Label();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.grpStockInfo.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Verdana", 18F);
            this.txtName.Location = new System.Drawing.Point(20, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(344, 37);
            this.txtName.TabIndex = 0;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Font = new System.Drawing.Font("Verdana", 18F);
            this.txtPurchasePrice.Location = new System.Drawing.Point(20, 168);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(344, 37);
            this.txtPurchasePrice.TabIndex = 1;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSellingPrice.Location = new System.Drawing.Point(20, 350);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(344, 37);
            this.txtSellingPrice.TabIndex = 2;
            // 
            // txtSharesPurchased
            // 
            this.txtSharesPurchased.Font = new System.Drawing.Font("Verdana", 18F);
            this.txtSharesPurchased.Location = new System.Drawing.Point(20, 259);
            this.txtSharesPurchased.Name = "txtSharesPurchased";
            this.txtSharesPurchased.Size = new System.Drawing.Size(344, 37);
            this.txtSharesPurchased.TabIndex = 3;
            // 
            // lblPurchaseCostValue
            // 
            this.lblPurchaseCostValue.AutoSize = true;
            this.lblPurchaseCostValue.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseCostValue.Location = new System.Drawing.Point(40, 82);
            this.lblPurchaseCostValue.Name = "lblPurchaseCostValue";
            this.lblPurchaseCostValue.Size = new System.Drawing.Size(0, 27);
            this.lblPurchaseCostValue.TabIndex = 4;
            // 
            // lblPurFeeValue
            // 
            this.lblPurFeeValue.AutoSize = true;
            this.lblPurFeeValue.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurFeeValue.Location = new System.Drawing.Point(40, 173);
            this.lblPurFeeValue.Name = "lblPurFeeValue";
            this.lblPurFeeValue.Size = new System.Drawing.Size(0, 27);
            this.lblPurFeeValue.TabIndex = 5;
            // 
            // lblGrossProfitValue
            // 
            this.lblGrossProfitValue.AutoSize = true;
            this.lblGrossProfitValue.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGrossProfitValue.Location = new System.Drawing.Point(40, 355);
            this.lblGrossProfitValue.Name = "lblGrossProfitValue";
            this.lblGrossProfitValue.Size = new System.Drawing.Size(0, 27);
            this.lblGrossProfitValue.TabIndex = 6;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Turquoise;
            this.btnCalculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalculate.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(238, 407);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(133, 33);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // lblSellFeeValue
            // 
            this.lblSellFeeValue.AutoSize = true;
            this.lblSellFeeValue.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellFeeValue.Location = new System.Drawing.Point(40, 264);
            this.lblSellFeeValue.Name = "lblSellFeeValue";
            this.lblSellFeeValue.Size = new System.Drawing.Size(0, 27);
            this.lblSellFeeValue.TabIndex = 9;
            // 
            // grpStockInfo
            // 
            this.grpStockInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.grpStockInfo.Controls.Add(this.lblSellingPrice);
            this.grpStockInfo.Controls.Add(this.lblShares);
            this.grpStockInfo.Controls.Add(this.lblPurchasePrice);
            this.grpStockInfo.Controls.Add(this.btnCalculate);
            this.grpStockInfo.Controls.Add(this.lblSockName);
            this.grpStockInfo.Controls.Add(this.txtName);
            this.grpStockInfo.Controls.Add(this.txtPurchasePrice);
            this.grpStockInfo.Controls.Add(this.txtSharesPurchased);
            this.grpStockInfo.Controls.Add(this.txtSellingPrice);
            this.grpStockInfo.Font = new System.Drawing.Font("Rockwell", 24F);
            this.grpStockInfo.Location = new System.Drawing.Point(13, 18);
            this.grpStockInfo.Name = "grpStockInfo";
            this.grpStockInfo.Size = new System.Drawing.Size(383, 450);
            this.grpStockInfo.TabIndex = 10;
            this.grpStockInfo.TabStop = false;
            this.grpStockInfo.Text = "Stock Info";
            // 
            // lblSellingPrice
            // 
            this.lblSellingPrice.AutoSize = true;
            this.lblSellingPrice.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellingPrice.Location = new System.Drawing.Point(6, 316);
            this.lblSellingPrice.Name = "lblSellingPrice";
            this.lblSellingPrice.Size = new System.Drawing.Size(177, 31);
            this.lblSellingPrice.TabIndex = 4;
            this.lblSellingPrice.Text = "Selling Price:";
            // 
            // lblShares
            // 
            this.lblShares.AutoSize = true;
            this.lblShares.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShares.Location = new System.Drawing.Point(6, 225);
            this.lblShares.Name = "lblShares";
            this.lblShares.Size = new System.Drawing.Size(238, 31);
            this.lblShares.TabIndex = 2;
            this.lblShares.Text = "Shares Purchased:";
            // 
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasePrice.Location = new System.Drawing.Point(6, 134);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(203, 31);
            this.lblPurchasePrice.TabIndex = 1;
            this.lblPurchasePrice.Text = "Purchase Price:";
            // 
            // lblSockName
            // 
            this.lblSockName.AutoSize = true;
            this.lblSockName.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSockName.Location = new System.Drawing.Point(6, 43);
            this.lblSockName.Name = "lblSockName";
            this.lblSockName.Size = new System.Drawing.Size(166, 31);
            this.lblSockName.TabIndex = 0;
            this.lblSockName.Text = "Stock Name:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblSellFeeText);
            this.groupBox1.Controls.Add(this.lblGrossProfitValue);
            this.groupBox1.Controls.Add(this.lblBuyFeeText);
            this.groupBox1.Controls.Add(this.lblSellFeeValue);
            this.groupBox1.Controls.Add(this.lblPurCostText);
            this.groupBox1.Controls.Add(this.btnUpdateStock);
            this.groupBox1.Controls.Add(this.lblPurchaseCostValue);
            this.groupBox1.Controls.Add(this.lblPurFeeValue);
            this.groupBox1.Font = new System.Drawing.Font("Rockwell", 24F);
            this.groupBox1.Location = new System.Drawing.Point(418, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 450);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Stock Info";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "Gross Profit:";
            // 
            // lblSellFeeText
            // 
            this.lblSellFeeText.AutoSize = true;
            this.lblSellFeeText.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSellFeeText.Location = new System.Drawing.Point(6, 225);
            this.lblSellFeeText.Name = "lblSellFeeText";
            this.lblSellFeeText.Size = new System.Drawing.Size(159, 31);
            this.lblSellFeeText.TabIndex = 10;
            this.lblSellFeeText.Text = "Selling Fee:";
            // 
            // lblBuyFeeText
            // 
            this.lblBuyFeeText.AutoSize = true;
            this.lblBuyFeeText.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuyFeeText.Location = new System.Drawing.Point(6, 134);
            this.lblBuyFeeText.Name = "lblBuyFeeText";
            this.lblBuyFeeText.Size = new System.Drawing.Size(185, 31);
            this.lblBuyFeeText.TabIndex = 9;
            this.lblBuyFeeText.Text = "Purchase Fee:";
            // 
            // lblPurCostText
            // 
            this.lblPurCostText.AutoSize = true;
            this.lblPurCostText.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurCostText.Location = new System.Drawing.Point(6, 43);
            this.lblPurCostText.Name = "lblPurCostText";
            this.lblPurCostText.Size = new System.Drawing.Size(196, 31);
            this.lblPurCostText.TabIndex = 8;
            this.lblPurCostText.Text = "Purchase Cost:";
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.BackColor = System.Drawing.Color.Turquoise;
            this.btnUpdateStock.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateStock.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStock.Location = new System.Drawing.Point(199, 404);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(172, 36);
            this.btnUpdateStock.TabIndex = 7;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = false;
            this.btnUpdateStock.Click += new System.EventHandler(this.btnUpdateStock_Click);
            // 
            // frmStockInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(819, 481);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpStockInfo);
            this.Name = "frmStockInput";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock #";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmStockInput_FormClosing);
            this.grpStockInfo.ResumeLayout(false);
            this.grpStockInfo.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.TextBox txtSharesPurchased;
        private System.Windows.Forms.Label lblPurchaseCostValue;
        private System.Windows.Forms.Label lblPurFeeValue;
        private System.Windows.Forms.Label lblGrossProfitValue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label lblSellFeeValue;
        private System.Windows.Forms.GroupBox grpStockInfo;
        private System.Windows.Forms.Label lblSockName;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label lblShares;
        private System.Windows.Forms.Label lblSellingPrice;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblSellFeeText;
        private System.Windows.Forms.Label lblBuyFeeText;
        private System.Windows.Forms.Label lblPurCostText;
        private System.Windows.Forms.Button btnUpdateStock;
    }
}