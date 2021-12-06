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
        readonly int maxNumCashPaymentValues = 4;
        readonly int cashPaymentDecimalIndex = 2;
        
        public frmCashPayment(decimal ticketsCost)
        {
            InitializeComponent();
            lblTotal.Text += ticketsCost;
            txtTotalCostValue.Text += ticketsCost;

        }

        public frmCashPayment()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnTender_Click(object sender, EventArgs e)
        {
            /*
            int ChangeNumIndex = lblChange.Text.IndexOf("Change:");
            MessageBox.Show("Change: " + lblChange.Text.Substring(ChangeNumIndex));
            */

            findChangeAmt(txtTotalCostValue.Text, txtUserCashPaymentValue.Text);
           
        }

        private void findChangeAmt(string minuend, string subtrahend)
        {
            double minuendDouble = Convert.ToDouble(minuend);
            double subtrahendDouble = Convert.ToDouble(subtrahend);

            double difference = minuendDouble - subtrahendDouble;

            if (difference > 0)
            {
                MessageBox.Show("Change: $" + difference);
            }
            else
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
            addCashPaymentValues("0");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            /*
            if (txtUserCashPaymentValue.Text.Length < 5)
            {
                decimal newValue = Convert.ToDecimal(txtUserCashPaymentValue.Text.Substring(0, txtUserCashPaymentValue.Text.Length - 1);
                String.Format("{0:#.00}", newValue / 100);
            }else
                SystemSounds.Beep.Play();
            */
        
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
            /*
            int subtrahendLblLength = lblUserCashPayment.Text.Length;
            int minuendLblLength = lblTotalCost.Text.Length;

            decimal minuend = Convert.ToDecimal(lblTotalCost.Text.Substring(12, minuendLblLength ));
            decimal subtrahend = Convert.ToDecimal(lblUserCashPayment.Text.Substring(13, subtrahendLblLength));

            decimal change = minuend - subtrahend;
            lblChange.Text += change;
            */
        }
    }
}
