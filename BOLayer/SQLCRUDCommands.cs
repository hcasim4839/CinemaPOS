using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public abstract class SQLCRUDCommands
    {
        public abstract bool Insert();
        public abstract bool Delete();

        
        protected abstract bool DALayer_Insert();
        protected abstract bool DALayer_Delete();
        

    }
}
