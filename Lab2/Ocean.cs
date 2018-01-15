using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

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
            int i = 0;
            foreach(var shark in oceanLevels[currentLevel])
            {
                shark.setPosition(15 + (int)i / 5 * placeSizeWidth + 5, i % 5 * placeSizeHeight + 15);
                shark.draw(g);
                i++;
            }
        }

        public void Sort()
        {
            oceanLevels.Sort();
        }

        public bool SaveData(string fileName)
        {
            if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            using (FileStream fs = new FileStream(fileName, FileMode.Create))
            {
                using(BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] info = new UTF8Encoding(true).GetBytes("CountLevels:" + oceanLevels.Count + Environment.NewLine);
                    fs.Write(info, 0, info.Length);
                    foreach(var level in oceanLevels)
                    {
                        info = new UTF8Encoding(true).GetBytes("Level" + Environment.NewLine);
                        fs.Write(info, 0, info.Length);
                        for(int i = 0; i < countPlaces; i++)
                        {
                            var shark = level[i];
                            if (shark != null)
                            {
                                if(shark.GetType().Name == "Shark")
                                {
                                    info = new UTF8Encoding(true).GetBytes("Shark:");
                                    fs.Write(info, 0, info.Length);
                                }
                                if(shark.GetType().Name == "TigerShark")
                                {
                                    info = new UTF8Encoding(true).GetBytes("TigerShark:");
                                    fs.Write(info, 0, info.Length);
                                }
                                info = new UTF8Encoding(true).GetBytes(shark.getInfo() + Environment.NewLine);
                                fs.Write(info, 0, info.Length);
                            }
                        }
                    }
                }
            }
            return true;
        }

        public bool LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                return false;
            }
            using(FileStream fs = new FileStream(filename, FileMode.Open))
            {
                string s = "";
                using(BufferedStream bs = new BufferedStream(fs))
                {
                    byte[] b = new byte[fs.Length];
                    UTF8Encoding temp = new UTF8Encoding(true);
                    while (bs.Read(b, 0, b.Length) > 0)
                    {
                        s += temp.GetString(b);
                    }
                }
                s = s.Replace("\r", "");
                var strs = s.Split('\n');
                if (strs[0].Contains("CountLevels"))
                {
                    int count = Convert.ToInt32(strs[0].Split(':')[1]);
                    if (oceanLevels != null)
                    {
                        oceanLevels.Clear();
                    }
                    oceanLevels = new List<ClassArray<IAnimal>>(count);
                }
                else
                {
                    throw new FileFormatException();
                }
                int counter = -1;
                for(int i = 1; i < strs.Length; ++i)
                {
                    if (strs[i] == "Level")
                    {
                        counter++;
                        oceanLevels.Add(new ClassArray<IAnimal>(countPlaces, null));
                    } else if (strs[i].Split(':')[0] == "Shark")
                    {
                        IAnimal shark = new Shark(strs[i].Split(':')[1]);
                        int number = oceanLevels[counter] + shark;
                        if(number == -1)
                        {
                            throw new FileFormatException();
                        }
                    } else if (strs[i].Split(':')[0] == "TigerShark")
                    {
                        IAnimal shark = new TigerShark(strs[i].Split(':')[1]);
                        int number = oceanLevels[counter] + shark;
                        if (number == -1)
                        {
                            throw new FileFormatException();
                        }
                    }
                }
            }
            return true;
        }

    }
}
