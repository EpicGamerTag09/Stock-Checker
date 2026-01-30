using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Stock_Checker
{
    public partial class frmStockInput : Form
    {
        #region Data
        decimal     budget;
        int         stockNumber;
        string[]    savedNames;
        decimal[]   savedCosts;
        decimal[]   savedPurchaseFees;
        decimal[]   savedSellFees;
        decimal[]   savedProfits;

        const decimal FEE_RATE = 0.02M;
        #endregion

        #region Constructor

        public frmStockInput(decimal _budget, int _stock, string[] _names, decimal[] _costs, decimal[] _purFees, decimal[] _sellFees, decimal[] _grossProfits)// Parameterized constructor for frmStockInput
        {
            InitializeComponent();
            budget = _budget;
            stockNumber = _stock;
            savedNames = _names;
            savedCosts = _costs;
            savedPurchaseFees = _purFees;
            savedSellFees = _sellFees;
            savedProfits = _grossProfits;
        }
        #endregion

        #region Form Events

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string errorMessage = "The following errors must be corrected before the stock is entered:";
            bool goodData = true;

            if (txtName.Text.Length == 0)
            {
                goodData = false;
                errorMessage += "\n    - A name for the stock must be entered";
            }// End if

            decimal purchaseCost = CheckPurchase(); // checks if the purchase price is a positive number
            if (purchaseCost == -1)
            {
                errorMessage += "\n    - Purchase price must be a positive number";
                goodData = false;
            }
            else if (purchaseCost == -2)
            {
                errorMessage += "\n    - Purchase price must be a smaller number";
                goodData = false;
            }


                decimal sellPrice = CheckSellPrice(); // checks if the selling price is a positive number
            if (sellPrice == -1)
            {
                errorMessage += "\n    - Selling price must be a positive number";
                goodData = false;
            }
            else if (sellPrice == -2)
            {
                errorMessage += "\n    - Sell price must be a smaller number";
                goodData = false;
            }

            int sharesPurchased = CheckSharesPurchased(); // checks if the shares purchased is a positive number
            if (sharesPurchased == -1)
            {
                errorMessage += "\n    - Shares purchased must be a positive number";
                goodData = false;
            }
            else if (sharesPurchased == -2)
            {
                errorMessage += "\n    - Shares purchased must be a smaller number";
                goodData = false;
            }

            decimal purchaseTransaction = 0.0M;
            decimal purchaseFee = 0.0M;
            if (goodData)
            {
                purchaseTransaction = purchaseCost * sharesPurchased;
                purchaseFee = purchaseTransaction * FEE_RATE;
                if (CheckOverdraft(purchaseTransaction, purchaseFee))
                {
                    errorMessage += "\n    - Total purchase transaction cannot exceed investment budget";
                    goodData = false;
                }
            }

            // test results
            if (goodData)
            {
                decimal sellTransaction = sellPrice * sharesPurchased;
                decimal grossProfit = sellTransaction - purchaseTransaction;
                decimal sellFee = 0M;
                if (grossProfit > 0)
                {
                    sellFee = grossProfit * FEE_RATE;
                }

                lblPurchaseCostValue.Text = purchaseTransaction.ToString("C");
                lblGrossProfitValue.Text = grossProfit.ToString("C");
                lblSellFeeValue.Text = sellFee.ToString("C");
                lblPurFeeValue.Text = purchaseFee.ToString("C");

                savedNames[stockNumber] = txtName.Text;
                savedCosts[stockNumber] = purchaseTransaction;
                savedPurchaseFees[stockNumber] = purchaseFee;
                savedSellFees[stockNumber] = sellFee;
                savedProfits[stockNumber] = grossProfit;
            }
            else
            {
                MessageBox.Show(errorMessage, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUpdateStock_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStockInput_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMain newForm = new frmMain(budget, savedNames, savedCosts, savedPurchaseFees, savedSellFees, savedProfits);
            newForm.Show();
        }
        #endregion

        #region Input Tests

        private decimal CheckPurchase()
        {
            try
            {
                decimal _decPurchaseCost = Convert.ToDecimal(txtPurchasePrice.Text);
                if (_decPurchaseCost < 0)
                {
                    return -1;
                }
                else
                {
                    return _decPurchaseCost;
                }
            }
            catch (FormatException)
            {
                return -1;
            }
            catch (OverflowException)
            {
                return -2;
            }
        }

        private decimal CheckSellPrice()
        {
            try
            {
                decimal _decSellingPrice = Convert.ToDecimal(txtSellingPrice.Text);
                if (_decSellingPrice < 0)
                {
                    return -1;
                }
                else
                {
                    return _decSellingPrice;
                }
            }
            catch (InvalidCastException)
            {
                return -1;
            }
            catch (OverflowException)
            {
                return -2;
            }
        }

        private int CheckSharesPurchased()
        {
            try
            {
                int _intSharesPurchased = Convert.ToInt32(txtSharesPurchased.Text);
                if (_intSharesPurchased < 0)
                {
                    return -1;
                }
                else
                {
                    return _intSharesPurchased;
                }
            }
            catch (InvalidCastException)
            {
                return -1;
            }
            catch (OverflowException)
            {
                return -2;
            }
        }

        private bool CheckOverdraft(decimal transaction, decimal purFee)
        {
            decimal totalTransaction = savedCosts.Sum() + savedPurchaseFees.Sum() - savedCosts[stockNumber] - savedPurchaseFees[stockNumber] + transaction + purFee;
            if (budget < totalTransaction)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion

    }// End of frmStockInput
}