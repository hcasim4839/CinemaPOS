using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class CustomerOrder: SQLCRUDCommands
    {
        private string _id;
        private string _paymentMethod;
        private string _cost;
        private string _date;

        public CustomerOrder(string id, string paymentMethod, string totalCost, string date)
        {
            _id = id;
            _paymentMethod = paymentMethod;
            _cost = totalCost;
            _date = date;

        }

        public override bool Delete()
        {
            throw new NotImplementedException();
        }

        public override bool Insert()
        {
            throw new NotImplementedException();
        }

        public  bool Select()
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

        protected  bool DALayer_Select()
        {
            throw new NotImplementedException();
        }
    }
}
