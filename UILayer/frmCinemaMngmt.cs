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
    public partial class frmCinemaMngmt : Form
    {
        public frmCinemaMngmt()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            frmTickets formObj = new frmTickets();
            this.Hide();
            formObj.ShowDialog();
            this.Show();
        }

        private void btnMembership_Click(object sender, EventArgs e)
        {
            frmMembership formObj = new frmMembership();
            this.Hide();
            formObj.ShowDialog();
            this.Show();
        }

        private void btnPurchases_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMemberConfirmation frmObj = new frmMemberConfirmation();
            frmObj.ShowDialog();
            this.Show();
        }
    }
}
