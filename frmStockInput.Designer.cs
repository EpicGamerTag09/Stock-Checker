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
            this.lblTransFeeValue = new System.Windows.Forms.Label();
            this.lblGrossProfitValue = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnUpdateStock = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(46, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtPurchasePrice
            // 
            this.txtPurchasePrice.Location = new System.Drawing.Point(104, 222);
            this.txtPurchasePrice.Name = "txtPurchasePrice";
            this.txtPurchasePrice.Size = new System.Drawing.Size(100, 20);
            this.txtPurchasePrice.TabIndex = 1;
            // 
            // txtSellingPrice
            // 
            this.txtSellingPrice.Location = new System.Drawing.Point(104, 342);
            this.txtSellingPrice.Name = "txtSellingPrice";
            this.txtSellingPrice.Size = new System.Drawing.Size(100, 20);
            this.txtSellingPrice.TabIndex = 2;
            // 
            // txtSharesPurchased
            // 
            this.txtSharesPurchased.Location = new System.Drawing.Point(73, 124);
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
            // lblTransFeeValue
            // 
            this.lblTransFeeValue.AutoSize = true;
            this.lblTransFeeValue.Location = new System.Drawing.Point(674, 138);
            this.lblTransFeeValue.Name = "lblTransFeeValue";
            this.lblTransFeeValue.Size = new System.Drawing.Size(65, 13);
            this.lblTransFeeValue.TabIndex = 5;
            this.lblTransFeeValue.Text = "$transaction";
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
            this.btnCalculate.Location = new System.Drawing.Point(70, 425);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
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
            // frmStockInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 515);
            this.Controls.Add(this.btnUpdateStock);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblGrossProfitValue);
            this.Controls.Add(this.lblTransFeeValue);
            this.Controls.Add(this.lblPurchaseCostValue);
            this.Controls.Add(this.txtSharesPurchased);
            this.Controls.Add(this.txtSellingPrice);
            this.Controls.Add(this.txtPurchasePrice);
            this.Controls.Add(this.txtName);
            this.Name = "frmStockInput";
            this.Text = "Stock #";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPurchasePrice;
        private System.Windows.Forms.TextBox txtSellingPrice;
        private System.Windows.Forms.TextBox txtSharesPurchased;
        private System.Windows.Forms.Label lblPurchaseCostValue;
        private System.Windows.Forms.Label lblTransFeeValue;
        private System.Windows.Forms.Label lblGrossProfitValue;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnUpdateStock;
    }
}