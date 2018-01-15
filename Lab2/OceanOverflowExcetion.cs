using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULSTU_OOP_SCharp_Lab3
{
    class OceanOverflowExcetion : Exception
    {
        public OceanOverflowExcetion():
            base("В океане нет свободных мест")
        { }
    }
}
