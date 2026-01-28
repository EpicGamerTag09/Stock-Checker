using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stock_Checker
{
    public partial class frmMain : Form
    {
        #region Data
        decimal investmentBudget;
        int stock;

        string[] stockName;
        decimal[] stockPurchaseCost;
        decimal[] stockPurchaseFees;
        decimal[] stockSellFees;
        decimal[] stockGrossProfit;

        const decimal TAX_RATE = 0.1M;
        #endregion

        #region Constructors
        
        public frmMain()// Default constructor for frmMain  
        {
            InitializeComponent();

            investmentBudget = 0.0M;

            stockName = new string[5] { "", "", "", "", "" };
            stockPurchaseCost = new decimal[5] { 0, 0, 0, 0, 0 };
            stockPurchaseFees = new decimal[5] { 0, 0, 0, 0, 0 };
            stockSellFees = new decimal[5] { 0, 0, 0, 0, 0 };
            stockGrossProfit = new decimal[5] { 0, 0, 0, 0, 0 };

            stock = -1;
        }

        public frmMain(decimal budget, string[] names, decimal[] purchase, decimal[] purFees, decimal[] sellFees,decimal[] profit)// Parameterized constructor for frmMain  
        {
            InitializeComponent();

            investmentBudget = budget;
            stockName = names;
            stockPurchaseCost = purchase;
            stockPurchaseFees = purFees;
            stockSellFees = sellFees;
            stockGrossProfit = profit;
            stock = -1;

            updateStock();
            calcOutput();
        }
        #endregion

        #region Form Events

        private void btnUpdateBudget_Click(object sender, EventArgs e)// Validates the investment budget  
        {
            try
            {
                investmentBudget = Convert.ToDecimal(txtInvestmentBudget.Text);

                if (CheckTotalPrice())
                {
                    btnStock1.Enabled = true;
                    btnStock2.Enabled = true;
                    btnStock3.Enabled = true;
                    btnStock4.Enabled = true;
                    btnStock5.Enabled = true;
                    calcOutput();
                }
                else
                {
                    MessageBox.Show("Investment Budget cannot be less than the total purchase cost.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    investmentBudget = 0;
                    btnStock1.Enabled = false;
                    btnStock2.Enabled = false;
                    btnStock3.Enabled = false;
                    btnStock4.Enabled = false;
                    btnStock5.Enabled = false;
                }// End if
            }
            catch (Exception)
            {
                MessageBox.Show("Investment Budget can only have numbers", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                investmentBudget = 0;
                btnStock1.Enabled = false;
                btnStock2.Enabled = false;
                btnStock3.Enabled = false;
                btnStock4.Enabled = false;
                btnStock5.Enabled = false;
            }// End try
        }

        private void OpenStockInput(object sender, EventArgs e)// Opens frmStockInput  
        {
            if (sender.Equals(btnStock1))
            {
                stock = 0;
            }
            else if (sender.Equals(btnStock2))
            {
                stock = 1;
            }
            else if (sender.Equals(btnStock3))
            {
                stock = 2;
            }
            else if (sender.Equals(btnStock4))
            {
                stock = 3;
            }
            else
            {
                stock = 4;
            }// End if

            Form formInput = new frmStockInput(investmentBudget, stock, stockName, stockPurchaseCost, stockPurchaseFees, stockSellFees,stockGrossProfit);
            formInput.Show();
            this.Close();
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (stock == -1)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Extra Functions

        private bool CheckTotalPrice()// Checks if the investment budget is less than the total purchase price  
        {
            decimal totalPurchase = stockPurchaseCost.Sum();

            if (totalPurchase > investmentBudget)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void updateStock()// Displays the info for each stock
        {
            txtInvestmentBudget.Text = investmentBudget.ToString();
            btnStock1.Enabled = true;
            btnStock2.Enabled = true;
            btnStock3.Enabled = true;
            btnStock4.Enabled = true;
            btnStock5.Enabled = true;

            if (stockName[0] != "")
            {
                // stock 1
                lblStock1Name.Text = stockName[0];
                lblStock1GrossProfit.Text = "Profit: " + stockGrossProfit[0].ToString("C");
                lblStock1TransFee.Text = "Fees: " + (stockSellFees[0] + stockPurchaseFees[0]).ToString("C");
            }

            if (stockName[1] != "")
            {
                // stock 2
                lblStock2Name.Text = stockName[1];
                lblStock2GrossProfit.Text = "Profit: " + stockGrossProfit[1].ToString("C");
                lblStock2TransFee.Text = "Fees: " + (stockSellFees[1] + stockPurchaseFees[1]).ToString("C");
            }

            if (stockName[2] != "")
            {
                // stock 3
                lblStock3Name.Text = stockName[2];
                lblStock3GrossProfit.Text = "Profit: " + stockGrossProfit[2].ToString("C");
                lblStock3TransFee.Text = "Fees: " + (stockSellFees[2] + stockPurchaseFees[2]).ToString("C");
            }

            if (stockName[3] != "")
            {
                // stock 4
                lblStock4Name.Text = stockName[3];
                lblStock4GrossProfit.Text = "Profit: " + stockGrossProfit[3].ToString("C");
                lblStock4TransFee.Text = "Fees: " + (stockSellFees[3] + stockPurchaseFees[3]).ToString("C");
            }

            if (stockName[4] != "")
            {
                // stock 5
                lblStock5Name.Text = stockName[4];
                lblStock5GrossProfit.Text = "Profit: " + stockGrossProfit[4].ToString("C");
                lblStock5TransFee.Text = "Fees: " + (stockSellFees[4] + stockPurchaseFees[4]).ToString("C");
            }
        }

        private void calcOutput()// Calculates and displays the output if all data has been provided
        {
            if (investmentBudget != 0 && stockName.Contains("") == false)
            {
                decimal grossTotal = stockGrossProfit.Sum();
                decimal feeTotal = stockPurchaseFees.Sum() + stockSellFees.Sum();
                decimal tax = grossTotal * TAX_RATE;
                decimal netProfit = grossTotal - feeTotal - tax;
                decimal newBudget = investmentBudget + netProfit;

                lblTotalGrossValue.Text = grossTotal.ToString("C");
                lblTotalFeesValue.Text = feeTotal.ToString("C");
                lblTaxValue.Text = tax.ToString("C");
                lblNetProfitValue.Text = netProfit.ToString("C");
                lblNewBudgetValue.Text = newBudget.ToString("C");
            }// End If
        }
        #endregion

    }// End of frmMain
}