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
    public partial class frmStockInput : Form
    {
        public frmStockInput()
        {
            InitializeComponent();
        }

        private void frmStockInput_Load(object sender, EventArgs e)
        {
             
        }

        public void hi()
        {
            txtName.Text = "Hello";
        }
    }
}
