using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class SQLFactory
    {
        public static int MySQL = 0;
        public static int AwsMySQL = 1;

        public static SQLBase GetSQLInstance(int SQLDB)
        {
            SQLBase dbInstance;
            switch (SQLDB)
            {
                case 0:

                    dbInstance = new MySQL();
                    
                    return dbInstance;
                case 1:
                    dbInstance = new AWSMySQL();
                   
                    return dbInstance;
            
                default:
                    dbInstance = null;
                    return dbInstance;
                
            }
        }
       
    }
}
