using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULSTU_OOP_Csharp_HomeLab1
{
    class Oil
    {
        private int temperature = 0;

        public double Count
        {
            set;
            get;
        }

        public int Temperature
        {
            get
            {
                return temperature;
            }
        }

        public void GetHeat()
        {
            if (temperature < 100)
            {
                temperature++;
            }
        }

        public bool State
        {
            set;
            get;
        }

        public Oil GetOil()
        {
            if (State)
            {
                return new Oil();
            }
            else
            {
                return null;
            }
        }
    }
}
