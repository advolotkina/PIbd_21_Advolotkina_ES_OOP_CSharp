using System.Drawing;

namespace ULSTU_OOP_SCharp_Lab3
{
    public interface IAnimal
    {
        void move(Graphics g);

        void draw(Graphics g);

        void setPosition(int x, int y);

        void eat(int count);

        void sleep(int count);

        void breath();

        void makeNoise();

        void setMainColor(Color color);

        string getInfo();
    }
}
