using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULSTU_OOP_Csharp_HomeLab1
{
    class Fork
    {
        public void Break(Egg egg)
        {
            if (egg.Have_shell)
            {
                egg.Have_shell = false;
            }
        }
    }
}
