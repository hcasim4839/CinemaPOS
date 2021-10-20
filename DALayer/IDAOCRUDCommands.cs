using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DALayer
{
    public interface IDAOCRUDCommands<T>
    {
        bool Select(T objDTO);
        bool Insert(T objDTO);
        bool Delete(T objDTO);
    }
}
