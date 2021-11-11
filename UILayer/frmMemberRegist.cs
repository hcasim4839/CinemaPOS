using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOLayer;

namespace UILayer
{
    public partial class frmMemberRegist : Form
    {
        public frmMemberRegist()
        {
            InitializeComponent();
        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void lblLastName_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddCC_Click(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Member member = new Member(txtFirstName.Text.Trim() + " " + txtLastName.Text.Trim(), txtPhoneNum.Text.Trim());
            bool isInserted = member.Insert();

            string message = isInserted == true ? "Member was inserted" : "Member was not inserted";

            MessageBox.Show(message);

            resetForm();
        }

        private void resetForm()
        {
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtPhoneNum .Text = "";
        }
    }
}
