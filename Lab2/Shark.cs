using System;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace ULSTU_OOP_Charp_Lab2
{
   public class Shark : CartilaginousFish
    {
        public Shark(int maxNumberOfVictims, int hoursNeededToSleep, double weight, Color color)
        {
            this.MaxNumberOfVictims = maxNumberOfVictims;
            this.HoursNeededToSleep = hoursNeededToSleep;
            this.Weight = weight;
            this.BodyPattern = color;
            this.sleptHours = 0;
            this.victims = 0;
            Random rand = new Random();
            startPosX = rand.Next(30, 50);
            startPosY = rand.Next(90, 100);
        }
        public override void draw(Graphics g)
        {
            drawShark(g);
        }

        protected virtual void drawShark(Graphics g)
        {
            SolidBrush brush = new SolidBrush(BodyPattern);
            PointF point1 = new PointF(startPosX, startPosY + 11);
            PointF point2 = new PointF(startPosX + 19, startPosY + 28);
            PointF point3 = new PointF(startPosX + 41, startPosY + 21);
            PointF point4 = new PointF(startPosX + 52, startPosY + 26);
            PointF point5 = new PointF(startPosX + 52, startPosY + 8);
            PointF point6 = new PointF(startPosX + 65, startPosY + 26);
            PointF point7 = new PointF(startPosX + 78, startPosY + 23);
            PointF point8 = new PointF(startPosX + 96, startPosY + 31);
            PointF point9 = new PointF(startPosX + 86, startPosY + 39);
            PointF point11 = new PointF(startPosX + 68, startPosY + 42);
            PointF point12 = new PointF(startPosX + 57, startPosY + 57);
            PointF point13 = new PointF(startPosX + 57, startPosY + 42);
            PointF point14 = new PointF(startPosX + 44, startPosY + 44);
            PointF point15 = new PointF(startPosX + 18, startPosY + 39);
            PointF point16 = new PointF(startPosX, startPosY + 57);
            PointF point17 = new PointF(startPosX + 5, startPosY + 34);
            PointF[] curvePoints = { point1, point2, point3, point4, point5, point6, point7,point8,point9,point11,point12,point13,point14,point15,point16,point17 };


            FillMode newFillMode = FillMode.Winding;


            g.FillPolygon(brush, curvePoints, newFillMode);
            Pen pen = new Pen(Color.White);
            g.DrawLine(pen, startPosX + 65, startPosY + 29, startPosX + 62, startPosY + 30);
            g.DrawLine(pen, startPosX + 62, startPosY + 30, startPosX + 65, startPosY + 35);
            g.DrawLine(pen, startPosX + 69, startPosY + 29, startPosX + 66, startPosY + 30);
            g.DrawLine(pen, startPosX + 66, startPosY + 30, startPosX + 69, startPosY + 35);
            g.DrawLine(pen, startPosX + 73, startPosY + 29, startPosX + 70, startPosY + 30);
            g.DrawLine(pen, startPosX + 70, startPosY + 30, startPosX + 73, startPosY + 35);
            g.DrawEllipse(pen, startPosX + 81, startPosY + 29, 4, 3);
            g.DrawLine(pen, startPosX + 78, startPosY + 36, startPosX + 86, startPosY + 39);

        }

        public override void move(Graphics g)
        {
            startPosX = startPosX + Math.Abs((float)(2*HoursNeededToSleep - 0.5*Weight));
            Random rand = new Random();
            startPosY = startPosY + 10*rand.Next(-2,2);
            draw(g);
        }

        public override double Weight
        {
            protected set
            {
                if(value > 100 && value < 300)
                {
                    base.Weight = value;
                }
                else
                {
                    base.Weight = 150;
                }
            }
            get
            {
                return base.Weight;
            }
        }

        public override int HoursNeededToSleep
        {
            protected set
            {
                if(value > 0 && value < 10)
                {
                    base.HoursNeededToSleep = value;
                }
                else
                {
                    base.HoursNeededToSleep = 8;
                }
            }
            get
            {
                return base.HoursNeededToSleep;
            }
        }

        public override int MaxNumberOfVictims
        {
            protected set
            {
                if(value > 0 && value < 10)
                {
                    base.MaxNumberOfVictims = value;
                } else
                {
                    base.MaxNumberOfVictims = 8;
                }
            }
            get
            {
                return base.HoursNeededToSleep;
            }
        }

    }
}
