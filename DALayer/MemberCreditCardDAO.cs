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

        public bool Insert(MemberCreditCardDTO mCreditCardDTO, CreditCardDTO ccDTO)
        {
            AWSMySQL db = (AWSMySQL)SQLFactory.GetSQLInstance(SQLFactory.AwsMySQL);
            string connString = db.ConnString;

            MySqlConnection objConn = new MySqlConnection(connString);
            try
            {
                objConn.Open();

                string sqlQuery = "INSERT INTO CreditCard (CreditCardIssuerName, CreditCardNumber, CardHolderName, ExpDate, AddressLine1, AddressLine2, City, State, ZipCode)";
                sqlQuery = sqlQuery + "VALUES(@CreditCardIssuerName, @CreditCardNumber, @CardHolderName, @ExpDate, @AddressLine1, @AddressLine2, @City, @State, @ZipCode);";

                MySqlCommand objCmd = new MySqlCommand(sqlQuery, objConn);
                objCmd.CommandType = CommandType.Text;

                objCmd.Parameters.AddWithValue("@CreditCardIssuerName", ccDTO.CreditCardCompany);
                objCmd.Parameters.AddWithValue("@CreditCardNumber", ccDTO.CreditCardNumber);
                objCmd.Parameters.AddWithValue("@CardHolderName", ccDTO.CardHolderName);
                objCmd.Parameters.AddWithValue("@ExpDate", ccDTO.ExpDate);
                objCmd.Parameters.AddWithValue("@AddressLine1", ccDTO.AddressLine1);
                objCmd.Parameters.AddWithValue("@AddressLine2", ccDTO.AddressLine2);
                objCmd.Parameters.AddWithValue("@City", ccDTO.City);
                objCmd.Parameters.AddWithValue("@State", ccDTO.State);
                objCmd.Parameters.AddWithValue("@ZipCode", ccDTO.ZipCode);

                int recordsAffected = objCmd.ExecuteNonQuery();
                bool isCreditCardInserted = recordsAffected > 0 ? true : false;
                
                sqlQuery = "INSERT INTO MemberCreditCard(CreditCardIssuerName,CreditCardNumber, PhoneNumber)";
                sqlQuery = sqlQuery + " VALUES(@CreditCardIssuerName, @CreditCardNumber, @PhoneNumber);";

                objCmd = new MySqlCommand(sqlQuery, objConn);
                objCmd.CommandType = CommandType.Text;

                objCmd.Parameters.AddWithValue("@CreditCardIssuerName", ccDTO.CreditCardCompany);
                objCmd.Parameters.AddWithValue("@CreditCardNumber", ccDTO.CreditCardNumber);
                objCmd.Parameters.AddWithValue("@PhoneNumber", mCreditCardDTO.PhoneNumber);

                recordsAffected = objCmd.ExecuteNonQuery();

                if (recordsAffected > 0 && isCreditCardInserted)
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

        public bool Insert(MemberCreditCardDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public MemberCreditCardDTO Select(MemberCreditCardDTO objDTO)
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
