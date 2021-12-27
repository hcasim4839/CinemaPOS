using DALayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class Food:SQLCRUDCommands
    {
        private string _name;
        private string _category;
        private string _price;
        private bool _isLimited;
        public Food()
        {

        }
        public Food(string category, bool isLimited)

        {
            _category = category;
            _isLimited = isLimited;
        }
        public List<FoodDTO> SelectAll()
        {
            return DALayer_SelectAll();
        }

        private List<FoodDTO> DALayer_SelectAll()
        {
            FoodDTO foodDTO = new FoodDTO();
            FoodDAO foodDAO = new FoodDAO();

            foodDTO.Category = _category;
            foodDTO.IsLimited = _isLimited;

            List<FoodDTO> listOfFood = foodDAO.SelectAll(foodDTO);
            return listOfFood;
        }

        public override bool Delete()
        {
            throw new NotImplementedException();
        }

        public override bool Insert()
        {
            throw new NotImplementedException();
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
