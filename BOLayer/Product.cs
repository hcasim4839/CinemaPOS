using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public class Product: SQLCRUDCommands
    {
        private string _name;
        private bool _isLimited;
        private string _category;

        public Product()
        {
        }

        public Product(string name, bool isLimited, string category)
        {
            _name = name;
            _isLimited = isLimited;
            _category = category;
        }

        public override bool Delete()
        {
            throw new NotImplementedException();
        }

        public override bool Insert()
        {
            throw new NotImplementedException();
        }

        public  List<Product> Select(string productType)
        {
            return DALayer_Select(productType);
        }

        protected override bool DALayer_Delete()
        {
            throw new NotImplementedException();
        }

        protected override bool DALayer_Insert()
        {
            throw new NotImplementedException();
        }

        protected  bool DALayer_Select(string productType)
        {
           Product
        }
    }
}
