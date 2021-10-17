using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class CreditCard: SQLCRUDCommands
    {
        private string _creditCardCompany;
        private string _creditCardNumber;
        private string _cardHolderName;
        private string _expDate;
        private string _addressLine1;
        private string _addressLine2;
        private string _city;
        private string _state;
        private string _zipCode;
        

        public string CreditCardCompany
        {
            get{ return _creditCardCompany; }
            set { _creditCardCompany = value; }
        }

        public string CreditCardNumber
        {
            get { return _creditCardNumber; }
            set { _creditCardNumber = value; }
        }
        public string CardHolderName
        {
            get { return _cardHolderName; }
            set { _cardHolderName = value; }
        }
        public string ExpDate
        {
            get { return _expDate; }
            set { _expDate = value; }
        }
        public string AddressLine1
        {
            get { return _addressLine1; }
            set { _addressLine1 = value; }
        }
        public string AddressLine2
        {
            get { return _addressLine2; }
            set { _addressLine2 = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string State
        {
            get { return _state; }
            set { _state = value; }
        }
        public string ZipCode
        {
            get { return _zipCode; }
            set { _zipCode = value; }
        }
        public CreditCard(string ccCompany, string cHolderName,
            string expDate, string addressLineOne, string addressLineTwo,
            string city, string state, string zipCode, string ccNum)
        {
            _creditCardCompany = ccCompany;
            _cardHolderName = cHolderName;
            _expDate = expDate;
            _addressLine1 = addressLineOne;
            _addressLine2 = addressLineTwo;
            _city = city;
            _state = state;
            _zipCode = zipCode;
            _creditCardNumber = ccNum;
        }

        public CreditCard()
        {
        }

        public override bool Insert()
        {
            return DALayer_Insert();
        }

        public override bool Delete()
        {
            throw new NotImplementedException();
        }

        protected override bool DALayer_Insert()
        {
            
            CreditCardDAO ccDAO = new CreditCardDAO();

            CreditCardDTO ccDTO = new CreditCardDTO();

            ccDTO.CreditCardCompany = _creditCardCompany;
            ccDTO.CreditCardNumber = _creditCardNumber;
            ccDTO.CardHolderName = _cardHolderName;
            ccDTO.ExpDate = _expDate;
            ccDTO.AddressLine1 = _addressLine1;
            ccDTO.AddressLine2 = _addressLine2;
            ccDTO.City = _city;
            ccDTO.State = _state;
            ccDTO.ZipCode = _zipCode;

            bool isInserted = ccDAO.Insert(ccDTO);

            if (isInserted)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected override bool DALayer_Delete()
        {
            throw new NotImplementedException();
        }
    }
}
