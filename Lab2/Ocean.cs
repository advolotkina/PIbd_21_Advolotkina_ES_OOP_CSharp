using System;
using System.Collections.Generic;
using System.Drawing;

namespace ULSTU_OOP_SCharp_Lab3
{
    class Ocean
    {
        ClassArray<IAnimal> ocean;

        List<ClassArray<IAnimal>> oceanLevels;

        int currentLevel;

        int countPlaces = 20;

        int placeSizeWidth = 130;

        int placeSizeHeight = 100;

        public int getCurrentLevel
        {
            get
            {
                return currentLevel;
            }
        }

        public Ocean(int countLevels)
        {
            oceanLevels = new List<ClassArray<IAnimal>>();
            for(int i = 0; i < countLevels;i++)
            {
                ocean = new ClassArray<IAnimal>(countPlaces, null);
                oceanLevels.Add(ocean);
            }
            
        }

        public void LevelUp()
        {
            if(currentLevel + 1 < oceanLevels.Count)
            {
                currentLevel++;
            }
        }

        public void LevelDown()
        {
            if (currentLevel > 0)
            {
                currentLevel--;
            }
        }

        public int PutFishInOcean(IAnimal fish)
        {
            return oceanLevels[currentLevel] + fish;
        }

        public IAnimal GetFishFromOcean(int n)
        {
            return oceanLevels[currentLevel] - n;
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

        public void Draw(Graphics g)
        {
            DrawOcean(g);
            for(int i = 0; i < countPlaces; i++)
            {
                var fish = oceanLevels[currentLevel][i];
                if (fish != null)
                {
                    fish.setPosition(15+(int)i/5*placeSizeWidth+5,i%5*placeSizeHeight+15);
                    fish.draw(g);
                }
            }
        }

    }
}
