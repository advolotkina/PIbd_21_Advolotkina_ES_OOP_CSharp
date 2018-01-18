using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULSTU_OOP_SCharp_Lab3
{
    class OceanAlreadyHaveException: Exception
    {
        public OceanAlreadyHaveException() :
            base("В океане уже есть такая же акула")
        { }
    }
}
