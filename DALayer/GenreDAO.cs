using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class GenreDAO : IDAOCRUDCommands<GenreDTO>
    {
        public List<GenreDTO> SelectAll()
        {
            AWSMySQL db = (AWSMySQL)SQLFactory.GetSQLInstance(SQLFactory.AwsMySQL);
            MySqlConnection connObj = new MySqlConnection(db.ConnString);
            try
            {
                connObj.Open();
                string query = "SELECT * FROM Genre";

                MySqlCommand cmdObj = new MySqlCommand(query, connObj);
                cmdObj.CommandType = CommandType.Text;

                MySqlDataReader reader = cmdObj.ExecuteReader();

                List<GenreDTO> listOfGenre = new List<GenreDTO>();
                
                while (reader.Read())
                {
                    GenreDTO genreDTO = new GenreDTO();
                    genreDTO.Category = reader.GetString("Category").Trim();
                    listOfGenre.Add(genreDTO);
                    
                }
              
                return listOfGenre;
            }catch(Exception e)
            {
                throw new Exception("Error in the GenreDAO class within the method SelectAll: " + e.Message);
            }
            finally
            {
                connObj.Close();
                connObj.Dispose();
            }
        }
        public bool Delete(GenreDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public bool Insert(GenreDTO objDTO)
        {
            AWSMySQL db = (AWSMySQL) SQLFactory.GetSQLInstance(SQLFactory.AwsMySQL);
            MySqlConnection connObj = new MySqlConnection(db.ConnString);

            try
            {
                connObj.Open();
                string query = "INSERT into Genre(Category) VALUES(@Category)";

                MySqlCommand cmbObj = new MySqlCommand(query, connObj);
                cmbObj.CommandType = CommandType.Text;

                cmbObj.Parameters.AddWithValue("@Category", objDTO.Category);

                int numRowsAffected = cmbObj.ExecuteNonQuery();

                bool isDataInserted = numRowsAffected > 0 ? true : false;
                return isDataInserted;
            } catch (Exception e)
            {
                throw new Exception("Error in the GenreDAO class within the method Insert: " + e.Message);
            }
            finally
            {
                connObj.Close();
                connObj.Dispose();
            }

        }

        public GenreDTO Select(GenreDTO objDTO)
        {
            throw new NotImplementedException();
        }
    }
}
