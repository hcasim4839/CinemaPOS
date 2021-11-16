using BOLayer;
using DALayer;
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
            this.Hide();
            frmPurchaseOptions frmObj = new frmPurchaseOptions();
            frmObj.ShowDialog();
            
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            this.Hide();
            string phoneNum = txtPhoneNum.Text;


            frmPurchaseOptions frmObj = new frmPurchaseOptions(phoneNum);

            
            frmObj.ShowDialog();
            
        }

        private void btnRegist_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmMemberRegist frmObj = new frmMemberRegist();
            
            frmObj.ShowDialog();
          
        }
    }
}
