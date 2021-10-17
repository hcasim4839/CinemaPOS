using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOLayer
{
    public interface IDAOCRUDCommands<T>
    {
        bool Insert(T objDTO);
        bool Delete(T objDTO);

    }
}
