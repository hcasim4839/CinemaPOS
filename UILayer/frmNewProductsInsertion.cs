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
    public partial class frmProductChanges : Form
    {
        public frmProductChanges()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnConsumable_Click(object sender, EventArgs e)
        {
            frmConsumable_s_ frmObj = new frmConsumable_s_();
            this.Hide();
            frmObj.ShowDialog();
            this.Show();
        }

        private void btnMovie_Click(object sender, EventArgs e)
        {
            frmNewMovies frmObj = new frmNewMovies();

            this.Hide();
            frmObj.ShowDialog();
            this.Show();
        }

        private void btnDeleteMovie_Click(object sender, EventArgs e)
        {
            frmDeleteMovie frmObj = new frmDeleteMovie();

            this.Hide();
            frmObj.ShowDialog();
            this.Show();
        }
    }
}
