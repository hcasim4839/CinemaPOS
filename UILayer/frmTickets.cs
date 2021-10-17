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
    public partial class frmTickets : Form
    {
        public string[] list = { "pokemon", "digimon", "scooby", "teen titan" };
        public frmTickets()
        {
            
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            foreach (string item in list)
            {
                ListViewItem viewItem = new ListViewItem(item);

                lstViewMovies.Items.Add(viewItem);

            }
        }

        private void btnPayCash_Click(object sender, EventArgs e)
        {
            frmCashPayment frmObj = new frmCashPayment();
            this.Hide();
            frmObj.ShowDialog();
            this.Show();
        }
    }
}
