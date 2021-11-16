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
        public frmTickets(string phoneNum)
        {
            
            InitializeComponent();
            fillListView(false);
            Member member = new Member(phoneNum);
            MemberDTO memberDTO = member.Select();

            lblName.Text = memberDTO.Name;
            lblPoints.Text = memberDTO.Points;

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            /*
            string genre = cmbMovieGenre.SelectedItem.ToString();
            MovieTicket movieTicket = new MovieTicket();
            List<MovieTicketDTO> listOfMovies = new List<MovieTicketDTO>();
            listOfMovies = movieTicket.Select(genre);
            listOfMovies.ForEach(entry => lstViewMovies.Items.Add("Category: " + entry.Category + " Title: " + entry.Name + " Price: " + entry.Price));
            */
            fillListView(true);
        }
        private void fillListView(bool hasSpecificGenre)
        {
            MovieTicket movieTicket = new MovieTicket();
            List<MovieTicketDTO> listOfMovies = new List<MovieTicketDTO>();
            
            if (hasSpecificGenre)
            {
                string genre = cmbMovieGenre.SelectedItem.ToString();
                listOfMovies = movieTicket.Select(genre);
            }
            else
                listOfMovies = movieTicket.SelectAll();
          
            listOfMovies.ForEach(entry => lstViewMovies.Items.Add("Category: " + entry.Category + " Title: " + entry.Name + " Price: " + entry.Price));
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

        private void lstViewMovies_DrawItem(object sender, DrawListViewItemEventArgs e)
        {
            
            e.DrawDefault = true;
            e.Graphics.DrawRectangle(Pens.Black, e.Bounds);
            

        }

        private void lstViewMovies_Click(object sender, EventArgs e)
        {
            string itemProperties = grabItemProperty();
            
            lstBoxPaymentNeeded.Items.Add(itemProperties);
           
        }

        private string grabItemProperty()
        {
            var firstSelectedItem = lstViewMovies.SelectedItems[0];
            int titleIndex = firstSelectedItem.Text.IndexOf("Title: ");
            titleIndex += 7;

            string title = firstSelectedItem.Text.Substring(titleIndex);
            return title;
        }

        private void btnPayPoints_Click(object sender, EventArgs e)
        {

        }
    }
}
