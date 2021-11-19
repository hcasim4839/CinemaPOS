using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class FoodDAO : IDAOCRUDCommands<FoodDTO>
    {
        public bool Delete(FoodDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public bool Insert(FoodDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public FoodDTO Select(FoodDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public List<FoodDTO> SelectAll(string category, bool isLimited)
        {
            AWSMySQL db = (AWSMySQL)SQLFactory.GetSQLInstance(SQLFactory.AwsMySQL);
            MySqlConnection connObj = new MySqlConnection(db.ConnString);

            try
            {
                connObj.Open();


                string query = String.Format("SELECT * FROM FOOD WHERE Category = {0} AND IsLimited = {1}", category,
                    isLimited ? "Y" : "N");

                MySqlCommand cmdObj = new MySqlCommand(query, connObj);
                cmdObj.CommandType = CommandType.Text;

                MySqlDataReader reader = cmdObj.ExecuteReader();

                List<FoodDTO> listOfFood = new List<FoodDTO>();
                FoodDTO foodDTO = new FoodDTO();

                while (reader.Read())
                {
                    foodDTO.Name = reader.GetString("Name");
                    foodDTO.Price = reader.GetString("Price");

                    listOfFood.Add(foodDTO);
                }
                return listOfFood;
            }
            catch(Exception e)
            {
                throw new Exception("Error in the FoodDAO class, method SelectAll: " + e.Message);
            }
            finally
            {

            }
        }
    }
}
