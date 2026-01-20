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
        decimal[] stockFees;
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
            stockFees = new decimal[5] { 0, 0, 0, 0, 0 };
            stockGrossProfit = new decimal[5] { 0, 0, 0, 0, 0 };
        }

        public frmMain(decimal budget, string[] names, decimal[] purchase, decimal[] Fees, decimal[] profit, int updStock)// Parameterized constructor for frmMain  
        {
            InitializeComponent();

            investmentBudget = budget;
            stockName = names;
            stockPurchaseCost = purchase;
            stockFees = Fees;
            stockGrossProfit = profit;
            stock = updStock;

            updateStock();
            calcOutput();
        }
        #endregion

        #region On-Click Functions

        private void btnUpdateBudget_Click(object sender, EventArgs e)// Validates the investment budget  
        {
            try
            {
                investmentBudget = Convert.ToInt32(txtInvestmentBudget.Text);

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
                    MessageBox.Show("Investment Budget cannot be less than the total purchase cost.", "Input Error");
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
                MessageBox.Show("Investment Budget can only have numbers", "Input Error");
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

            Form formInput = new frmStockInput(investmentBudget, stock, stockName, stockPurchaseCost, stockFees, stockGrossProfit);
            formInput.Show();
            this.Close();
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

        private void updateStock()// Updates the stock info after input is provided
        {
            ref Label nameLabel = ref lblStock1Name;
            ref Label profitLabel = ref lblStock1GrossProfit;
            ref Label feeLabel = ref lblStock1TransFee;

            switch (stock) {
                case 1:
                    nameLabel = ref lblStock2Name;
                    profitLabel = ref lblStock2GrossProfit;
                    feeLabel = ref lblStock2TransFee;
                    break;
                case 2:
                    nameLabel = ref lblStock3Name;
                    profitLabel= ref lblStock3GrossProfit;
                    feeLabel = ref lblStock3TransFee;
                    break;
                case 3:
                    nameLabel = ref lblStock4Name;
                    profitLabel = ref lblStock4GrossProfit;
                    feeLabel = ref lblStock4TransFee;
                    break;
                case 4:
                    nameLabel = ref lblStock5Name;
                    profitLabel = ref lblStock5GrossProfit;
                    feeLabel = ref lblStock5TransFee;
                    break;
            }// End switch

            nameLabel.Text = stockName[stock];
            profitLabel.Text = "Profit: " + stockGrossProfit[stock].ToString("C");
            feeLabel.Text = "Fees:  " + stockFees[stock].ToString("C");
        }

        private void calcOutput()// Calculates and displays the output if all data has been provided
        {
            if (investmentBudget != 0 && stockName.Contains("") == false)
            {
                decimal grossTotal = stockGrossProfit.Sum();
                decimal feeTotal = stockFees.Sum();
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