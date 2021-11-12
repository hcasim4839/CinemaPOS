using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class NonMember:Customer
    {
        private string _custID;
        public NonMember(string custID, string name)
        {
            _custID = custID;
            base.Name = name;
            
        }
        public bool DeleteAll()
        {
            return false;
        }
      
        public override bool Insert()
        {
            throw new NotImplementedException();
        }

        public override bool Delete()
        {
            throw new NotImplementedException();
        }
        public bool DALayer_DeleteAll()
        {
            return false;
        }

        protected override bool DALayer_Insert()
        {
            throw new NotImplementedException();
        }

        protected override bool DALayer_Delete()
        {
            throw new NotImplementedException();
        }

        public  bool Select()
        {
            throw new NotImplementedException();
        }

        protected  bool DALayer_Select()
        {
            throw new NotImplementedException();
        }
    }
}
