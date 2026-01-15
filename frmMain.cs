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
        public frmMain()
        {
            InitializeComponent();
        }

        internal decimal investmentBudget = 0.0M;
        public int stock = 0;

        internal string[] stockName = new string[5];
        internal decimal[] stockPurchaseCost = new decimal[5];
        internal decimal[] stockFees = new decimal[5];
        internal decimal[] stockGrossCost = new decimal[5];

        private void btnUpdateBudget_Click(object sender, EventArgs e)
        {
            try
            {
                investmentBudget = Convert.ToInt32(txtInvestmentBudget.Text);

                btnStock1.Enabled = true;
                btnStock2.Enabled = true;
                btnStock3.Enabled = true;
                btnStock4.Enabled = true;
                btnStock5.Enabled = true;
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
            }  
        }

        private void OpenStockInput(object sender, EventArgs e)
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
            }

            Form formInput = new frmStockInput();
            formInput.Show();
         }

        internal bool CheckTotalPrice() // returns false if the value exceeds the investment budget
        {
            decimal totalPurchase = stockPurchaseCost.Sum();

            if (totalPurchase >= investmentBudget)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    } // important class stuff
}