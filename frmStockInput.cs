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
        decimal[]   savedFees;
        decimal[]   savedProfits;
        #endregion

        public frmStockInput(decimal _budget, int _stock, string[] _names, decimal[] _costs, decimal[] _fees, decimal[] _grossProfits)// Parameterized constructor for frmStockInput
        {
            InitializeComponent();
            budget = _budget;
            stockNumber = _stock;
            savedNames = _names;
            savedCosts = _costs;
            savedFees = _fees;
            savedProfits = _grossProfits;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string errorMessage = "The following errors must be corrected before the stock is entered:";
            bool goodData = true;


            decimal purchaseCost = CheckPurchase(txtPurchasePrice.Text); // checks if the purchase price is a positive number
            if (purchaseCost == -1) 
            {
                errorMessage += "\n    - Purchase price must be a positive number";
                goodData = false;
            }

            decimal sellPrice = CheckSellPrice(txtSellingPrice.Text); // checks if the selling price is a positive number
            if (sellPrice == -1)
            {
                errorMessage += "\n    - Selling price must be a positive number";
                goodData = false;
            }

            int sharesPurchased = CheckSharesPurchased(txtSharesPurchased.Text); // checks if the shares purchased is a positive number
            if (sharesPurchased == -1)
            {
                errorMessage += "\n    - Shares purchased must be a positive number";
                goodData = false;
            }

            if (txtName.Text.Length == 0)
            {
                goodData = false;
                errorMessage += "\n    - A name for the stock must be entered";
            }// End if

            if (goodData)
            {
                // Do math ( I ran out of time lol)
            }


        }
        private decimal CheckPurchase(string _purchaseCost)
        {
            try
            {
                decimal _decPurchaseCost = Convert.ToDecimal(_purchaseCost);
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

        private decimal CheckSellPrice(string _sellingCost)
        {
            try
            {
                decimal _decSellingPrice = Convert.ToDecimal(_sellingCost);
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

        private int CheckSharesPurchased(string _sharesPurchased)
        {
            try
            {
                int _intSharesPurchased = Convert.ToInt32(_sharesPurchased);
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
    }// End of frmStockInput
}
