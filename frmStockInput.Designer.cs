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
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.lblSellFeeValue = new System.Windows.Forms.Label();
            this.grpStockInfo = new System.Windows.Forms.GroupBox();
            this.lblSockName = new System.Windows.Forms.Label();
            this.lblPurchasePrice = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grpStockInfo.SuspendLayout();
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
            this.txtPurchasePrice.Location = new System.Drawing.Point(20, 167);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(344, 37);
            this.txtPurchasePrice.TabIndex = 1;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(893, 334);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSellingPrice.TabIndex = 2;
            // 
            // txtSharesPurchased
            // 
            this.txtSharesPurchased.Location = new System.Drawing.Point(893, 123);
            this.txtSharesPurchased.Name = "txtSharesPurchased";
            this.txtSharesPurchased.Size = new System.Drawing.Size(100, 20);
            this.txtSharesPurchased.TabIndex = 3;
            // 
            // lblPurchaseCostValue
            // 
            this.lblPurchaseCostValue.AutoSize = true;
            this.lblPurchaseCostValue.Location = new System.Drawing.Point(677, 61);
            this.lblPurchaseCostValue.Name = "lblPurchaseCostValue";
            this.lblPurchaseCostValue.Size = new System.Drawing.Size(57, 13);
            this.lblPurchaseCostValue.TabIndex = 4;
            this.lblPurchaseCostValue.Text = "$purchase";
            // 
            // lblPurFeeValue
            // 
            this.lblPurFeeValue.AutoSize = true;
            this.lblPurFeeValue.Location = new System.Drawing.Point(674, 138);
            this.lblPurFeeValue.Name = "lblPurFeeValue";
            this.lblPurFeeValue.Size = new System.Drawing.Size(92, 13);
            this.lblPurFeeValue.TabIndex = 5;
            this.lblPurFeeValue.Text = "purchasefeevalue";
            // 
            // lblGrossProfitValue
            // 
            this.lblGrossProfitValue.AutoSize = true;
            this.lblGrossProfitValue.Location = new System.Drawing.Point(666, 223);
            this.lblGrossProfitValue.Name = "lblGrossProfitValue";
            this.lblGrossProfitValue.Size = new System.Drawing.Size(38, 13);
            this.lblGrossProfitValue.TabIndex = 6;
            this.lblGrossProfitValue.Text = "$gross";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(331, 455);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            // 
            // btnUpdateStock
            // 
            this.btnUpdateStock.Location = new System.Drawing.Point(669, 438);
            this.btnUpdateStock.Name = "btnUpdateStock";
            this.btnUpdateStock.Size = new System.Drawing.Size(141, 30);
            this.btnUpdateStock.TabIndex = 8;
            this.btnUpdateStock.Text = "Update Stock";
            this.btnUpdateStock.UseVisualStyleBackColor = true;
            // 
            // lblSellFeeValue
            // 
            this.lblSellFeeValue.AutoSize = true;
            this.lblSellFeeValue.Location = new System.Drawing.Point(677, 178);
            this.lblSellFeeValue.Name = "lblSellFeeValue";
            this.lblSellFeeValue.Size = new System.Drawing.Size(46, 13);
            this.lblSellFeeValue.TabIndex = 9;
            this.lblSellFeeValue.Text = "$sellFee";
            // 
            // grpStockInfo
            // 
            this.grpStockInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(248)))), ((int)(((byte)(255)))));
            this.grpStockInfo.Controls.Add(this.label1);
            this.grpStockInfo.Controls.Add(this.lblPurchasePrice);
            this.grpStockInfo.Controls.Add(this.lblSockName);
            this.grpStockInfo.Controls.Add(this.txtName);
            this.grpStockInfo.Controls.Add(this.txtPurchasePrice);
            this.grpStockInfo.Font = new System.Drawing.Font("Rockwell", 24F);
            this.grpStockInfo.Location = new System.Drawing.Point(13, 18);
            this.grpStockInfo.Name = "grpStockInfo";
            this.grpStockInfo.Size = new System.Drawing.Size(383, 403);
            this.grpStockInfo.TabIndex = 10;
            this.grpStockInfo.TabStop = false;
            this.grpStockInfo.Text = "Stock Info";
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
            // lblPurchasePrice
            // 
            this.lblPurchasePrice.AutoSize = true;
            this.lblPurchasePrice.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchasePrice.Location = new System.Drawing.Point(6, 133);
            this.lblPurchasePrice.Name = "lblPurchasePrice";
            this.lblPurchasePrice.Size = new System.Drawing.Size(203, 31);
            this.lblPurchasePrice.TabIndex = 1;
            this.lblPurchasePrice.Text = "Purchase Price:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Rockwell", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 226);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 31);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shares Purchased:";
            // 
            // frmStockInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(1107, 515);
            this.Controls.Add(this.grpStockInfo);
            this.Controls.Add(this.lblSellFeeValue);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblGrossProfitValue);
            this.Controls.Add(this.lblPurFeeValue);
            this.Controls.Add(this.lblPurchaseCostValue);
            this.Controls.Add(this.txtSharesPurchased);
            this.Controls.Add(this.txtSellingPrice);
            this.Name = "frmStockInput";
            this.Text = "Stock #";
            this.grpStockInfo.ResumeLayout(false);
            this.grpStockInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.Button btnUpdateStock;
        private System.Windows.Forms.Label lblSellFeeValue;
        private System.Windows.Forms.GroupBox grpStockInfo;
        private System.Windows.Forms.Label lblSockName;
        private System.Windows.Forms.Label lblPurchasePrice;
        private System.Windows.Forms.Label label1;
    }
}