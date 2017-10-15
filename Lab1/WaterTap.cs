using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULSTU_OOP_Csharp_HomeLab1
{
    class WaterTap
    {
        public bool State
        {
            set;
            get;
        }

        public void Wash(Egg egg)
        {
            if (State)
            {
                egg.Dirty = 0;
            }
        }
    }
}
