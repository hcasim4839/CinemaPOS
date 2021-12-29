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
        private string _phoneNum;
        public frmSnacksDrinks(string phoneNum)
        {
            InitializeComponent();
            Member member = new Member(phoneNum);
            _phoneNum = phoneNum;

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

            lstBoxPaymentNeeded.HorizontalScrollbar = true;
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
            totalCost = totalCostCal(totalCost);
            

            frmCashPayment frmObj = new frmCashPayment(totalCost);
            this.Hide();
            frmObj.ShowDialog();
            this.Show();
        }
        private decimal totalCostCal(decimal sumVar)
        {
            foreach (var currentItem in lstBoxPaymentNeeded.Items)
            {

                string currentItemString = currentItem.ToString();
                int newEntryIndex = currentItemString.LastIndexOf("Price: ");
                newEntryIndex += 7;
                decimal ticketCost = Convert.ToDecimal(currentItemString.Substring(newEntryIndex));

                sumVar += ticketCost;
            }
            return sumVar;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSnacksEnter_Click(object sender, EventArgs e)
        {
            bool isLimited = cmbSnacks.SelectedItem.Equals("Limited") ? true : false;
                        
            lstViewSnacks.Items.Clear();
            List<FoodDTO> snackList = fillLstViewFood("Snack", isLimited);
            snackList.ForEach(snackEntry => lstViewSnacks.Items.Add(snackEntry.Name + " Price: " + snackEntry.Price));
        }
        private void btnDrinksEnter_Click(object sender, EventArgs e)
        {
            bool isLimited = cmbSnacks.SelectedItem.Equals("Limited") ? true : false;
            
            lstViewDrinks.Items.Clear();
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

        private void lstBoxPaymentNeeded_Click(object sender, EventArgs e)
        {
            int itemToRemoveIndex = lstBoxPaymentNeeded.SelectedIndex;
            lstBoxPaymentNeeded.Items.RemoveAt(itemToRemoveIndex);
        }

        private string grabItemProperty(ListView lstViewControl)
        {
            
            var firstSelectedItem = lstViewControl.SelectedItems[0];
            
            return firstSelectedItem.Text;
        }

        private void lstViewSnacks_Click(object sender, EventArgs e)
        {
            string itemProperty = grabItemProperty(lstViewSnacks);

            lstBoxPaymentNeeded.Items.Add(itemProperty);
        }

        private void lstViewDrinks_Click(object sender, EventArgs e)
        {
            string itemProperty = grabItemProperty(lstViewDrinks);

            lstBoxPaymentNeeded.Items.Add(itemProperty);
        }

        private void lstViewDrinks_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            e.Graphics.DrawRectangle(Pens.Black, e.Bounds);
        }

        private void lstViewSnacks_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            e.DrawDefault = true;
            e.Graphics.DrawRectangle(Pens.Black, e.Bounds);
        }

        private void btnCC_Click(object sender, EventArgs e)
        {
            bool isMember = _phoneNum.Length > 0 ? true : false;


            decimal totalCost = 0.00m;
            totalCost = totalCostCal(totalCost);

            if (isMember)
            {
                this.Hide();
                frmCreditCardPayment frmObj = new frmCreditCardPayment(_phoneNum, totalCost);
                frmObj.ShowDialog();
                this.Show();
            }
        }
    }
}
