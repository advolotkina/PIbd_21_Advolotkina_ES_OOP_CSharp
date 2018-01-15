using System;
using System.Drawing;
using System.Windows.Forms;

namespace ULSTU_OOP_SCharp_Lab3
{
    public partial class Form1 : Form
    {
        Color color;
        Color dopcColor;
        int maxNumberOfVictims;
        int hoursNeededToSleep;
        int weight;

        private IAnimal inter;
        public Form1()
        {
            InitializeComponent();
            color = Color.Gray;
            dopcColor = Color.Black;
            maxNumberOfVictims = 10;
            hoursNeededToSleep = 10;
            weight = 300;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                color = cd.Color;
                button4.BackColor = color;
            }

        }

        private bool checkFields()
        {
            if (!int.TryParse(textBox1.Text, out maxNumberOfVictims))
            {
                return false;
            }
            if (!int.TryParse(textBox2.Text, out hoursNeededToSleep))
            {
                return false;
            }
            if (!int.TryParse(textBox3.Text, out weight))
            {
                return false;
            }
            return true;
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new Shark(maxNumberOfVictims, hoursNeededToSleep, weight, color);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.draw(gr);
                pictureBox1.Image = bmp;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkFields())
            {
                inter = new TigerShark(maxNumberOfVictims, hoursNeededToSleep, weight, color, dopcColor);
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.draw(gr);
                pictureBox1.Image = bmp;
            }


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (inter != null)
            {
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                inter.move(gr);
                pictureBox1.Image = bmp;
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                dopcColor = cd.Color;
                button6.BackColor = dopcColor;
            }

        }
    }
}
