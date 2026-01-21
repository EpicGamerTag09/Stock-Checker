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

        }
    }// End of frmStockInput
}
