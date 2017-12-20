using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ULSTU_OOP_SCharp_Lab3
{
    public partial class FormSelectShark : Form
    {
        IAnimal shark = null;

        public IAnimal getShark { get { return shark; } }

        private void DrawShark()
        {
            if (shark != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxShark.Width, pictureBoxShark.Height);
                Graphics gr = Graphics.FromImage(bmp);
                shark.setPosition(10, 10);
                shark.draw(gr);
                pictureBoxShark.Image = bmp;
            }
        }

        private event myDel eventAddShark;

        public void AddEvent(myDel ev)
        {
            if (eventAddShark == null)
            {
                eventAddShark = new myDel(ev);
            }
            else
            {
                eventAddShark += ev;
            }
        }

        public FormSelectShark()
        {
            InitializeComponent();
            panelBlack.MouseDown += panelColor_MouseDown;
            panelOrange.MouseDown += panelColor_MouseDown;
            panelGray.MouseDown += panelColor_MouseDown;
            panelGreen.MouseDown += panelColor_MouseDown;
            panelRed.MouseDown += panelColor_MouseDown;
            panelWhite.MouseDown += panelColor_MouseDown;
            panelYellow.MouseDown += panelColor_MouseDown;
            panelBlue.MouseDown += panelColor_MouseDown;

            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
        }

        private void labelShark_MouseDown(object sender, MouseEventArgs e)
        {
            labelShark.DoDragDrop(labelShark.Text,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelTigerShark_MouseDown(object sender, MouseEventArgs e)
        {
            labelTigerShark.DoDragDrop(labelTigerShark.Text, DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void panelShark_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void panelShark_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Акула":
                    shark = new Shark(10, 10, 300, Color.White);
                    break;
                case "Тигровая акула":
                    shark = new TigerShark(10, 10, 300, Color.White,  Color.Black);
                    break;
            }
            DrawShark();
        }

        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            (sender as Control).DoDragDrop((sender as Control).BackColor,
                DragDropEffects.Move | DragDropEffects.Copy);
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
                e.Effect = DragDropEffects.Copy;
            else
                e.Effect = DragDropEffects.None;
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            if (shark != null)
            {
                shark.setMainColor((Color)e.Data.GetData(typeof(Color)));
                DrawShark();
            }
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (shark != null)
            {
                if (shark is TigerShark)
                {
                    (shark as TigerShark).setDopColor((Color)e.Data.GetData(typeof(Color)));
                    DrawShark();
                }
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            if (eventAddShark != null)
            {
                eventAddShark(shark);
            }
            Close();
        }

        private void buttonOk_Click_1(object sender, EventArgs e)
        {
            if (eventAddShark != null)
            {
                eventAddShark(shark);
            }
            Close();
        }

        private void labelDopColor_DragEnter(object sender, DragEventArgs e)
        {

        }
    }
}
