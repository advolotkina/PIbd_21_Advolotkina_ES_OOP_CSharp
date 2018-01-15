using NLog;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ULSTU_OOP_SCharp_Lab3
{
    public partial class Form2 : Form
    {
        Ocean ocean;

        FormSelectShark form;

        private Logger log;
        public Form2()
        {
            InitializeComponent();
            log = LogManager.GetCurrentClassLogger();
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

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            form = new FormSelectShark();
            form.AddEvent(AddShark);
            form.Show();
            log.Info("Вызвана форма добавления акулы");
        }

        private void AddShark(IAnimal shark)
        {
            if (shark != null)
            {
                try
                {
                    int place = ocean.PutFishInOcean(shark);
                    Draw();
                    MessageBox.Show("Ваше место: " + place);

                }
                catch(OceanOverflowExcetion ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка переполнения", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                if (maskedTextBox1.Text != "")
                {
                    try {
                        IAnimal fish = ocean.GetFishFromOcean(Convert.ToInt32(maskedTextBox1.Text));
                        Bitmap bmp = new Bitmap(pictureBox2.Width, pictureBox2.Height);
                        Graphics gr = Graphics.FromImage(bmp);
                        fish.setPosition(5, 5);
                        fish.draw(gr);
                        pictureBox2.Image = bmp;
                        Draw();
                        log.Info("Забрали акулу");
                    }
                    catch(OceanIndexOutOfRangeException ex)
                    {
                        MessageBox.Show(ex.Message, "Неверный номер", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Общая ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void buttonDown_Click(object sender, EventArgs e)
        {
            ocean.LevelDown();
            listBox1.SelectedIndex = ocean.getCurrentLevel;
            log.Info("Переход на уровень ниже. Текущий уровень: " + ocean.getCurrentLevel);
            Draw();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            ocean.LevelUp();
            listBox1.SelectedIndex = ocean.getCurrentLevel;
            log.Info("Переход на уровень выше. Текущий уровень: " + ocean.getCurrentLevel);
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
                try
                {
                    ocean.LoadData(openFileDialog1.FileName);
                } catch(FileFormatException ex)
                {
                    MessageBox.Show(ex.Message, "Неверный формат загружаемого файла");
                    return;
                }
                MessageBox.Show("Загрузили", "",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                Draw();
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ocean.Sort();
            Draw();
        }
    }
}
