using System.Drawing;

namespace ULSTU_OOP_SCharp_Lab3
{
    class Ocean
    {
        ClassArray<IAnimal> ocean;

        int countPlaces = 20;

        int placeSizeWidth = 130;

        int placeSizeHeight = 100;

        public Ocean()
        {
            ocean = new ClassArray<IAnimal>(countPlaces, null);
        }

        public int PutFishInOcean(IAnimal fish)
        {
            return ocean + fish;
        }

        public IAnimal GetFishFromOcean(int n)
        {
            return ocean - n;
        }

        private void DrawOcean(Graphics g)
        {
            Pen pen = new Pen(Color.Aqua, 3);
            g.DrawRectangle(pen, 0, 0, 550, 550);
            Brush brush = new SolidBrush(Color.Aquamarine);
            g.FillRectangle(brush,0,0,550,550);
            for (int i = 0; i < countPlaces; i++)
            {
                
                g.DrawEllipse(pen,  (int)i / 5 * placeSizeWidth + 5, i % 5 * placeSizeHeight,placeSizeWidth,placeSizeHeight);
                
            }
        }

        public void Draw(Graphics g, int width, int height)
        {
            DrawOcean(g);
            for(int i = 0; i < countPlaces; i++)
            {
                var fish = ocean.getObject(i);
                if (fish != null)
                {
                    fish.setPosition(15+(int)i/5*placeSizeWidth+5,i%5*placeSizeHeight+15);
                    fish.draw(g);
                }
            }
        }
    }
}
