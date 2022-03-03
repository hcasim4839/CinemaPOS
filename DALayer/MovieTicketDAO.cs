using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class MovieTicketDAO : IDAOCRUDCommands<MovieTicketDTO>
    {
        public bool Delete(MovieTicketDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public bool Insert(MovieTicketDTO objDTO)
        {
            AWSMySQL db = (AWSMySQL) SQLFactory.GetSQLInstance(SQLFactory.AwsMySQL);
            MySqlConnection objConn = new MySqlConnection(db.ConnString);

            try
            {
                objConn.Open();


                string query = "Insert into Product(Name,isLimitied,Category,Price)" +
                    "VALUES(@Name,@isLimited,@Category,@Price)";


                
                 
                MySqlCommand objCmd = new MySqlCommand(query, objConn);
                objCmd.CommandType = CommandType.Text;


                objCmd.Parameters.AddWithValue("@Name", objDTO.Name);
                objCmd.Parameters.AddWithValue("@Price", objDTO.Price);
                objCmd.Parameters.AddWithValue("@Category", objDTO.Category);
                objCmd.Parameters.AddWithValue("@isLimited", "F");

                
                
                

                int rowsAffectedProduct = objCmd.ExecuteNonQuery();

                objConn.Close();
                objConn.Dispose();

                objConn.Open();
                query = "Insert into MovieTicket(Name,Price,Category) VALUES(@Name, @Price, @Category)";

                objCmd = new MySqlCommand(query, objConn);
                objCmd.CommandType = CommandType.Text;

                objCmd.Parameters.AddWithValue("@Name", objDTO.Name);
                objCmd.Parameters.AddWithValue("@Price", objDTO.Price);
                objCmd.Parameters.AddWithValue("@Category", objDTO.Category);

                int rowsAffectedMovie = objCmd.ExecuteNonQuery();

                if (rowsAffectedMovie > 0 && rowsAffectedProduct > 0)
                    return true;
                else
                    return false;


            }
            catch (Exception e)
            {
                throw new Exception("There is an error in the MovieTicketDAO method Insert(MovieTicketDTO objDTO): " + e.Message);
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
            }
            
            

        }

        public MovieTicketDTO Select(MovieTicketDTO objDTO)
        {
            throw new NotImplementedException();
        }
        public List<MovieTicketDTO> Select(string genre)
        {
            AWSMySQL db = (AWSMySQL)SQLFactory.GetSQLInstance(SQLFactory.AwsMySQL);
            MySqlConnection objConn = new MySqlConnection(db.ConnString);

            try
            {
                objConn.Open();

                string query = "Select * from MovieTicket WHERE Category= @Category";

                MySqlCommand objCmd = new MySqlCommand(query, objConn);
                objCmd.CommandType = CommandType.Text;

                objCmd.Parameters.AddWithValue("@Category", genre);
                MySqlDataReader reader = objCmd.ExecuteReader();

                List<MovieTicketDTO> listOfMovies = new List<MovieTicketDTO>();
                MovieTicketDTO movieTicketDTO = new MovieTicketDTO();

                while (reader.Read())
                {
                    movieTicketDTO.Category = reader.GetString("Category");
                    movieTicketDTO.Name = reader.GetString("Name");
                    movieTicketDTO.Price = reader.GetString("Price");

                    listOfMovies.Add(movieTicketDTO);
                }
                return listOfMovies;
            }catch(Exception e)
            {
                throw new Exception("There is an error in the MovieTicketDAO method Select(string genre): " + e.Message);
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
            }

        }
        public List<MovieTicketDTO> SelectAll()
        {
            AWSMySQL db = (AWSMySQL) SQLFactory.GetSQLInstance(SQLFactory.AwsMySQL);
            MySqlConnection objConn = new MySqlConnection(db.ConnString);

            try
            {
                objConn.Open();

                string query = "Select * from MovieTicket";

                MySqlCommand objCmd = new MySqlCommand(query, objConn);
                objCmd.CommandType = CommandType.Text;

                MySqlDataReader reader = objCmd.ExecuteReader();

                List<MovieTicketDTO> listOfMovies = new List<MovieTicketDTO>();
                
                while (reader.Read())
                {
                    MovieTicketDTO movieTicketDTO = new MovieTicketDTO();
                    movieTicketDTO.Category = reader.GetString("Category");
                    movieTicketDTO.Name = reader.GetString("Name");                    
                    movieTicketDTO.Price = reader.GetString("Price");

                    listOfMovies.Add(movieTicketDTO);
                }

                return listOfMovies;
            }catch(Exception e)
            {
                throw new Exception("Error in the MovieTicket class method SelectAll: " + e.Message);
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
            }
        }
    }
}
