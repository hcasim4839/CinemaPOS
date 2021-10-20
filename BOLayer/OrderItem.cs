using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class OrderItem: SQLCRUDCommands
    {
        private string _name;
        private string _id;
        private string _quantity;

        public OrderItem(string name, string id, string quantity)
        {
            _name = name;
            _id = id;
            _quantity = quantity;
        }

        public override bool Delete()
        {
            throw new NotImplementedException();
        }

        public override bool Insert()
        {
            throw new NotImplementedException();
        }

        public override bool Select()
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

        protected override bool DALayer_Select()
        {
            throw new NotImplementedException();
        }
    }
}
