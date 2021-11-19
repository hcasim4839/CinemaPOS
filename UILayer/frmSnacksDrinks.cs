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
    public partial class frmSnacksDrinks : Form
    {
        string[] categories = new string[] { "Limited", "Non-limited"};
        public frmSnacksDrinks(string phoneNum)
        {
            InitializeComponent();
            Member member = new Member(phoneNum);
            MemberDTO memberDTO = member.Select();

            lblName.Text = memberDTO.Name;
            lblPoints.Text = memberDTO.Points;

            cmbDrinks.Items.AddRange(categories);
            cmbSnacks.Items.AddRange(categories);
            cmbDrinks.SelectedItem = categories[1];
            cmbSnacks.SelectedItem = categories[1];

            cmbDrinks.SelectedItem = categories[1];
            cmbSnacks.SelectedItem = categories[1];

            fillLstViewFood("Snacks", false);
            fillLstViewFood("Drinks", false);
        }

        private void lblPoints_Click(object sender, EventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void btnPayCash_Click(object sender, EventArgs e)
        {
            decimal totalCost = 0.00m;

            foreach (var currentItem in lstViewPaymentNeeded.Items)
            {

                string currentItemString = currentItem.ToString();
                int newEntryIndex = currentItemString.LastIndexOf("Price: ");
                newEntryIndex += 7;
                decimal ticketCost = Convert.ToDecimal(currentItemString.Substring(newEntryIndex));

                totalCost += ticketCost;
            }

            frmCashPayment frmObj = new frmCashPayment(totalCost);
            this.Hide();
            frmObj.ShowDialog();
            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSnacksEnter_Click(object sender, EventArgs e)
        {
            bool isLimited = cmbSnacks.SelectedIndex.Equals("Limited") ? true : false;
            fillLstViewFood("Snacks", isLimited);
        }
        private List<FoodDTO> fillLstViewFood(string category, bool isLimited)
        {

            Food foodObj = new Food(category, isLimited);
            List<FoodDTO> listOfFood = new List<FoodDTO>();

            listOfFood = foodObj.SelectAll();
            return listOfFood;
        }

        private void btnDrinksEnter_Click(object sender, EventArgs e)
        {
            bool isLimited = cmbSnacks.SelectedIndex.Equals("Limited") ? true : false;
            fillLstViewFood("Drinks", isLimited);
        }
    }
}
