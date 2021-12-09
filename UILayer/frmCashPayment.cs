using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UILayer
{
    public partial class frmCashPayment : Form
    {
        string cashPaymentValue = "";
             
        public frmCashPayment(decimal ticketsCost)
        {
            InitializeComponent();
            lblTotal.Text += ticketsCost;
            txtTotalCostValue.Text += ticketsCost;
            
            List<decimal> listOfBills = new List<decimal>();          
            listOfBills.Add(1);
            listOfBills.Add(5);
            listOfBills.Add(10);
            listOfBills.Add(20);
            listOfBills.Add(50);
            listOfBills.Add(100);
             
            List<decimal> listOfPossiblePayments = new List<decimal>();
            listOfPossiblePayments.Add(ticketsCost);

            foreach (decimal bill in listOfBills)
            {
                if (bill > ticketsCost)
                    listOfPossiblePayments.Add(bill);
            }
            
            bool firstItem = true;
            foreach (decimal paymentOption in listOfPossiblePayments)
            {
                Button paymentOptionButton = new Button();
                paymentOptionButton.Text = String.Format("{0:#.00}", paymentOption);

                
                paymentOptionButton.Click += (sender, e) =>
                {
                    cashPaymentValue = "";
                    txtUserCashPaymentValue.Text = "";
                    if (firstItem)
                    {
                        int deciIndex = paymentOptionButton.Text.IndexOf(".");
                        string UserPaymentValue = paymentOptionButton.Text.Substring(0, deciIndex);
                        UserPaymentValue += paymentOptionButton.Text.Substring(++deciIndex, 2);
                        addCashPaymentValues(UserPaymentValue);
                        firstItem = false;
                    }else
                        addCashPaymentValues(Convert.ToString(paymentOption) + "00");




                };
                flwlyoutQuickBtns.Controls.Add(paymentOptionButton);
            }                        
        }        
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTender_Click(object sender, EventArgs e)
        {       
            findChangeAmt(txtUserCashPaymentValue.Text, txtTotalCostValue.Text);           
        }

        private void findChangeAmt(string minuend, string subtrahend)
        {
            double minuendDouble = Convert.ToDouble(minuend);
            double subtrahendDouble = Convert.ToDouble(subtrahend);

            double difference = minuendDouble - subtrahendDouble;

            if (difference > 0)
            {
                DialogResult result = MessageBox.Show( "Change: " + String.Format("{0:$.00}", difference), "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (result == DialogResult.OK)
                {
                    cashPaymentValue = "";
                    txtUserCashPaymentValue.Text = String.Format("{0:#.00}", 0);
                }                           
            }
            else if(difference < 0)
                MessageBox.Show("Error! Change Amount returns negative number");
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            addCashPaymentValues("1");
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            addCashPaymentValues("2");
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            addCashPaymentValues("3");
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            addCashPaymentValues("4");
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            addCashPaymentValues("5");
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            addCashPaymentValues("6");
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            addCashPaymentValues("7");
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            addCashPaymentValues("8");
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            addCashPaymentValues("9");
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            if(cashPaymentValue.Length > 0)
                addCashPaymentValues("0");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {        
            if(cashPaymentValue.Length > 0)
            {
                cashPaymentValue = cashPaymentValue.Substring(0, cashPaymentValue.Length - 1);
                decimal newValue;
                if (cashPaymentValue == "")
                    newValue = 0;        
                else
                {
                    decimal decimalCashPayment = Convert.ToDecimal(cashPaymentValue);
                    newValue = decimalCashPayment / 100;
                }
                txtUserCashPaymentValue.Text = String.Format("{0:#.00}", newValue);
            }
            else
                SystemSounds.Beep.Play();
        }

        private void addCashPaymentValues(string value)
        {
            if(cashPaymentValue.Length < 5)
            {
                cashPaymentValue += value;
                decimal newValue = Convert.ToDecimal(cashPaymentValue) / 100;
                txtUserCashPaymentValue.Text = String.Format("{0:#.00}", newValue);
            }
            else
                SystemSounds.Beep.Play();
        }

        private void lblUserCashPayment_TextChanged(object sender, EventArgs e)
        {         
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            cashPaymentValue = "";
            txtUserCashPaymentValue.Text = String.Format("{0:#.00}", 0);
        }
    }
}
