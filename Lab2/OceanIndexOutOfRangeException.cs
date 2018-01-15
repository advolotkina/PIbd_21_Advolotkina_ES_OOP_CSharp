using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULSTU_OOP_SCharp_Lab3
{
    class OceanIndexOutOfRangeException : Exception
    {
        public OceanIndexOutOfRangeException() :
            base("В океане нет акулы на данном месте")
        { }
    }
}
