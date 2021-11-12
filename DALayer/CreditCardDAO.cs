using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class CreditCardDAO : IDAOCRUDCommands<CreditCardDTO>
    {
        public bool Delete(CreditCardDTO objDTO)
        {
            AWSMySQL db = (AWSMySQL)SQLFactory.GetSQLInstance(SQLFactory.AwsMySQL);
            string conn = db.ConnString;

            MySqlConnection objConn = new MySqlConnection(
                conn);

            try
            {
                
                objConn.Open();
                string sqlQuery = String.Format("DELETE FROM CreditCard WHERE {0}", objDTO.CreditCardNumber);

                MySqlCommand objCmd = new MySqlCommand(sqlQuery, objConn);
                objCmd.CommandType = CommandType.Text;

                int recordsAffected = objCmd.ExecuteNonQuery();

                if (recordsAffected == 1)
                {
                    return true;
                }
                objCmd.Dispose();
                return false;
            }
            catch (Exception E)
            {
                throw new Exception("Unexpected Error in CreditCardDAO Insert method: " + E.Message);
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();

            }
        }

        public bool Insert(CreditCardDTO objDTO)
        {
            AWSMySQL db = (AWSMySQL)SQLFactory.GetSQLInstance(SQLFactory.AwsMySQL);
            string conn = db.ConnString;

            MySqlConnection objConn = new MySqlConnection(
                conn);

            try
            {
                objConn.Open();
                string sqlQuery = "INSERT INTO CreditCard (CreditCardIssuerName, CreditCardNumber, CardHolderName, ExpDate, AddressLine1, AddressLine2, City, State, ZipCode)";
                sqlQuery = sqlQuery + "VALUES(@CreditCardIssuerName, @CreditCardNumber, @CardHolderName, @ExpDate, @AddressLine1, @AddressLine2, @City, @State, @ZipCode);";

                MySqlCommand objCmd = new MySqlCommand(sqlQuery, objConn);
                objCmd.CommandType = CommandType.Text;

                objCmd.Parameters.AddWithValue("@CreditCardIssuerName", objDTO.CreditCardCompany);
                objCmd.Parameters.AddWithValue("@CreditCardNumber", objDTO.CreditCardNumber);
                objCmd.Parameters.AddWithValue("@CardHolderName", objDTO.CardHolderName);
                objCmd.Parameters.AddWithValue("@ExpDate", objDTO.ExpDate);
                objCmd.Parameters.AddWithValue("@AddressLine1", objDTO.AddressLine1);
                objCmd.Parameters.AddWithValue("@AddressLine2", objDTO.AddressLine2);
                objCmd.Parameters.AddWithValue("@City", objDTO.City);
                objCmd.Parameters.AddWithValue("@State", objDTO.State);
                objCmd.Parameters.AddWithValue("@ZipCode", objDTO.ZipCode);

                int recordsAffected = objCmd.ExecuteNonQuery();

                if (recordsAffected == 1)
                {
                    return true;
                }
                objCmd.Dispose();
                return false;
            }
            catch (Exception E)
            {
                throw new Exception("Unexpected Error in CreditCardDAO Insert method: " + E.Message);
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();

            }
        }

        public CreditCardDTO Select(CreditCardDTO objDTO)
        {
            /*
            AWSMySQL db = (AWSMySQL)SQLFactory.GetSQLInstance(SQLFactory.AwsMySQL);
            string conn = db.ConnString;

            MySqlConnection objConn = new MySqlConnection(
                conn);

            try
            {

                objConn.Open();
                string sqlQuery = String.Format("SELECT FROM CreditCard WHERE CreditCardNumber = {0}", objDTO.CreditCardNumber);

                MySqlCommand objCmd = new MySqlCommand(sqlQuery, objConn);
                objCmd.CommandType = CommandType.Text;

                int recordsAffected = objCmd.ExecuteNonQuery();

                if (recordsAffected == 1)
                {
                    return true;
                }
                objCmd.Dispose();
                return false;
            }
            catch (Exception E)
            {
                throw new Exception("Unexpected Error in CreditCardDAO Insert method: " + E.Message);
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();

            }
            */
            throw new NotImplementedException();
        }
    }

}
