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
    public partial class frmPointsPayment : Form
    {
        private string _phoneNum;
        public frmPointsPayment(decimal cost,string phoneNum)
        {
            InitializeComponent();
            Member member = new Member(_phoneNum);

            MemberDTO memberDTO = member.Select();
            lblMember.Text += " " + memberDTO.Name;
            lblPoints.Text = Convert.ToString(memberDTO.Points);



            initializePointsDiscounts(memberDTO.Points);

        }

        private void initializePointsDiscounts(int memberPoints)
        {
            List<decimal> listOfDiscounts = new List<decimal>();
            decimal maxAvailableDiscount = memberPoints / 100.00m;

            decimal maxDiscount = 1.00m;
            while(maxDiscount <= 5.00m)
            {
                listOfDiscounts.Add(maxDiscount);
                maxDiscount += 1.00m;
            }

            listOfDiscounts.ForEach(entry =>
            {
                if (entry < maxAvailableDiscount)
                    cmbDiscounts.Items.Add(entry);
            });
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnConfirmation_Click(object sender, EventArgs e)
        {
            

        }
    }
}
