using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class MemberDAO : IDAOCRUDCommands<MemberDTO>
    {
        public bool Delete(MemberDTO objDTO)
        {
            AWSMySQL db = (AWSMySQL)SQLFactory.GetSQLInstance(SQLFactory.AwsMySQL);

            MySqlConnection objConn = new MySqlConnection(db.ConnString);
            try
            {
                objConn.Open();

                string query = "DELETE FROM Member WHERE PhoneNumber = @PhoneNumber";

                MySqlCommand objCmd = new MySqlCommand(query, objConn);
                objCmd.CommandType = CommandType.Text;

                objCmd.Parameters.AddWithValue("@PhoneNumber", objDTO.PhoneNumber);

                int numResults = objCmd.ExecuteNonQuery();

                bool isDeleted = numResults > 0 ? true : false;

                return isDeleted;
            }catch(Exception e)
            {
                throw new Exception("Error in the MemberDAO class method Delete: " + e.Message);
            }
        }

        public bool Insert(MemberDTO objDTO)
        {
            AWSMySQL db = (AWSMySQL)SQLFactory.GetSQLInstance(SQLFactory.AwsMySQL);

            MySqlConnection objConn = new MySqlConnection(db.ConnString);

            try
            {
                objConn.Open();
                string query = "INSERT INTO Member(PhoneNumber, Name, Points)";
                query += "VALUES(@PhoneNumber, @Name, @Points)";

                MySqlCommand objCmd = new MySqlCommand(query, objConn);
                objCmd.CommandType = CommandType.Text;

                objCmd.Parameters.AddWithValue("@PhoneNumber", objDTO.PhoneNumber);
                objCmd.Parameters.AddWithValue("@Name", objDTO.Name);
                objCmd.Parameters.AddWithValue("@Points", objDTO.Points);

                int numResults = objCmd.ExecuteNonQuery();

                if (numResults > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception e)
            {
                throw new Exception("Error in the MemberDAO class method Insert: " + e.Message);
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
            }
        }

       

        public bool Select(MemberDTO objDTO)
        {
            throw new NotImplementedException();
        }
    }
}
