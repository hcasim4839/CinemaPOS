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
        string[] categories = new string[] { "Limited", "Non-limited", "All"};
        public frmSnacksDrinks(string phoneNum)
        {
            InitializeComponent();
            Member member = new Member(phoneNum);
            MemberDTO memberDTO = member.Select();

            lblName.Text = memberDTO.Name;
            lblPoints.Text = Convert.ToString(memberDTO.Points);

            cmbDrinks.Items.AddRange(categories);
            cmbSnacks.Items.AddRange(categories);
            cmbDrinks.SelectedItem = categories[1];
            cmbSnacks.SelectedItem = categories[1];

            cmbDrinks.SelectedItem = categories[1];
            cmbSnacks.SelectedItem = categories[1];

            List<FoodDTO> snackList = fillLstViewFood("Snack", false);
            List<FoodDTO> drinkList = fillLstViewFood("Drink", false);


            
            snackList.ForEach(snackEntry => lstViewSnacks.Items.Add(snackEntry.Name + " Price: " + snackEntry.Price));
            drinkList.ForEach(drinkEntry => lstViewDrinks.Items.Add(drinkEntry.Name + " Price: " + drinkEntry.Price));
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
            List<FoodDTO> snackList = fillLstViewFood("Snack", isLimited);
            snackList.ForEach(snackEntry => lstViewSnacks.Items.Add(snackEntry.Name + " Price: " + snackEntry.Price));
        }
        private void btnDrinksEnter_Click(object sender, EventArgs e)
        {
            bool isLimited = cmbSnacks.SelectedIndex.Equals("Limited") ? true : false;
            List<FoodDTO> drinkList = fillLstViewFood("Drink", isLimited);
            drinkList.ForEach(entry => Console.WriteLine(entry));
            drinkList.ForEach(drinkEntry => lstViewDrinks.Items.Add(drinkEntry.Name + " Price: " + drinkEntry.Price));

            
        }
        private List<FoodDTO> fillLstViewFood(string category, bool isLimited)
        {

            Food foodObj = new Food(category, isLimited);
            List<FoodDTO> listOfFood = new List<FoodDTO>();

            listOfFood = foodObj.SelectAll();
            return listOfFood;
        }

        private void lstViewPaymentNeeded_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstViewPaymentNeeded_Click(object sender, EventArgs e)
        {
            /*
            int itemToRemoveIndex = lstViewPaymentNeeded.SelectedItems
            lstBoxPaymentNeeded.Items.RemoveAt(itemToRemoveIndex);

            lstViewPaymentNeeded.Items.Remove();
            */
        }
    }
}
