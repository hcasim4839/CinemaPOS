using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class NonMemberCreditCardDAO : IDAOCRUDCommands<NonMemberCreditCard>
    {
        public bool Delete(NonMemberCreditCard item)
        {
            throw new NotImplementedException();
        }
        public bool DeleteAll()
        {
            return false;
        }
        public bool Insert(NonMemberCreditCard item)
        {
            throw new NotImplementedException();
        }
     
    }
}
