using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DALayer
{
    public abstract class SQLBase
    {
        private string connString;
        public string ConnString
        {
            get { return connString; }
            set { connString = value; }
        }

       
        


    }
}
