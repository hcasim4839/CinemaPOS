using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class MemberCreditCard:CustomerCreditCard
    {
        private string _phoneNum;

        public MemberCreditCard(string creditCardCompany, string creditcardNumber, string phoneNum)
        {
            base.CreditCardCompany = creditCardCompany;
            base.CreditCardNumber = creditcardNumber;
            _phoneNum = phoneNum;

        }

        public override bool Delete()
        {
            throw new NotImplementedException();
        }

        public override bool Insert()
        {
            throw new NotImplementedException();
        }

        protected override bool DALayer_Delete()
        {
            throw new NotImplementedException();
        }

        protected override bool DALayer_Insert()
        {
            throw new NotImplementedException();
        }
    }
}
