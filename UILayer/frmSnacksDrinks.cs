using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UILayer
{
    public partial class frmSnacksDrinks : Form
    {
        public frmSnacksDrinks()
        {
            InitializeComponent();
        }

        private void lblPoints_Click(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void btnPayCash_Click(object sender, EventArgs e)
        {
            frmCashPayment frmObj = new frmCashPayment();
            this.Hide();
            frmObj.ShowDialog();
            this.Show();
        }
    }
}
