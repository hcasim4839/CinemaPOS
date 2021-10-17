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
    public partial class frmMembership : Form
    {
        public frmMembership()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            frmRemoveMember frmObj = new frmRemoveMember();
            this.Hide();
            frmObj.ShowDialog();
            this.Show();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            frmMemberRegist frmObj = new frmMemberRegist();
            this.Hide();
            frmObj.ShowDialog();
            this.Show();
        }

        private void btnCCManagement_Click(object sender, EventArgs e)
        {
            frmCCManagement frmObj = new frmCCManagement();
            this.Hide();
            frmObj.ShowDialog();
            this.Show();
        }
    }
}
