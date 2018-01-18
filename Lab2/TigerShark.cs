using System;
using System.Drawing;
namespace ULSTU_OOP_SCharp_Lab3
{
    public class TigerShark : Shark, IComparable<TigerShark>, IEquatable<TigerShark>
    {
        private Color dopColor;
        private int humansKilled;
       
        public TigerShark(int maxNumberOfVictims, int hoursNeededToSleep, double weight, Color color, Color dopColor) : base(maxNumberOfVictims, hoursNeededToSleep, weight, color)
        {
            this.dopColor = dopColor;
            this.humansKilled = 0;
        }

        public TigerShark(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if(strs.Length == 6)
            {
                MaxNumberOfVictims = Convert.ToInt32(strs[0]);
                HoursNeededToSleep = Convert.ToInt32(strs[1]);
                Weight = Convert.ToInt32(strs[2]);
                BodyPattern = Color.FromName(strs[3]);
                humansKilled = Convert.ToInt32(strs[4]);
                dopColor = Color.FromName(strs[5]);
            }
        }
        
        public int HumansKilled { get => humansKilled; set => humansKilled = value; }

        public override void drawShark(Graphics g)
        {
            base.drawShark(g);
            SolidBrush brush = new SolidBrush(dopColor);
            Pen pen = new Pen(Color.Black);
            for(int i = 0; i < 40; i = i + 5)
            {
                g.FillEllipse(brush, startPosX + 20 + i, startPosY + 29, 3, 6);
            }
            for(int i = 0; i < 20; i = i + 5)
            {
                g.FillEllipse(brush, startPosX + 29 + i, startPosY + 23, 3, 6);
            }
            for (int i = 0; i < 15; i = i + 5)
            {
                g.FillEllipse(brush, startPosX + 3 + i, startPosY + 16+i, 3, 6);
            }
            for (int i = 0; i < 12; i = i + 5)
            {
                g.FillEllipse(brush, startPosX + 4 + i, startPosY + 21 + i, 3, 6);
            }
            for (int i = 0; i < 9; i = i + 5)
            {
                g.FillEllipse(brush, startPosX + 4 + i, startPosY + 27 + i, 3, 6);
            }
        }

        protected void killHumans(int count)
        {
            for(int i = 0; i < count; i++)
            {
                Random rand = new Random();
                HumansKilled = rand.Next(2)+HumansKilled;
            }
        }

        public void setDopColor(Color color)
        {
            dopColor = color;
        }

        public override string getInfo()
        {
            return MaxNumberOfVictims + ";" + HoursNeededToSleep + ";" + Weight + ";" + BodyPattern.Name + ";" + humansKilled + ";" + dopColor.Name;

        }

        public int CompareTo(TigerShark other)
        {
            var res = (this is Shark).CompareTo(other is Shark);
            if (res != 0)
            {
                return res;
            }
            if (dopColor != other.dopColor)
            {
                return dopColor.Name.CompareTo(other.dopColor.Name);
            }
            if (HumansKilled != other.HumansKilled)
            {
                return HumansKilled.CompareTo(other.HumansKilled);
            }
            return 0;
        }

        public bool Equals(TigerShark other)
        {
            var res = (this is Shark).Equals(other is Shark);
            if (res != false)
            {
                return res;
            }
            if (dopColor != other.dopColor)
            {
                return false;
            }
            if (HumansKilled != other.HumansKilled)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            if(obj == null)
            {
                return false;
            }
            TigerShark sharkObj = obj as TigerShark;
            if (sharkObj == null)
            {
                return false;
            }
            else
            {
                return Equals(sharkObj);
            }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}
