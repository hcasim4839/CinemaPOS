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
            AWSMySQL db = (AWSMySQL) SQLFactory.GetSQLInstance(SQLFactory.AwsMySQL);
            MySqlConnection connObj = new MySqlConnection(db.ConnString);

            try
            {
                connObj.Open();
                string query = "Insert into Product(Name,isLimitied,Category,Price)" +
                    "VALUES(@Name,@isLimited,@Category,@Price)";

                MySqlCommand cmdObj = new MySqlCommand(query, connObj);
                cmdObj.CommandType = CommandType.Text;

                cmdObj.Parameters.AddWithValue("@Name", objDTO.Name);
                cmdObj.Parameters.AddWithValue("@isLimited", objDTO.IsLimited ? "T": "F");
                cmdObj.Parameters.AddWithValue("@Category", objDTO.Category);
                cmdObj.Parameters.AddWithValue("@Price", objDTO.Price);

                bool isProductInsert = cmdObj.ExecuteNonQuery() > 0 ? true : false ;

                connObj.Close();
                connObj.Dispose();

                connObj.Open();

                query = "Insert into Food (Name,isLimited,Category,Price)" +
                    "VALUES(@Name,@isLimited,@Category,@Price)";

                cmdObj = new MySqlCommand(query, connObj);
                cmdObj.CommandType = CommandType.Text;

                cmdObj.Parameters.AddWithValue("@Name", objDTO.Name);
                cmdObj.Parameters.AddWithValue("@isLimited", objDTO.IsLimited ? "T" : "F");
                cmdObj.Parameters.AddWithValue("@Category", objDTO.Category);
                cmdObj.Parameters.AddWithValue("@Price", objDTO.Price);

                bool isFoodInsert = cmdObj.ExecuteNonQuery() > 0 ? true : false;

                if (isFoodInsert && isProductInsert)
                    return true;
                else
                    return false;
            }
            catch(Exception e)
            {
                throw new Exception("Error in the FoodDAO class, method Insert(): " + e.Message);
            }
            finally
            {
                connObj.Close();
                connObj.Dispose();
            }
        }

        public FoodDTO Select(FoodDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public List<FoodDTO> SelectAll(FoodDTO objDTO)
        {
            AWSMySQL db = (AWSMySQL)SQLFactory.GetSQLInstance(SQLFactory.AwsMySQL);
            MySqlConnection connObj = new MySqlConnection(db.ConnString);

            try
            {
                connObj.Open();
                //Grab the category and limited status

                string query = "SELECT * FROM Food WHERE CATEGORY = @Category AND IsLimited = @IsLimited";

                MySqlCommand cmdObj = new MySqlCommand(query, connObj);
                cmdObj.CommandType = CommandType.Text;

                cmdObj.Parameters.AddWithValue("@Category", objDTO.Category);
                cmdObj.Parameters.AddWithValue("@IsLimited", objDTO.IsLimited ? "Y": "N" );


                string resp = objDTO.IsLimited ? "Y" : "N";
                Console.WriteLine("The islimited is: " + resp);

                MySqlDataReader reader = cmdObj.ExecuteReader();

                List<FoodDTO> listOfFood = new List<FoodDTO>();
                

                while (reader.Read())
                {
                    FoodDTO foodDTO = new FoodDTO();
                    foodDTO.Name = reader.GetString("Name");
                    foodDTO.Price = reader.GetString("Price");

                    listOfFood.Add(foodDTO);
                }

                listOfFood.ForEach(entry => Console.WriteLine(entry.Name));
                return listOfFood;
            }
            catch(Exception e)
            {
                throw new Exception("Error in the FoodDAO class, method SelectAll: " + e.Message);
            }
            finally
            {
                connObj.Close();
                connObj.Dispose();
            }
        }
    }
}
