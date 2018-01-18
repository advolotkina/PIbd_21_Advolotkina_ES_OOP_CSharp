using System.Drawing;

namespace ULSTU_OOP_SCharp_Lab3
{
    public abstract class CartilaginousFish : IAnimal
    {
        protected float startPosX;
        protected float startPosY;

        protected int victims;
        protected int sleptHours;

        public Color BodyPattern {
            protected set;
            get;
        }

        public virtual double Weight
        {
            protected set;
            get;
        }


        public abstract void draw(Graphics g);

        public abstract void move(Graphics g);

        public virtual int HoursNeededToSleep
        {
            protected set;
            get;
        }

        public virtual int MaxNumberOfVictims
        {
            protected set;
            get;
        }

        public void eat(int count)
        {
            hunt(count);
        }

        public void hunt(int count)
        {
            if (victims + count < MaxNumberOfVictims)
            {
                victims = victims + count;
            } else if(victims + count == MaxNumberOfVictims)
            {
                sleptHours = 0;
                victims = MaxNumberOfVictims;
            }
        }

        public void setPosition(int x, int y)
        {
            startPosX = x;
            startPosY = y;
        }

        public void sleep(int count)
        {
            if(sleptHours + count < HoursNeededToSleep)
            {
                sleptHours = sleptHours + count;
            } else if(sleptHours + count == HoursNeededToSleep)
            {
                victims = 0;
            }
        }

        public void breath()
        {
            breathOxygen();
        }

        public void breathOxygen()
        {

        }

        public void makeNoise()
        {
            makeUltraSound();
        }

        public void makeUltraSound()
        {

        }
        public virtual void setMainColor(Color color)
        {
            BodyPattern = color;
        }

        public abstract string getInfo();
    }
}
