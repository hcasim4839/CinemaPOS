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
    public partial class frmCCManagement : Form
    {
        
        public frmCCManagement()
        {
            InitializeComponent();
            List<string> cmbCCCompany = new List<string>();
            cmbCCCompany.Add("Visa");
            cmbCCCompany.Add("Discover");
            cmbCCCompany.Add("Mastercard");
            cmbCCCompany.Add("AmericanExpress");
            
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




            //initialize list view
            List<string> headings = new List<string>();
            headings.Add("Issuer");
            headings.Add("Card Holder Name");
            headings.Add("Expiration Date");
            headings.Add("Card Number");

            
            headings.ForEach(heading => lstViewCC.Columns.Add(heading));
            lstViewCC.View = View.Details;
            //initialize calendar control
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.CustomFormat = "MM/yyyy";

            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            CreditCardDTO ccDTO = new CreditCardDTO();

            ccDTO.CreditCardCompany = cmbCreditCardComp.Text.Trim();
            ccDTO.CreditCardNumber = txtCCNum.Text.Trim();
            ccDTO.CardHolderName = txtCardHolder.Text.Trim();
            ccDTO.ExpDate = dateTimePicker1.Text.Trim();
            ccDTO.AddressLine1 = txtAddress1.Text.Trim();
            ccDTO.AddressLine2 = txtAddress2.Text.Trim();
            ccDTO.City = cmbCity.Text.Trim();
            ccDTO.State = cmbState.Text.Trim();
            ccDTO.ZipCode = txtZipCode.Text.Trim();

            

            MemberCreditCard mCreditCard = new MemberCreditCard(cmbCreditCardComp.GetItemText(cmbCreditCardComp.SelectedItem),txtCCNum.Text.Trim(),txtPhoneNum.Text.Trim());

            
          
            bool isMCreditCardInserted = mCreditCard.Insert(ccDTO);
            if (isMCreditCardInserted)
            {
                
                MessageBox.Show("The credit card was inserted successfully");

            }
            else
            {
                MessageBox.Show("The credit card was not inserted successfully");
            }

            clearForm();
            grabbedMemberCC();
        }
        private bool grabbedMemberCC()
        {
            lstViewCC.Items.Clear();
            MemberCreditCard mCreditCard = new MemberCreditCard(txtPhoneNum.Text);

            List<CreditCardDTO> listDTO = mCreditCard.SelectAll();

            if (listDTO.Count > 0)
            {

                listDTO.ForEach(dtoEntry => cmbCCNum.Items.Add(dtoEntry.CreditCardNumber));
                listDTO.ForEach(dtoEntry => lstViewCC.Items.Add(new ListViewItem(new[] { dtoEntry.CreditCardCompany, dtoEntry.CardHolderName, dtoEntry.ExpDate, dtoEntry.CreditCardNumber })));
                return true;
            }
            else
            {
                
                return false;
            }
           
        }
        private void clearForm()
        {
            txtCCNum.Clear();
            txtCardHolder.Clear();
            txtAddress1.Clear();
            txtAddress2.Clear();
            txtZipCode.Clear();

            lstViewCC.Items.Clear();

            cmbState.SelectedIndex = -1;
            cmbCity.SelectedIndex = -1;
            cmbCreditCardComp.SelectedIndex = -1;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            bool hasCreditCards = grabbedMemberCC();
            txtPhoneNum.ReadOnly = true;

            if (hasCreditCards)
            {
                MessageBox.Show("Success!");
            }
            else
            {
                MessageBox.Show("User does not have any credit cards");
                
            }
            
        }

        private void lstViewCC_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPhoneNum.Text = "";
            txtPhoneNum.ReadOnly = false;
            clearForm();
        }

        private void frmCCManagement_Shown(object sender, EventArgs e)
        {
            //focus on phonetext control
            txtPhoneNum.Focus();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            
            MemberCreditCard mCreditCard = new MemberCreditCard(txtPhoneNum.Text, cmbCCNum.GetItemText(cmbCCNum.SelectedItem));
            

            bool successful = mCreditCard.Delete();
            if (successful)
            {
                MessageBox.Show("Credit Card was deleted");
                grabbedMemberCC();
            }
            else
            {
                MessageBox.Show("Error Credit Card was not deleted");
            }
        }

        
    }
}
