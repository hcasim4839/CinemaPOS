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
        private string _phoneNum;
        public frmTickets(string phoneNum)
        {
            InitializeComponent();
            fillListView(false);
            Member member = new Member(phoneNum);
            MemberDTO memberDTO = member.Select();

            _phoneNum = phoneNum;
            lblName.Text = memberDTO.Name;
            lblPoints.Text = Convert.ToString(memberDTO.Points);

            //fill the genre in the combobox
            Genre genreObj = new Genre();
            List<GenreDTO> listOfGenre = genreObj.SelectAll();

            cmbMovieGenre.Items.Add("All");
            listOfGenre.ForEach(entry => cmbMovieGenre.Items.Add(entry.Category));            
            cmbMovieGenre.SelectedIndex = 0;
            
            //Default for comboBox control



        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            lstViewMovies.Items.Clear();
            if (cmbMovieGenre.SelectedItem.ToString() != "All")
                fillListView(true);
            else
                fillListView(false);

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
            decimal totalCost = 0.00m;

            foreach(var currentItem in lstBoxPaymentNeeded.Items)
            {

                string currentItemString = currentItem.ToString();
                int newEntryIndex = currentItemString.LastIndexOf("Price: ");
                newEntryIndex += 7;
                decimal ticketCost = Convert.ToDecimal(currentItemString.Substring(newEntryIndex));

                totalCost += ticketCost;
            }

            frmCashPayment frmObj;
            if (_phoneNum.Length > 0)
                frmObj = new frmCashPayment(totalCost, _phoneNum);            
            else
                frmObj = new frmCashPayment(totalCost);
             
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

        private void lstBoxPaymentNeeded_Click(object sender, EventArgs e)
        {
            int itemToRemoveIndex = lstBoxPaymentNeeded.SelectedIndex;
            lstBoxPaymentNeeded.Items.RemoveAt(itemToRemoveIndex);
        }
    }
}
