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
        public MemberCreditCard(string phoneNum, string creditCardNumber)
        {
            _phoneNum = phoneNum;
            base.CreditCardNumber = creditCardNumber;
        }
        public override bool Delete()
        {
            return DALayer_Delete();
        }

        public bool Insert(CreditCardDTO ccDTO)
        {
            return DALayer_Insert(ccDTO);
        }

        public MemberCreditCardDTO Select()
        {
            return DALayer_Select();
        }
        public List<CreditCardDTO> SelectAll()
        {
            return DALayer_SelectAll();
        }

        private List<CreditCardDTO> DALayer_SelectAll()
        {
            MemberCreditCardDAO mCreditCardDAO = new MemberCreditCardDAO();
            MemberCreditCardDTO mCreditCardDTO = new MemberCreditCardDTO();
            mCreditCardDTO.PhoneNumber = _phoneNum;

            return mCreditCardDAO.SelectAll(mCreditCardDTO);
        }

        protected override bool DALayer_Delete()
        {

            MemberCreditCardDTO mCCDTO = new MemberCreditCardDTO();
            MemberCreditCardDAO mCCDAO = new MemberCreditCardDAO();

            mCCDTO.PhoneNumber = _phoneNum;
            mCCDTO.CreditCardNumber = base.CreditCardNumber;

            return mCCDAO.Delete(mCCDTO);
        }

        protected  bool DALayer_Insert(CreditCardDTO ccDTO)
        {
            MemberCreditCardDTO mCreditCardDTO = new MemberCreditCardDTO();
            MemberCreditCardDAO mCreditCardDAO = new MemberCreditCardDAO();

            mCreditCardDTO.CreditCardIssuerName = base.CreditCardCompany;
            mCreditCardDTO.CreditCardNumber = base.CreditCardCompany;
            mCreditCardDTO.PhoneNumber = _phoneNum;

            return mCreditCardDAO.Insert(mCreditCardDTO, ccDTO);
        }

        protected MemberCreditCardDTO DALayer_Select()
        {
            MemberCreditCardDTO mCCDTO = new MemberCreditCardDTO();
            MemberCreditCardDAO mCCDAO = new MemberCreditCardDAO();

            mCCDTO.CreditCardIssuerName = base.CreditCardCompany;
            mCCDTO.CreditCardNumber = base.CreditCardNumber;
            

            return mCCDAO.Select(mCCDTO);
        }

        public override bool Insert()
        {
            throw new NotImplementedException();
        }

        protected override bool DALayer_Insert()
        {
            throw new NotImplementedException();
        }
    }
}
