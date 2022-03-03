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
    public partial class frmNewMovies : Form
    {
        public frmNewMovies()
        {
            InitializeComponent();

            inializeCmbControl();
        }

        private void inializeCmbControl()
        {
            GenreDAO genreDAO = new GenreDAO();

            genreDAO.SelectAll().ForEach(movieGenre => cmbGenre.Items.Add(movieGenre.Category));
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            MovieTicketDAO movieDAO = new MovieTicketDAO();
            MovieTicketDTO movieDTO = new MovieTicketDTO();

            movieDTO.Name = txtName.Text.Trim();
            movieDTO.Price = txtPrice.Text.Trim();
            movieDTO.Category = cmbGenre.SelectedItem.ToString();

            bool isInserted = movieDAO.Insert(movieDTO);

            string msg = isInserted ? "The movie was successfully inserted" : "The movie was not inserted";

            MessageBox.Show(msg);
            ClearGrpMain();
        }

        private void ClearGrpMain()
        {
            txtName.Text = "";
            txtNewCategory.Text = "";
            txtPrice.Text = "";

           
        }

        private void btnSubmitCategory_Click(object sender, EventArgs e)
        {
            GenreDAO genreDAO = new GenreDAO();
            GenreDTO genreDTO = new GenreDTO();

            genreDTO.Category = txtNewCategory.Text.Trim();
            bool isInserted = genreDAO.Insert(genreDTO);

            string msg = isInserted == true ? "Category was successfully inserted!" : "Category not inserted";
            MessageBox.Show(msg);

            clearGrpNewCategory();
        }

        private void clearGrpNewCategory()
        {
            lblNewCategory.Text = "";
        }
    }
}
