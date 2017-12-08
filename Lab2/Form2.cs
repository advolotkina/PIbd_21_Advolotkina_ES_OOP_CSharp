using System;
using System.Drawing;
using System.Windows.Forms;

namespace ULSTU_OOP_SCharp_Lab3
{
    public partial class Form2 : Form
    {
        Ocean ocean;

        FormSelectShark form;
        public Form2()
        {
            InitializeComponent();
            ocean = new Ocean(5);
            for (int i = 1; i < 6; i++)
            {
                listBox1.Items.Add("Уровень " + i);
            }
            listBox1.SelectedIndex = ocean.getCurrentLevel;

            Draw();
        }
     
        private void Draw()
        {
            if (listBox1.SelectedIndex > -1)
            { 
                Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
                Graphics gr = Graphics.FromImage(bmp);
                ocean.Draw(gr);
                pictureBox1.Image = bmp;
            }

            //Bitmap bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            //Graphics gr = Graphics.FromImage(bmp);
            //ocean.Draw(gr, pictureBox1.Width, pictureBox1.Height);
            //pictureBox1.Image = bmp;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form = new FormSelectShark();
            form.AddEvent(AddShark);
            form.Show();

            //ColorDialog cd = new ColorDialog();
            //if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    var fish = new Shark(10, 10, 300, cd.Color);
            //    int place = ocean.PutFishInOcean(fish);

            //    Draw();
            //    MessageBox.Show("Ваше место: " + place);

            //}
        }

        private void AddShark(IAnimal shark)
        {
            if (shark != null)
            {
                int place = ocean.PutFishInOcean(shark);
                if (place > -1)
                {
                    Draw();
                    MessageBox.Show("Ваше место: " + place);
                }
                else
                {
                    MessageBox.Show("Акулу не удалось выпустить");
                }
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
            if (listBox1.SelectedIndex > -1)
            {
                string level = listBox1.Items[listBox1.SelectedIndex].ToString();
                if (maskedTextBox1.Text != "")
                {
                    IAnimal fish = ocean.GetFishFromOcean(Convert.ToInt32(maskedTextBox1.Text));
                    if (fish != null)
                    {
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        fish.setPosition(5, 5);
                        fish.draw(gr);
                        pictureBox2.Image = bmp;
                        Draw();
                    }
                    else
                    {
                        MessageBox.Show("Извинте, на этом месте нет акулы");
                    }
                }
            }

            //if (maskedTextBox1.Text != "" )
            //{
            //    var fish = ocean.GetFishFromOcean(Convert.ToInt32(maskedTextBox1.Text));
            //    if (fish != null)
            //    {
            //    Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            //    Graphics gr = Graphics.FromImage(bmp);
            //    fish.setPosition(40, 20);
            //    fish.draw(gr);
            //    pictureBox2.Image = bmp;
            //    Draw();
            //    }

            //}
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            ocean.LevelDown();
            listBox1.SelectedIndex = ocean.getCurrentLevel;
            Draw();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            ocean.LevelUp();
            listBox1.SelectedIndex = ocean.getCurrentLevel;
            Draw();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (ocean.SaveData(saveFileDialog1.FileName))
                {
                    MessageBox.Show("Сохранение прошло успешно", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не сохранилось", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                if (ocean.LoadData(openFileDialog1.FileName))
                {
                    MessageBox.Show("Загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Не загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                Draw();
            }

        }
    }
}
