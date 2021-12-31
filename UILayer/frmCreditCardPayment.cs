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
    public partial class frmCreditCardPayment : Form
    {
        private string _phoneNum;   

        public frmCreditCardPayment()
        {
            InitializeComponent();


        }

        public frmCreditCardPayment(string phoneNum, decimal cost)
        {
            InitializeComponent();
            _phoneNum = phoneNum;
            Member member = new Member(phoneNum);
            MemberDTO memberDTO = member.Select();

            lblMemberName.Text += " " + memberDTO.Name;
            Console.WriteLine("The points for " + memberDTO.Name + " is: " + memberDTO.Points);
            lblPoints.Text += " " + Convert.ToString(memberDTO.Points);
            lblCost.Text += " " + Convert.ToString(cost);

            MemberCreditCard mCreditCards = new MemberCreditCard(phoneNum);
            List<CreditCardDTO> creditCardList = mCreditCards.SelectAll();

            creditCardList.ForEach(entry => cbMemberCreditCard.Items.Add(entry.CreditCardCompany + " " + entry.CreditCardNumber));
        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            bool isMember = _phoneNum.Length > 0 ? true : false;

            if (isMember)
            {
                Member member = new Member(_phoneNum);
                int points = PointsCalculator.PointsGained(Convert.ToDecimal(lblCost.Text));
                member.AddPoints(points);
            }
            else
                MessageBox.Show("Customer is not a member");
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
