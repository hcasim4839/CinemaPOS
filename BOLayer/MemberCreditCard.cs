using DALayer;
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
        public MemberCreditCard(string phoneNum)
        {
            _phoneNum = phoneNum;
        }
        public override bool Delete()
        {
            return DALayer_Delete();
        }

        public override bool Insert()
        {
            throw new NotImplementedException();
        }

        public override bool Select()
        {
            return DALayer_Select();
        }

        protected override bool DALayer_Delete()
        {
            throw new NotImplementedException();
        }

        protected override bool DALayer_Insert()
        {
            throw new NotImplementedException();
        }

        protected override bool DALayer_Select()
        {
            MemberCreditCardDTO mCCDTO = new MemberCreditCardDTO();
            MemberCreditCardDAO mCCDAO = new MemberCreditCardDAO();

            mCCDTO.PhoneNumber = _phoneNum;

            return mCCDAO.Select(mCCDTO);
        }
    }
}
