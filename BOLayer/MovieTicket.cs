using DALayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class MovieTicket : SQLCRUDCommands
    {
        private string _name;
        private string _category;
        private string _price;
        public MovieTicket()
        {

        }
        public MovieTicket(string name, string category, string price)
        {

        }

        public override bool Delete()
        {
            return DALayer_Delete();
        }

        public override bool Insert()
        {
            return DALayer_Insert();
        }

        public List<MovieTicketDTO> SelectAll()
        {
            return DALayer_SelectAll();
        }
        public List<MovieTicketDTO> Select(string genre)
        {
            return DALayer_Select(genre);
        }

        private List<MovieTicketDTO> DALayer_Select(string genre)
        {
            MovieTicketDAO movieTicketDAO = new MovieTicketDAO();
            List<MovieTicketDTO> listOfMovies = new List<MovieTicketDTO>();

            listOfMovies =  movieTicketDAO.Select(genre);

            return listOfMovies;
        }

        private List<MovieTicketDTO> DALayer_SelectAll()
        {
            MovieTicketDAO movieTicketDAO = new MovieTicketDAO();
            List<MovieTicketDTO> listOfMovies = new List<MovieTicketDTO>();

            listOfMovies =  movieTicketDAO.SelectAll();
            return listOfMovies;
        }

        protected override bool DALayer_Delete()
        {
            throw new NotImplementedException();
        }

        protected override bool DALayer_Insert()
        {
            throw new NotImplementedException();
        }
    }
}
