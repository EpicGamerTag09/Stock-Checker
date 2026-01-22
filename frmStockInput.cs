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

        #region Click Events

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string errorMessage = "The following errors must be corrected before the stock is entered:";
            bool goodData = true;


            decimal purchaseCost = CheckPurchase(); // checks if the purchase price is a positive number
            if (purchaseCost == -1) 
            {
                errorMessage += "\n    - Purchase price must be a positive number";
                goodData = false;
            }

            decimal sellPrice = CheckSellPrice(); // checks if the selling price is a positive number
            if (sellPrice == -1)
            {
                errorMessage += "\n    - Selling price must be a positive number";
                goodData = false;
            }

            int sharesPurchased = CheckSharesPurchased(); // checks if the shares purchased is a positive number
            if (sharesPurchased == -1)
            {
                errorMessage += "\n    - Shares purchased must be a positive number";
                goodData = false;
            }

            if (goodData)
            {
                decimal purchaseTransaction = purchaseCost * sharesPurchased;
                decimal purchaseFee = purchaseTransaction * FEE_RATE;
                if (CheckOverdraft(purchaseTransaction, purchaseFee))
                {
                    errorMessage += "\n    - Total purchase transaction cannot exceed investment budget";
                    goodData = false;
                }
            }

            if (txtName.Text.Length == 0)
            {
                goodData = false;
                errorMessage += "\n    - A name for the stock must be entered";
            }// End if

            if (goodData)
            {
                
            }
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
            catch (Exception)
            {
                return -1;
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
            catch (Exception)
            {
                return -1;
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
            catch (Exception)
            {
                return -1;
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
