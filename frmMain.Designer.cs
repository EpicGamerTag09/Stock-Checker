namespace Stock_Checker
{
    partial class frmMain
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
            this.txtInvestmentBudget = new System.Windows.Forms.TextBox();
            this.btnUpdateBudget = new System.Windows.Forms.Button();
            this.btnStock1 = new System.Windows.Forms.Button();
            this.lblStock1Name = new System.Windows.Forms.Label();
            this.lblStock1GrossProfit = new System.Windows.Forms.Label();
            this.lblStock1TransFee = new System.Windows.Forms.Label();
            this.lblTotalGrossValue = new System.Windows.Forms.Label();
            this.lblInvestmentBudget = new System.Windows.Forms.Label();
            this.lblDollar = new System.Windows.Forms.Label();
            this.lblStock1 = new System.Windows.Forms.Label();
            this.lblStock2 = new System.Windows.Forms.Label();
            this.lblStock2TransFee = new System.Windows.Forms.Label();
            this.lblStock2GrossProfit = new System.Windows.Forms.Label();
            this.lblStock2Name = new System.Windows.Forms.Label();
            this.btnStock2 = new System.Windows.Forms.Button();
            this.lblStock3 = new System.Windows.Forms.Label();
            this.lblStock3TransFee = new System.Windows.Forms.Label();
            this.lblStock3GrossProfit = new System.Windows.Forms.Label();
            this.lblStock3Name = new System.Windows.Forms.Label();
            this.btnStock3 = new System.Windows.Forms.Button();
            this.lblStock4 = new System.Windows.Forms.Label();
            this.lblStock4TransFee = new System.Windows.Forms.Label();
            this.lblStock4GrossProfit = new System.Windows.Forms.Label();
            this.lblStock4Name = new System.Windows.Forms.Label();
            this.btnStock4 = new System.Windows.Forms.Button();
            this.lblStock5 = new System.Windows.Forms.Label();
            this.lblStock5TransFee = new System.Windows.Forms.Label();
            this.lblStock5GrossProfit = new System.Windows.Forms.Label();
            this.lblStock5Name = new System.Windows.Forms.Label();
            this.btnStock5 = new System.Windows.Forms.Button();
            this.lblTotalGross = new System.Windows.Forms.Label();
            this.lblTotalTransFee = new System.Windows.Forms.Label();
            this.lblTotalFeesValue = new System.Windows.Forms.Label();
            this.lblNetProfit = new System.Windows.Forms.Label();
            this.lblNetProfitValue = new System.Windows.Forms.Label();
            this.lblTotalTax = new System.Windows.Forms.Label();
            this.lblTaxValue = new System.Windows.Forms.Label();
            this.lblNewBudget = new System.Windows.Forms.Label();
            this.lblNewBudgetValue = new System.Windows.Forms.Label();
            this.grpOutput = new System.Windows.Forms.GroupBox();
            this.grpOutput.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtInvestmentBudget
            // 
            this.txtInvestmentBudget.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvestmentBudget.Location = new System.Drawing.Point(47, 75);
            this.txtInvestmentBudget.Name = "txtInvestmentBudget";
            this.txtInvestmentBudget.Size = new System.Drawing.Size(261, 37);
            this.txtInvestmentBudget.TabIndex = 1;
            // 
            // btnUpdateBudget
            // 
            this.btnUpdateBudget.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateBudget.Location = new System.Drawing.Point(326, 74);
            this.btnUpdateBudget.MaximumSize = new System.Drawing.Size(133, 38);
            this.btnUpdateBudget.MinimumSize = new System.Drawing.Size(133, 38);
            this.btnUpdateBudget.Name = "btnUpdateBudget";
            this.btnUpdateBudget.Size = new System.Drawing.Size(133, 38);
            this.btnUpdateBudget.TabIndex = 0;
            this.btnUpdateBudget.Text = "Update";
            this.btnUpdateBudget.UseVisualStyleBackColor = true;
            this.btnUpdateBudget.Click += new System.EventHandler(this.btnUpdateBudget_Click);
            // 
            // btnStock1
            // 
            this.btnStock1.Enabled = false;
            this.btnStock1.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock1.Location = new System.Drawing.Point(625, 47);
            this.btnStock1.Name = "btnStock1";
            this.btnStock1.Size = new System.Drawing.Size(134, 39);
            this.btnStock1.TabIndex = 2;
            this.btnStock1.Text = "Update";
            this.btnStock1.UseVisualStyleBackColor = true;
            this.btnStock1.Click += new System.EventHandler(this.OpenStockInput);
            // 
            // lblStock1Name
            // 
            this.lblStock1Name.AutoSize = true;
            this.lblStock1Name.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock1Name.Location = new System.Drawing.Point(523, 93);
            this.lblStock1Name.Name = "lblStock1Name";
            this.lblStock1Name.Size = new System.Drawing.Size(183, 29);
            this.lblStock1Name.TabIndex = 3;
            this.lblStock1Name.Text = "Entry Needed!";
            // 
            // lblStock1GrossProfit
            // 
            this.lblStock1GrossProfit.AutoSize = true;
            this.lblStock1GrossProfit.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock1GrossProfit.Location = new System.Drawing.Point(523, 131);
            this.lblStock1GrossProfit.Name = "lblStock1GrossProfit";
            this.lblStock1GrossProfit.Size = new System.Drawing.Size(94, 29);
            this.lblStock1GrossProfit.TabIndex = 4;
            this.lblStock1GrossProfit.Text = "Profit: ";
            // 
            // lblStock1TransFee
            // 
            this.lblStock1TransFee.AutoSize = true;
            this.lblStock1TransFee.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock1TransFee.Location = new System.Drawing.Point(523, 170);
            this.lblStock1TransFee.Name = "lblStock1TransFee";
            this.lblStock1TransFee.Size = new System.Drawing.Size(86, 29);
            this.lblStock1TransFee.TabIndex = 5;
            this.lblStock1TransFee.Text = "Fees :";
            // 
            // lblTotalGrossValue
            // 
            this.lblTotalGrossValue.AutoSize = true;
            this.lblTotalGrossValue.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGrossValue.Location = new System.Drawing.Point(62, 99);
            this.lblTotalGrossValue.Name = "lblTotalGrossValue";
            this.lblTotalGrossValue.Size = new System.Drawing.Size(0, 29);
            this.lblTotalGrossValue.TabIndex = 22;
            // 
            // lblInvestmentBudget
            // 
            this.lblInvestmentBudget.AutoSize = true;
            this.lblInvestmentBudget.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInvestmentBudget.Location = new System.Drawing.Point(19, 29);
            this.lblInvestmentBudget.Name = "lblInvestmentBudget";
            this.lblInvestmentBudget.Size = new System.Drawing.Size(265, 32);
            this.lblInvestmentBudget.TabIndex = 27;
            this.lblInvestmentBudget.Text = "Investment Budget";
            // 
            // lblDollar
            // 
            this.lblDollar.AutoSize = true;
            this.lblDollar.BackColor = System.Drawing.Color.Transparent;
            this.lblDollar.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDollar.Location = new System.Drawing.Point(19, 75);
            this.lblDollar.Name = "lblDollar";
            this.lblDollar.Size = new System.Drawing.Size(31, 32);
            this.lblDollar.TabIndex = 28;
            this.lblDollar.Text = "$";
            // 
            // lblStock1
            // 
            this.lblStock1.AutoSize = true;
            this.lblStock1.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock1.Location = new System.Drawing.Point(509, 49);
            this.lblStock1.Name = "lblStock1";
            this.lblStock1.Size = new System.Drawing.Size(110, 32);
            this.lblStock1.TabIndex = 29;
            this.lblStock1.Text = "Stock 1";
            // 
            // lblStock2
            // 
            this.lblStock2.AutoSize = true;
            this.lblStock2.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock2.Location = new System.Drawing.Point(797, 131);
            this.lblStock2.Name = "lblStock2";
            this.lblStock2.Size = new System.Drawing.Size(110, 32);
            this.lblStock2.TabIndex = 34;
            this.lblStock2.Text = "Stock 2";
            // 
            // lblStock2TransFee
            // 
            this.lblStock2TransFee.AutoSize = true;
            this.lblStock2TransFee.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock2TransFee.Location = new System.Drawing.Point(811, 252);
            this.lblStock2TransFee.Name = "lblStock2TransFee";
            this.lblStock2TransFee.Size = new System.Drawing.Size(94, 29);
            this.lblStock2TransFee.TabIndex = 33;
            this.lblStock2TransFee.Text = "Fees : ";
            // 
            // lblStock2GrossProfit
            // 
            this.lblStock2GrossProfit.AutoSize = true;
            this.lblStock2GrossProfit.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock2GrossProfit.Location = new System.Drawing.Point(811, 213);
            this.lblStock2GrossProfit.Name = "lblStock2GrossProfit";
            this.lblStock2GrossProfit.Size = new System.Drawing.Size(94, 29);
            this.lblStock2GrossProfit.TabIndex = 32;
            this.lblStock2GrossProfit.Text = "Profit: ";
            // 
            // lblStock2Name
            // 
            this.lblStock2Name.AutoSize = true;
            this.lblStock2Name.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock2Name.Location = new System.Drawing.Point(811, 175);
            this.lblStock2Name.Name = "lblStock2Name";
            this.lblStock2Name.Size = new System.Drawing.Size(183, 29);
            this.lblStock2Name.TabIndex = 31;
            this.lblStock2Name.Text = "Entry Needed!";
            // 
            // btnStock2
            // 
            this.btnStock2.Enabled = false;
            this.btnStock2.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock2.Location = new System.Drawing.Point(913, 129);
            this.btnStock2.Name = "btnStock2";
            this.btnStock2.Size = new System.Drawing.Size(134, 39);
            this.btnStock2.TabIndex = 30;
            this.btnStock2.Text = "Update";
            this.btnStock2.UseVisualStyleBackColor = true;
            this.btnStock2.Click += new System.EventHandler(this.OpenStockInput);
            // 
            // lblStock3
            // 
            this.lblStock3.AutoSize = true;
            this.lblStock3.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock3.Location = new System.Drawing.Point(509, 248);
            this.lblStock3.Name = "lblStock3";
            this.lblStock3.Size = new System.Drawing.Size(110, 32);
            this.lblStock3.TabIndex = 39;
            this.lblStock3.Text = "Stock 3";
            // 
            // lblStock3TransFee
            // 
            this.lblStock3TransFee.AutoSize = true;
            this.lblStock3TransFee.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock3TransFee.Location = new System.Drawing.Point(523, 369);
            this.lblStock3TransFee.Name = "lblStock3TransFee";
            this.lblStock3TransFee.Size = new System.Drawing.Size(94, 29);
            this.lblStock3TransFee.TabIndex = 38;
            this.lblStock3TransFee.Text = "Fees : ";
            // 
            // lblStock3GrossProfit
            // 
            this.lblStock3GrossProfit.AutoSize = true;
            this.lblStock3GrossProfit.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock3GrossProfit.Location = new System.Drawing.Point(523, 330);
            this.lblStock3GrossProfit.Name = "lblStock3GrossProfit";
            this.lblStock3GrossProfit.Size = new System.Drawing.Size(94, 29);
            this.lblStock3GrossProfit.TabIndex = 37;
            this.lblStock3GrossProfit.Text = "Profit: ";
            // 
            // lblStock3Name
            // 
            this.lblStock3Name.AutoSize = true;
            this.lblStock3Name.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock3Name.Location = new System.Drawing.Point(523, 292);
            this.lblStock3Name.Name = "lblStock3Name";
            this.lblStock3Name.Size = new System.Drawing.Size(183, 29);
            this.lblStock3Name.TabIndex = 36;
            this.lblStock3Name.Text = "Entry Needed!";
            // 
            // btnStock3
            // 
            this.btnStock3.Enabled = false;
            this.btnStock3.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock3.Location = new System.Drawing.Point(625, 246);
            this.btnStock3.Name = "btnStock3";
            this.btnStock3.Size = new System.Drawing.Size(134, 39);
            this.btnStock3.TabIndex = 35;
            this.btnStock3.Text = "Update";
            this.btnStock3.UseVisualStyleBackColor = true;
            this.btnStock3.Click += new System.EventHandler(this.OpenStockInput);
            // 
            // lblStock4
            // 
            this.lblStock4.AutoSize = true;
            this.lblStock4.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock4.Location = new System.Drawing.Point(797, 369);
            this.lblStock4.Name = "lblStock4";
            this.lblStock4.Size = new System.Drawing.Size(110, 32);
            this.lblStock4.TabIndex = 44;
            this.lblStock4.Text = "Stock 4";
            // 
            // lblStock4TransFee
            // 
            this.lblStock4TransFee.AutoSize = true;
            this.lblStock4TransFee.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock4TransFee.Location = new System.Drawing.Point(811, 490);
            this.lblStock4TransFee.Name = "lblStock4TransFee";
            this.lblStock4TransFee.Size = new System.Drawing.Size(94, 29);
            this.lblStock4TransFee.TabIndex = 43;
            this.lblStock4TransFee.Text = "Fees : ";
            // 
            // lblStock4GrossProfit
            // 
            this.lblStock4GrossProfit.AutoSize = true;
            this.lblStock4GrossProfit.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock4GrossProfit.Location = new System.Drawing.Point(811, 451);
            this.lblStock4GrossProfit.Name = "lblStock4GrossProfit";
            this.lblStock4GrossProfit.Size = new System.Drawing.Size(94, 29);
            this.lblStock4GrossProfit.TabIndex = 42;
            this.lblStock4GrossProfit.Text = "Profit: ";
            // 
            // lblStock4Name
            // 
            this.lblStock4Name.AutoSize = true;
            this.lblStock4Name.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock4Name.Location = new System.Drawing.Point(811, 413);
            this.lblStock4Name.Name = "lblStock4Name";
            this.lblStock4Name.Size = new System.Drawing.Size(183, 29);
            this.lblStock4Name.TabIndex = 41;
            this.lblStock4Name.Text = "Entry Needed!";
            // 
            // btnStock4
            // 
            this.btnStock4.Enabled = false;
            this.btnStock4.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock4.Location = new System.Drawing.Point(913, 367);
            this.btnStock4.Name = "btnStock4";
            this.btnStock4.Size = new System.Drawing.Size(134, 39);
            this.btnStock4.TabIndex = 40;
            this.btnStock4.Text = "Update";
            this.btnStock4.UseVisualStyleBackColor = true;
            this.btnStock4.Click += new System.EventHandler(this.OpenStockInput);
            // 
            // lblStock5
            // 
            this.lblStock5.AutoSize = true;
            this.lblStock5.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock5.Location = new System.Drawing.Point(509, 454);
            this.lblStock5.Name = "lblStock5";
            this.lblStock5.Size = new System.Drawing.Size(110, 32);
            this.lblStock5.TabIndex = 49;
            this.lblStock5.Text = "Stock 5";
            // 
            // lblStock5TransFee
            // 
            this.lblStock5TransFee.AutoSize = true;
            this.lblStock5TransFee.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock5TransFee.Location = new System.Drawing.Point(523, 575);
            this.lblStock5TransFee.Name = "lblStock5TransFee";
            this.lblStock5TransFee.Size = new System.Drawing.Size(94, 29);
            this.lblStock5TransFee.TabIndex = 48;
            this.lblStock5TransFee.Text = "Fees : ";
            // 
            // lblStock5GrossProfit
            // 
            this.lblStock5GrossProfit.AutoSize = true;
            this.lblStock5GrossProfit.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock5GrossProfit.Location = new System.Drawing.Point(523, 536);
            this.lblStock5GrossProfit.Name = "lblStock5GrossProfit";
            this.lblStock5GrossProfit.Size = new System.Drawing.Size(86, 29);
            this.lblStock5GrossProfit.TabIndex = 47;
            this.lblStock5GrossProfit.Text = "Profit:";
            // 
            // lblStock5Name
            // 
            this.lblStock5Name.AutoSize = true;
            this.lblStock5Name.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStock5Name.Location = new System.Drawing.Point(523, 498);
            this.lblStock5Name.Name = "lblStock5Name";
            this.lblStock5Name.Size = new System.Drawing.Size(183, 29);
            this.lblStock5Name.TabIndex = 46;
            this.lblStock5Name.Text = "Entry Needed!";
            // 
            // btnStock5
            // 
            this.btnStock5.Enabled = false;
            this.btnStock5.Font = new System.Drawing.Font("Rockwell", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStock5.Location = new System.Drawing.Point(625, 452);
            this.btnStock5.Name = "btnStock5";
            this.btnStock5.Size = new System.Drawing.Size(134, 39);
            this.btnStock5.TabIndex = 45;
            this.btnStock5.Text = "Update";
            this.btnStock5.UseVisualStyleBackColor = true;
            this.btnStock5.Click += new System.EventHandler(this.OpenStockInput);
            // 
            // lblTotalGross
            // 
            this.lblTotalGross.AutoSize = true;
            this.lblTotalGross.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalGross.Location = new System.Drawing.Point(22, 53);
            this.lblTotalGross.Name = "lblTotalGross";
            this.lblTotalGross.Size = new System.Drawing.Size(251, 32);
            this.lblTotalGross.TabIndex = 50;
            this.lblTotalGross.Text = "Total Gross Profit:";
            // 
            // lblTotalTransFee
            // 
            this.lblTotalTransFee.AutoSize = true;
            this.lblTotalTransFee.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTransFee.Location = new System.Drawing.Point(22, 142);
            this.lblTotalTransFee.Name = "lblTotalTransFee";
            this.lblTotalTransFee.Size = new System.Drawing.Size(320, 32);
            this.lblTotalTransFee.TabIndex = 52;
            this.lblTotalTransFee.Text = "Total Transaction Fees:";
            // 
            // lblTotalFeesValue
            // 
            this.lblTotalFeesValue.AutoSize = true;
            this.lblTotalFeesValue.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalFeesValue.Location = new System.Drawing.Point(62, 188);
            this.lblTotalFeesValue.Name = "lblTotalFeesValue";
            this.lblTotalFeesValue.Size = new System.Drawing.Size(0, 29);
            this.lblTotalFeesValue.TabIndex = 51;
            // 
            // lblNetProfit
            // 
            this.lblNetProfit.AutoSize = true;
            this.lblNetProfit.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetProfit.Location = new System.Drawing.Point(22, 320);
            this.lblNetProfit.Name = "lblNetProfit";
            this.lblNetProfit.Size = new System.Drawing.Size(147, 32);
            this.lblNetProfit.TabIndex = 56;
            this.lblNetProfit.Text = "Net Profit:";
            // 
            // lblNetProfitValue
            // 
            this.lblNetProfitValue.AutoSize = true;
            this.lblNetProfitValue.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNetProfitValue.Location = new System.Drawing.Point(62, 366);
            this.lblNetProfitValue.Name = "lblNetProfitValue";
            this.lblNetProfitValue.Size = new System.Drawing.Size(0, 29);
            this.lblNetProfitValue.TabIndex = 55;
            // 
            // lblTotalTax
            // 
            this.lblTotalTax.AutoSize = true;
            this.lblTotalTax.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalTax.Location = new System.Drawing.Point(22, 231);
            this.lblTotalTax.Name = "lblTotalTax";
            this.lblTotalTax.Size = new System.Drawing.Size(189, 32);
            this.lblTotalTax.TabIndex = 54;
            this.lblTotalTax.Text = "Tax on Profit:";
            // 
            // lblTaxValue
            // 
            this.lblTaxValue.AutoSize = true;
            this.lblTaxValue.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTaxValue.Location = new System.Drawing.Point(62, 277);
            this.lblTaxValue.Name = "lblTaxValue";
            this.lblTaxValue.Size = new System.Drawing.Size(0, 29);
            this.lblTaxValue.TabIndex = 53;
            // 
            // lblNewBudget
            // 
            this.lblNewBudget.AutoSize = true;
            this.lblNewBudget.Font = new System.Drawing.Font("Rockwell", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewBudget.Location = new System.Drawing.Point(22, 409);
            this.lblNewBudget.Name = "lblNewBudget";
            this.lblNewBudget.Size = new System.Drawing.Size(184, 32);
            this.lblNewBudget.TabIndex = 58;
            this.lblNewBudget.Text = "New Budget:";
            // 
            // lblNewBudgetValue
            // 
            this.lblNewBudgetValue.AutoSize = true;
            this.lblNewBudgetValue.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewBudgetValue.Location = new System.Drawing.Point(62, 455);
            this.lblNewBudgetValue.Name = "lblNewBudgetValue";
            this.lblNewBudgetValue.Size = new System.Drawing.Size(0, 29);
            this.lblNewBudgetValue.TabIndex = 57;
            // 
            // grpOutput
            // 
            this.grpOutput.BackColor = System.Drawing.Color.Ivory;
            this.grpOutput.Controls.Add(this.lblTotalGross);
            this.grpOutput.Controls.Add(this.lblNewBudget);
            this.grpOutput.Controls.Add(this.lblTotalGrossValue);
            this.grpOutput.Controls.Add(this.lblNewBudgetValue);
            this.grpOutput.Controls.Add(this.lblTotalFeesValue);
            this.grpOutput.Controls.Add(this.lblNetProfit);
            this.grpOutput.Controls.Add(this.lblTotalTransFee);
            this.grpOutput.Controls.Add(this.lblNetProfitValue);
            this.grpOutput.Controls.Add(this.lblTaxValue);
            this.grpOutput.Controls.Add(this.lblTotalTax);
            this.grpOutput.Font = new System.Drawing.Font("Rockwell", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpOutput.Location = new System.Drawing.Point(25, 130);
            this.grpOutput.Name = "grpOutput";
            this.grpOutput.Size = new System.Drawing.Size(447, 500);
            this.grpOutput.TabIndex = 59;
            this.grpOutput.TabStop = false;
            this.grpOutput.Text = "Results";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.ClientSize = new System.Drawing.Size(1076, 648);
            this.Controls.Add(this.grpOutput);
            this.Controls.Add(this.lblStock5);
            this.Controls.Add(this.lblStock5TransFee);
            this.Controls.Add(this.lblStock5GrossProfit);
            this.Controls.Add(this.lblStock5Name);
            this.Controls.Add(this.btnStock5);
            this.Controls.Add(this.lblStock4);
            this.Controls.Add(this.lblStock4TransFee);
            this.Controls.Add(this.lblStock4GrossProfit);
            this.Controls.Add(this.lblStock4Name);
            this.Controls.Add(this.btnStock4);
            this.Controls.Add(this.lblStock3);
            this.Controls.Add(this.lblStock3TransFee);
            this.Controls.Add(this.lblStock3GrossProfit);
            this.Controls.Add(this.lblStock3Name);
            this.Controls.Add(this.btnStock3);
            this.Controls.Add(this.lblStock2);
            this.Controls.Add(this.lblStock2TransFee);
            this.Controls.Add(this.lblStock2GrossProfit);
            this.Controls.Add(this.lblStock2Name);
            this.Controls.Add(this.btnStock2);
            this.Controls.Add(this.lblStock1);
            this.Controls.Add(this.lblDollar);
            this.Controls.Add(this.lblInvestmentBudget);
            this.Controls.Add(this.lblStock1TransFee);
            this.Controls.Add(this.lblStock1GrossProfit);
            this.Controls.Add(this.lblStock1Name);
            this.Controls.Add(this.btnStock1);
            this.Controls.Add(this.btnUpdateBudget);
            this.Controls.Add(this.txtInvestmentBudget);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock Checker";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.grpOutput.ResumeLayout(false);
            this.grpOutput.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInvestmentBudget;
        private System.Windows.Forms.Button btnUpdateBudget;
        private System.Windows.Forms.Button btnStock1;
        private System.Windows.Forms.Label lblStock1Name;
        private System.Windows.Forms.Label lblStock1GrossProfit;
        private System.Windows.Forms.Label lblStock1TransFee;
        private System.Windows.Forms.Label lblTotalGrossValue;
        private System.Windows.Forms.Label lblInvestmentBudget;
        private System.Windows.Forms.Label lblDollar;
        private System.Windows.Forms.Label lblStock1;
        private System.Windows.Forms.Label lblStock2;
        private System.Windows.Forms.Label lblStock2TransFee;
        private System.Windows.Forms.Label lblStock2GrossProfit;
        private System.Windows.Forms.Label lblStock2Name;
        private System.Windows.Forms.Button btnStock2;
        private System.Windows.Forms.Label lblStock3;
        private System.Windows.Forms.Label lblStock3TransFee;
        private System.Windows.Forms.Label lblStock3GrossProfit;
        private System.Windows.Forms.Label lblStock3Name;
        private System.Windows.Forms.Button btnStock3;
        private System.Windows.Forms.Label lblStock4;
        private System.Windows.Forms.Label lblStock4TransFee;
        private System.Windows.Forms.Label lblStock4GrossProfit;
        private System.Windows.Forms.Label lblStock4Name;
        private System.Windows.Forms.Button btnStock4;
        private System.Windows.Forms.Label lblStock5;
        private System.Windows.Forms.Label lblStock5TransFee;
        private System.Windows.Forms.Label lblStock5GrossProfit;
        private System.Windows.Forms.Label lblStock5Name;
        private System.Windows.Forms.Button btnStock5;
        private System.Windows.Forms.Label lblTotalGross;
        private System.Windows.Forms.Label lblTotalTransFee;
        private System.Windows.Forms.Label lblTotalFeesValue;
        private System.Windows.Forms.Label lblNetProfit;
        private System.Windows.Forms.Label lblNetProfitValue;
        private System.Windows.Forms.Label lblTotalTax;
        private System.Windows.Forms.Label lblTaxValue;
        private System.Windows.Forms.Label lblNewBudget;
        private System.Windows.Forms.Label lblNewBudgetValue;
        private System.Windows.Forms.GroupBox grpOutput;
    }
}

