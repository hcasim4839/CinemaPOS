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
        public abstract bool Select();
        protected abstract bool DALayer_Insert();
        protected abstract bool DALayer_Delete();
        protected abstract bool DALayer_Select();

    }
}
