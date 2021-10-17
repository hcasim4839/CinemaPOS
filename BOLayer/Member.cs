using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    class Member: Customer
    {
        private string _phoneNum;
        private string _points;

        public Member(string custID, string name, string phoneNum )
        {
            base.CustID = custID;
            base.Name = name;
            _phoneNum = phoneNum;
        }
        public bool AddPoints()
        {
            return DALayer_AddPoints();
        }

        private bool DALayer_AddPoints()
        {
           return false;
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
