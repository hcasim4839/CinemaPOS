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
    public partial class frmMemberConfirmation : Form
    {
        public frmMemberConfirmation()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            frmPurchaseOptions frmObj = new frmPurchaseOptions();
            this.Hide();
            frmObj.ShowDialog();
            this.Show();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            frmPurchaseOptions frmObj = new frmPurchaseOptions();
            this.Hide();
            frmObj.ShowDialog();
            this.Show();
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            frmMemberRegist frmObj = new frmMemberRegist();
            this.Hide();
            frmObj.ShowDialog();
            this.Show();
        }
    }
}
