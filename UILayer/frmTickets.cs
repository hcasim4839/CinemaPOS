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
    public partial class frmTickets : Form
    {
        public string[] list = { "Horror", "Comedy", "Action", "Heroes" };
        public frmTickets()
        {
            
            InitializeComponent();
            
            MovieTicket movieTicketObj = new MovieTicket();
            List<MovieTicketDTO> listOfMovies = new List<MovieTicketDTO>();

            listOfMovies = movieTicketObj.SelectAll();
            listOfMovies.ForEach(entry => lstViewMovies.Items.Add(entry.Name));
            for (int i = 0; i < list.Length; i++)
            {
                cmbMovieGenre.Items.Add(list[i]);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            string genre = cmbMovieGenre.SelectedItem.ToString();

            MovieTicket movieTicket = new MovieTicket();
            List<MovieTicketDTO> listOfMovies = new List<MovieTicketDTO>();

            listOfMovies = movieTicket.Select(genre);
            listOfMovies.ForEach(entry => lstViewMovies.Items.Add("Category: " + entry.Category + "\nTitle: " + entry.Name + "\nPrice: " + entry.Price));
        }

        private void btnPayCash_Click(object sender, EventArgs e)
        {
            frmCashPayment frmObj = new frmCashPayment();
            this.Hide();
            frmObj.ShowDialog();
            this.Show();
        }

        private void cmbMovieGenre_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void frmTickets_Load(object sender, EventArgs e)
        {
            
            
        }
    }
}
