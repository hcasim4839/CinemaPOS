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
            AWSMySQL db = (AWSMySQL)SQLFactory.GetSQLInstance(SQLFactory.AwsMySQL);
            string conn = db.ConnString;

            MySqlConnection objConn = new MySqlConnection(
                conn);

            try
            {

                objConn.Open();
                string sqlQuery = String.Format("SELECT * FROM CreditCard WHERE PhoneNumber = {0}", objDTO.PhoneNumber);

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
    }
}
