using System;
using System.Drawing;
using System.Windows.Forms;

namespace ULSTU_OOP_SCharp_Lab3
{
    public partial class Form2 : Form
    {
        Ocean ocean;
        public Form2()
        {
            InitializeComponent();
            ocean = new Ocean();
            Draw();
        }
     
        private void Draw()
        {
            Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            Graphics gr = Graphics.FromImage(bmp);
            ocean.Draw(gr, pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = bmp;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                var fish = new Shark(10, 10, 300, cd.Color);
                int place = ocean.PutFishInOcean(fish);
               
                Draw();
                MessageBox.Show("Ваше место: " + place);

            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == DialogResult.OK)
            {
                ColorDialog cdDop = new ColorDialog();
                if (cdDop.ShowDialog() == DialogResult.OK)
                {
                    var fish = new TigerShark(10, 10, 300, cd.Color, cdDop.Color);
                    int place = ocean.PutFishInOcean(fish);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text != "" )
            {
                var fish = ocean.GetFishFromOcean(Convert.ToInt32(maskedTextBox1.Text));
                if (fish != null)
                {
                Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                Graphics gr = Graphics.FromImage(bmp);
                fish.setPosition(40, 20);
                fish.draw(gr);
                pictureBox2.Image = bmp;
                Draw();
                }
                
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
