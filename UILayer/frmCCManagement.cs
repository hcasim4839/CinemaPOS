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
    public partial class frmCCManagement : Form
    {
        
        public frmCCManagement()
        {
            InitializeComponent();
            List<string> cmbCCCompany = new List<string>();
            cmbCCCompany.Add("Visa");
            cmbCCCompany.Add("Discover");
            cmbCCCompany.Add("Mastercard");
            
            List<string> listCity = new List<string>();
            listCity.Add("Elmhurst");
            List<string> listState = new List<string>();
            listState.Add("NY");

            foreach (string company in cmbCCCompany)
            {
                cmbCreditCardComp.Items.Add(company);
            }
            cmbCreditCardComp.DropDownStyle = ComboBoxStyle.DropDownList;

            foreach (string company in listCity)
            {
                cmbCity.Items.Add(company);
            }
            cmbCity.DropDownStyle = ComboBoxStyle.DropDownList;
            foreach (string company in listState)
            {
                cmbState.Items.Add(company);
            }
            cmbState.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            CreditCard cc = new CreditCard();

            cc.CreditCardCompany = cmbCreditCardComp.Text.Trim();
            cc.CreditCardNumber = txtCCNum.Text.Trim();
            cc.CardHolderName = txtCardHolder.Text.Trim();
            cc.ExpDate = lblExpDate.Text.Trim();
            cc.AddressLine1 = txtAddress1.Text.Trim();
            cc.AddressLine2 = txtAddress2.Text.Trim();
            cc.City = cmbCity.Text.Trim();
            cc.State = cmbState.Text.Trim();
            cc.ZipCode = txtZipCode.Text.Trim();

            bool isInserted = cc.Insert();

            if (isInserted)
            {
                MessageBox.Show("The credit card was inserted successfully");
            }
            else
            {
                MessageBox.Show("The credit card was not inserted successfully");
            }

            clearForm();
        }

        private void clearForm()
        {
            txtCCNum.Clear();
            txtCardHolder.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtZipCode.Clear();

            cmbState.SelectedIndex = -1;
            cmbCity.SelectedIndex = -1;
            cmbCreditCardComp.SelectedIndex = -1;
        }
    }
}
