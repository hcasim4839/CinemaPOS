using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public class CustomerDAO : IDAOCRUDCommands<CustomerDTO>
    {
        public bool Delete(CustomerDTO objDTO)
        {
            throw new NotImplementedException();
        }

        public bool Insert(CustomerDTO objDTO)
        {
            throw new NotImplementedException();
        }
    }
}
