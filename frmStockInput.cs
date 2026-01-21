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
        #region globalVariables
        decimal _investmentBudget = 0.0M;
        int       _stockIndex = 0;
        string[]  _stockName;
        decimal[] _stockPurchaseCost;
        decimal[] _stockFees;
        decimal[] _stockGrossProfit;
        #endregion

        public frmStockInput(decimal investmentBudget, int stock, string[] stockName, decimal[] stockPurchaseCost, decimal[] stockFees, decimal[] stockGrossProfit) // peramerized constructor
        {
            InitializeComponent();
            _investmentBudget = investmentBudget;
            _stockIndex = stock;
            _stockName = stockName;
            _stockPurchaseCost = stockPurchaseCost;
            _stockFees = stockFees;
            _stockGrossProfit = stockGrossProfit;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            string strStockPurchaseCost = txtPurchasePrice.Text;
            string strStocksBought = txtSharesPurchased.Text;
            string strStockSoldCost = txtSellingPrice.Text;

            if (IsNumeric(strStockPurchaseCost,"Purchase cost is not a number, enter a different value") == -1.0M)
            {
                // fix whatever this is
            }
            
        }

        private decimal IsNumeric(string checkString, string errorMessage)
        {
            bool loop = true;
            do
            {
                try
                {
                    loop = false;
                    return Convert.ToInt32(checkString);
                }
                catch
                {
                    MessageBox.Show(errorMessage);
                    return -1.0M;
                }    
            }
            while (loop);
            
        }
    }
}
