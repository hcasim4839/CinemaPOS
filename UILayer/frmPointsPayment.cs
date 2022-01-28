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
        private decimal _cost;
        public frmPointsPayment(string phoneNum, decimal cost)
        {
            InitializeComponent();
            _cost = cost;
            

            lblTotalCost.Text += cost;
            Member member = new Member(phoneNum);
            _phoneNum = phoneNum;
            MemberDTO memberDTO = member.Select();
            lblMember.Text +=" " + memberDTO.Name;
            Console.WriteLine("The points for " + memberDTO.Name + " is: " + memberDTO.Points);
            lblPoints.Text += " " + Convert.ToString(memberDTO.Points);



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
            int points = (int)(Convert.ToDecimal(cmbDiscounts.SelectedItem.ToString()) * 100);        
            PointsMessageBox frmObj = new PointsMessageBox(_phoneNum, Convert.ToDecimal(lblCost.Text), points);

            this.Hide();
            frmObj.ShowDialog();

            
            Console.WriteLine("The data is from the pointsmessageBox is: " + frmObj.DialogResult);
            if (frmObj.DialogResult == DialogResult.OK)
            {
                this.Close();
            }
            else
                this.Show();
                

            

        }

        private void cmbDiscounts_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblUserPoints.Text = "";
            lblUserLeftoverPoints.Text = "";            
            lblCost.Text = "";


            Member member = new Member(_phoneNum);
            MemberDTO memberDTO = member.Select();
            int points = memberDTO.Points;

            Console.WriteLine(Convert.ToInt32(cmbDiscounts.SelectedItem));
            int pointsDeduction = Convert.ToInt32(cmbDiscounts.SelectedItem) * 100;
            lblUserPoints.Text = Convert.ToString(pointsDeduction);
            lblUserLeftoverPoints.Text =Convert.ToString((points - pointsDeduction));
            lblCost.Text = Convert.ToString(_cost - Convert.ToDecimal(cmbDiscounts.SelectedItem)); 

        }
    }
}
