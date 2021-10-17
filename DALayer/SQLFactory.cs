using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class SQLFactory
    {
        public int MySQL = 0;
        public int AwsMySQL = 1;

        public SQLBase GetSQLInstance(int SQLDB, string connectionString)
        {
            SQLBase dbInstance;
            switch (SQLDB)
            {
                case 0:

                    dbInstance = new MySQL();
                    dbInstance.connString = connectionString;
                    return dbInstance;
                case 1:
                    dbInstance = new AWSMySQL();
                    dbInstance.connString = connectionString;
                    return dbInstance;
            
                default:
                    dbInstance = null;
                    return dbInstance;
                
                    


            }
        }
    }
}
