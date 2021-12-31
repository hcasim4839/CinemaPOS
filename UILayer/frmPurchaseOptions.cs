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
    public partial class frmPurchaseOptions : Form
    {
        private string _phoneNum = "";

        public frmPurchaseOptions(string phoneNum)
        {
            InitializeComponent();
            _phoneNum = phoneNum;

            Member member = new Member(phoneNum);
            MemberDTO memberDTO = member.Select();

            lblName.Text = memberDTO.Name;
            lblPoints.Text = Convert.ToString(memberDTO.Points);
        }
        public frmPurchaseOptions()
        {
            InitializeComponent();
            lblMember.Text = "";
            lblName.Text = "";
            lblPoints.Text = "";

            
        }
        public frmPurchaseOptions(string name, string points)
        {
            InitializeComponent();
            lblName.Text = name;
            lblPoints.Text = "Points: " + points;
        }

        private void btnTickets_Click(object sender, EventArgs e)
        {
            bool isMember = _phoneNum.Length > 0 ? true : false;
            frmTickets frmObj;

            if (isMember)
            {
                frmObj = new frmTickets(_phoneNum);
                this.Hide();
                frmObj.ShowDialog();
            }
            else
            {
                frmObj = new frmTickets();
                this.Hide();
                frmObj.ShowDialog();
            }

            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            this.Close();
            
            
           
        }

        private void btnSnacksDrinks_Click(object sender, EventArgs e)
        {
            bool isMember = _phoneNum.Length > 0 ? true : false;
            frmSnacksDrinks frmObj;

            if (isMember)
            {
                frmObj = new frmSnacksDrinks(_phoneNum);
                this.Hide();
                frmObj.ShowDialog();
            }
            else
            {
                frmObj = new frmSnacksDrinks();
                this.Hide();
                frmObj.ShowDialog();
            }
            
            this.Show();
            
        }
    }
}
