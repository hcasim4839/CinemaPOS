using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class MemberCreditCardDAO : IDAOCRUDCommands<MemberCreditCardDTO>
    {
        public bool Delete(MemberCreditCardDTO objDTO)
        {
            AWSMySQL db = (AWSMySQL)SQLFactory.GetSQLInstance(SQLFactory.AwsMySQL);
            string conn = db.ConnString;

            MySqlConnection objConn = new MySqlConnection(conn);

            try
            {
                objConn.Open();
                string sqlQuery = "DELETE FROM MemberCreditCard WHERE PhoneNumber=@PhoneNum";
                sqlQuery = sqlQuery + " AND CreditCardNumber=@CreditCardNum;";

                MySqlCommand objCmd = new MySqlCommand(sqlQuery, objConn);
                objCmd.CommandType = CommandType.Text;

                objCmd.Parameters.AddWithValue("@PhoneNum", objDTO.PhoneNumber);
                objCmd.Parameters.AddWithValue("@CreditCardNum", objDTO.CreditCardNumber);

                int recordsAffected = objCmd.ExecuteNonQuery();
                if (recordsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }catch(Exception e)
            {
                throw new Exception("Error on Delete method from MemberCreditCardDAO class: " + e.Message);
            }
            finally
            {
                objConn.Close();
                objConn.Dispose(); 
            }
        }

        public bool Insert(MemberCreditCardDTO objDTO)
        {
            AWSMySQL db = (AWSMySQL)SQLFactory.GetSQLInstance(SQLFactory.AwsMySQL);
            string connString = db.ConnString;

            MySqlConnection objConn = new MySqlConnection(connString);
            try
            {
                objConn.Open();
                string sqlQuery = "INSERT INTO MemberCreditCard(CreditCardIssuerName,CreditCardNumber, PhoneNumber)";
                sqlQuery = sqlQuery + " VALUES(@CreditCardIssuerName, @CreditCardNumber, @PhoneNumber);";

                MySqlCommand objCmd = new MySqlCommand(sqlQuery, objConn);
                objCmd.CommandType = CommandType.Text;

                objCmd.Parameters.AddWithValue("@CreditCardIssuerName", objDTO.CreditCardIssuerName);
                objCmd.Parameters.AddWithValue("@CreditCardNumber", objDTO.CreditCardNumber);
                objCmd.Parameters.AddWithValue("@PhoneNumber", objDTO.PhoneNumber);

                int recordsAffected = objCmd.ExecuteNonQuery();

                if (recordsAffected > 0)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }catch(Exception e)
            {
                throw new Exception("Error in method Insert() from MemberCreditCardDAO class: " + e.Message);
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();
            }

        }

        public bool Select(MemberCreditCardDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public List<CreditCardDTO> SelectAll(MemberCreditCardDTO objDTO)
        {
            AWSMySQL db = (AWSMySQL)SQLFactory.GetSQLInstance(SQLFactory.AwsMySQL);
            string conn = db.ConnString;

            MySqlConnection objConn = new MySqlConnection(
                conn);
            List<CreditCardDTO> listDTO = new List<CreditCardDTO>();
            try
            {

                objConn.Open();
                string sqlQuery = String.Format(
                    "SELECT CreditCardIssuerName, CardHolderName,ExpDate," +
"CreditCardNumber FROM CreditCard WHERE CreditCardNumber IN" +
" (SELECT CreditCardNumber FROM MemberCreditCard" +
" WHERE PhoneNumber = '{0}');"
                    , objDTO.PhoneNumber);

                MySqlCommand objCmd = new MySqlCommand(sqlQuery, objConn);
                objCmd.CommandType = CommandType.Text;

                MySqlDataReader dataReader = objCmd.ExecuteReader();

                while (dataReader.Read())
                {
                    CreditCardDTO creditCardDTO = new CreditCardDTO();
                    creditCardDTO.CreditCardCompany = dataReader.GetString("CreditCardIssuerName").ToString();
                    creditCardDTO.CardHolderName = dataReader.GetString("CardHolderName").ToString();
                    creditCardDTO.ExpDate = dataReader.GetString("ExpDate").ToString();
                    creditCardDTO.CreditCardNumber = dataReader.GetString("CreditCardNumber").ToString();
                    listDTO.Add(creditCardDTO);
                }

                
                objCmd.Dispose();
                return listDTO;
            }
            catch (Exception E)
            {
                throw new Exception("Unexpected Error in CreditCardDAO SelectAll method: " + E.Message);
            }
            finally
            {
                objConn.Close();
                objConn.Dispose();

            }
        }
    }
}
