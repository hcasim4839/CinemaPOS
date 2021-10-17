using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class NonMemberCreditCard: CustomerCreditCard
    {
        private string _custID;

        public NonMemberCreditCard(string custID, string creditCardCompany, 
            string creditCardNumber)
        {
            _custID = custID;
            base.CreditCardCompany =  creditCardCompany;
            base.CreditCardNumber = creditCardNumber;
        }

        public override bool Delete()
        {
            throw new NotImplementedException();
        }

        public bool DeleteAll()
        {
            return DALayer_DeleteAll();
        }

        public override bool Insert()
        {
            throw new NotImplementedException();
        }

        protected override bool DALayer_Delete()
        {
            throw new NotImplementedException();
        }

        protected bool DALayer_DeleteAll()
        {
            return false;
        }

        protected override bool DALayer_Insert()
        {
            throw new NotImplementedException();
        }
    }
}
