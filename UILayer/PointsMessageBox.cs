
using BOLayer;
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
        private int _points;

        public PointsMessageBox(string phoneNum, decimal cost, int points)
        {
            
            InitializeComponent();
            
            
            _phoneNum = phoneNum;
            _cost = cost;
            _points = points;
            btnCancel.DialogResult = DialogResult.Cancel;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCash_Click(object sender, EventArgs e)
        {
            setDialogResult();
            removeMemberPoints();
            
            frmCashPayment frmObj = new frmCashPayment(_cost, _phoneNum);
            frmObj.ShowDialog();
            this.Close();
        }


        private void btnCreditCard_Click(object sender, EventArgs e)
        {
            setDialogResult();
            removeMemberPoints();
            
            frmCreditCardPayment frmObj = new frmCreditCardPayment(_phoneNum, _cost);
            frmObj.ShowDialog();
            this.Close();
        }

        private void setDialogResult()
        {
            this.DialogResult = DialogResult.OK;
        }

        private void removeMemberPoints()
        {
            Member member = new Member(_phoneNum);
            member.removePoints(_points);
        }
    }
}
