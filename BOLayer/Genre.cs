using DALayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class Genre:SQLCRUDCommands
    {
        private string _category;

        public Genre(string genreName)
        {
            _category = genreName;
        }
        public Genre()
        {

        }

        public List<GenreDTO> SelectAll()
        {
            return DALayer_SelectAll();
        }

        private List<GenreDTO> DALayer_SelectAll()
        {
            GenreDAO genreDAO = new GenreDAO();
            List<GenreDTO> listOfGenre = new List<GenreDTO>();

            listOfGenre = genreDAO.SelectAll();
            return listOfGenre;
        }

        public override bool Insert()
        {
            throw new NotImplementedException();
        }

        public override bool Delete()
        {
            throw new NotImplementedException();
        }

        protected override bool DALayer_Insert()
        {
            throw new NotImplementedException();
        }

        protected override bool DALayer_Delete()
        {
            throw new NotImplementedException();
        }
    }
}
