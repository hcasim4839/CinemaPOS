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
    public partial class frmConsumable_s_ : Form
    {
        public frmConsumable_s_()
        {
            InitializeComponent();

            List<string> consumableCategory = new List<string>();
            consumableCategory.Add("Snack");
            consumableCategory.Add("Drink");


            consumableCategory.ForEach((element) => cmbCategory.Items.Add(element));

            cmbLimited.Items.AddRange(new string[] { "Limited", "Non-Limited"});

      
        }

        private void btnSecondarySubmit_Click(object sender, EventArgs e)
        {            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            FoodDAO foodDAO = new FoodDAO();
            FoodDTO foodDTO = new FoodDTO();

            foodDTO.Category = cmbCategory.SelectedItem.ToString();
            foodDTO.Name = txtName.Text;
            foodDTO.Price = txtPrice.Text;
            foodDTO.IsLimited = cmbLimited.SelectedItem.ToString() == "Limited" ? true : false;

            bool isFoodInserted = foodDAO.Insert(foodDTO);

            string msg = isFoodInserted ? "The Consumable has been inserted" : "The Consumable was not inserted";

            MessageBox.Show(msg);
            clearForm();
        }

        private void clearForm()
        {
            txtName.Text = "";
            txtPrice.Text = "";
        }
    }
}
