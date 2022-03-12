using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALayer;

namespace UILayer
{
    public partial class frmDeleteMovie : Form
    {
        public frmDeleteMovie()
        {
            InitializeComponent();

            initializeCheckedListBox();
            initializeGenreComboBox();
        }

        private void initializeGenreComboBox()
        {
            GenreDAO genreDAO = new GenreDAO();
            List<GenreDTO> genreList = genreDAO.SelectAll();

            genreList.ForEach(entry => cmbGenre.Items.Add(entry.Category));
        }

        private void initializeCheckedListBox()
        {
            MovieTicketDAO movieDAO = new MovieTicketDAO();

            List<MovieTicketDTO> movieList =  movieDAO.SelectAll();

            movieList.ForEach(movie => CListBoxMovie.Items.Add(movie.Name));
        }

       

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            List<MovieTicketDTO> movieListToRemove = new List<MovieTicketDTO>();

            MovieTicketDTO movieDTO;
            MovieTicketDAO movieDAO = new MovieTicketDAO();

            foreach (var movie in CListBoxMovie.CheckedItems)
            {
                movieDTO = new MovieTicketDTO();
                movieDTO.Name = movie.ToString();
               
                movieListToRemove.Add(movieDTO);
            }

            bool areMoviesDeleted = false;

            if (CListBoxMovie.CheckedItems.Count > 0)
            {
                areMoviesDeleted = movieDAO.Delete(movieListToRemove);
            }
            

            string msg = areMoviesDeleted ? "Movies were deleted" : "Movies were not deleted";

            MessageBox.Show(msg);
        }

        private void cmbGenre_SelectedIndexChanged(object sender, EventArgs e)
        {
            string itemGenre = cmbGenre.SelectedItem.ToString();

            loadMovies(itemGenre);

            
        }

        private void loadMovies(string genre)
        {
            CListBoxMovie.Items.Clear();
            MovieTicketDAO movieDAO = new MovieTicketDAO();

            List<MovieTicketDTO> movieList = movieDAO.SelectAll();

            movieList.ForEach(movie => {
                if (movie.Category.Equals(genre))
                    CListBoxMovie.Items.Add(movie.Name);
            });
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
