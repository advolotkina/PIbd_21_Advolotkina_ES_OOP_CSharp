
namespace ULSTU_OOP_Csharp_HomeLab1
{
    class Egg
    {
        private int has_ready = 0;
        private int dirty = 10;

        public bool Have_shell
        {
            set;
            get;
        }

        public int Has_ready
        {
            get
            {
                return has_ready;
            }
        }

        public void GetHeat()
        {
            if (has_ready < 10)
            {
                has_ready++;
            }
        }

        public int Dirty
        {
            set
            {
                if (value > -1 && value < 11) dirty = value;
            }
            get
            {
                return dirty;
            }
        }
    }
}
