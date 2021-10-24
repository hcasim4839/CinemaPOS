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
            throw new NotImplementedException();
        }

        public bool Insert(MemberCreditCardDTO objDTO)
        {
            throw new NotImplementedException();
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
