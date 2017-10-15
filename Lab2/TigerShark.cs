using System;
using System.Drawing;
namespace ULSTU_OOP_Charp_Lab2
{
    public class TigerShark : Shark
    {
        private Color dopColor;
        private int humansKilled;
       
        public TigerShark(int maxNumberOfVictims, int hoursNeededToSleep, double weight, Color color, Color dopColor) : base(maxNumberOfVictims, hoursNeededToSleep, weight, color)
        {
            this.dopColor = dopColor;
            this.humansKilled = 0;
        }
        
        public int HumansKilled { get => humansKilled; set => humansKilled = value; }

        protected override void drawShark(Graphics g)
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
    }
}
