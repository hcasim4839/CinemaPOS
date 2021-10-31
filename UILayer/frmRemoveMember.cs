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
    public partial class frmRemoveMember : Form
    {
        public frmRemoveMember()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            Member member = new Member(txtPhoneNum.Text.Trim());
            bool isDeleted = member.Delete();

            string message = isDeleted == true ? "The member was deleted" : "The member WAS NOT deleted";
            MessageBox.Show(message);

            resetForm();
        }

        private void resetForm()
        {
            txtPhoneNum.Text = "";
        }
    }
}
