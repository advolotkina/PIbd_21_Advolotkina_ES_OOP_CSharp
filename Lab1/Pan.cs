using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ULSTU_OOP_Csharp_HomeLab1
{
    class Pan
    {
        private Oil[] oil;

        private Egg[] eggs;

        private Salt salt;

        private Pepper pepper;

        public bool State
        {
            set;
            get;
        }

        public bool ReadyToGo
        {
            get
            {
                return Check();
            }
        }

        public void Init2(int countOil)
        {
            oil = new Oil[countOil];
        }

        public void Init(int countEggs)
        {
            eggs = new Egg[countEggs];
        }

        public void AddOil(Oil o)
        {
            for (int i = 0; i < oil.Length; ++i)
            {
                if (oil[i] == null)
                {
                    oil[i] = o;
                    return;
                }
            }
        }

        public void AddSalt(Salt s)
        {
            salt = s;
        }

        public void AddPepper(Pepper p)
        {
            pepper = p;
        }

        public void AddEgg(Egg egg)
        {
            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i] == null)
                {
                    eggs[i] = egg;
                    return;
                }
            }
        }

        private bool Check()
        {
            if (oil.Length == 0)
            {
                return false;
            }
            
            if (eggs == null)
            {
                return false;
            }
            if (eggs.Length == 0)
            {
                return false;
            }

            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i] == null)
                {
                    return false;
                }
            }
            return true;
        }

        public void GetHeat()
        {
            if (!Check())
            {
                return;
            }
            if (oil.Length > 0)
            {
                if (oil[0].Temperature < 100)
                {
                    for (int i = 0; i < oil.Length; ++i)
                    {
                        oil[i].GetHeat();
                    }
                    bool flag = false;
                    switch (oil[0].Temperature)
                    {
                        case 20: flag = true; break;
                        case 40: flag = true; break;
                        case 60: flag = true; break;
                        case 80: flag = true; break;
                        case 100: flag = true; break;
                    }
                    if (flag)
                    {
                        for (int i = 0; i < eggs.Length; ++i)
                        {
                            eggs[i].GetHeat();
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < eggs.Length; ++i)
                    {
                        eggs[i].GetHeat();
                    }
                }
            }
        }

        public bool IsReady()
        {
            for (int i = 0; i < oil.Length; ++i)
            {
                if (oil[i].Temperature < 100)
                {
                    return false;
                }
            }
            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i].Has_ready < 10)
                {
                    return false;
                }
            }
            return true;
        }

        public Egg[] GetEggs()
        {
            return eggs;
        }
    }
}
