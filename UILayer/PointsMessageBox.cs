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
    public partial class PointsMessageBox : Form
    {
        private string _phoneNum;
        private decimal _cost;
        public PointsMessageBox(string phoneNum, decimal cost)
        {
            InitializeComponent();
            _phoneNum = phoneNum;
            _cost = cost;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            frmCashPayment frmObj = new frmCashPayment(_cost, _phoneNum);
            frmObj.ShowDialog();
            this.Close();
        }

        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            frmCreditCardPayment frmObj = new frmCreditCardPayment(_phoneNum, _cost);
            frmObj.ShowDialog();
            this.Close();
        }

        private void btnPoints_Click(object sender, EventArgs e)
        {
            frmPointsPayment frmObj = new frmPointsPayment(_phoneNum, _cost);
            frmObj.ShowDialog();
            this.Close();
        }
    }
}
