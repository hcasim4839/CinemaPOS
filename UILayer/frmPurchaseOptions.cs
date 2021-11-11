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
    public partial class frmPurchaseOptions : Form
    {
        public frmPurchaseOptions()
        {
            InitializeComponent();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            frmTickets frmObj = new frmTickets();
            this.Hide();
            frmObj.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
            
           
        }
    }
}
