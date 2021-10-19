using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DALayer
{
    public abstract class SQLBase
    {
        
       
        

        public abstract void Insert(string command);
        public abstract void Delete(string command);
        public ProductDAO GetProductDAO()
        {
            return new ProductDAO();
        }
        public CustomerOrderDAO GetCustomerOrderDAO()
        {
            return new CustomerOrderDAO();
        }
        public OrderItemDAO GetOrderItemDAO()
        {
            return new OrderItemDAO();
        }
        public CreditCardDAO GetCreditCardDAO()
        {
            return new CreditCardDAO();
        }
        public MemberDAO GetMemberDAO()
        {
            return new MemberDAO();
        }
        public NonMemberDAO GetNonMemberDAO()
        {
            return new NonMemberDAO();
        }
        public MemberCreditCardDAO GetMemberCreditCardDAO()
        {
            return new MemberCreditCardDAO();
        }

        


    }
}
