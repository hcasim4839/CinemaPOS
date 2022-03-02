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

            List<string> listR = new List<string>();
            listR.Add("Car");
            listR.Add("Bus");


            listR.ForEach((element) => cmbCategory.Items.Add(element));
        }

        private void btnSecondarySubmit_Click(object sender, EventArgs e)
        {
            string NewCategory = txtNewCategory.Text.Trim();


        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string name = txtName.Text.Trim();
            string price = txtPrice.Text.Trim();
            string category = cmbCategory.SelectedItem.ToString();

            MessageBox.Show(String.Format("The name is: {0},\nThe price is: {1}, \nThe category is: {2}", name, price, category));

        }
    }
}
