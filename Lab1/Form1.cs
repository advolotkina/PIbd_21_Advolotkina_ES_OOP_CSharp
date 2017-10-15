using System;
using System.Windows.Forms;

namespace ULSTU_OOP_Csharp_HomeLab1
{
    public partial class Form1 : Form
    {
        private Egg[] eggs;

        private Salt salt;

        private Pepper pepper;

        private WaterTap waterTap;

        private Fork fork;

        private Pan pan;

        private Stove stove;

        private Oil[] oil;

        public Form1()
        {
            InitializeComponent();
            waterTap = new WaterTap();
            fork = new Fork();
            pan = new Pan();
            stove = new Stove();
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.numericUpDownOil = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownPepper = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownSalt = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownEggs = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonBreakEggs = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.buttonGetEggs = new System.Windows.Forms.Button();
            this.buttonAddPepper = new System.Windows.Forms.Button();
            this.buttonAddSalt = new System.Windows.Forms.Button();
            this.buttonAddEggs = new System.Windows.Forms.Button();
            this.buttonAddOil = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.buttonGetPan = new System.Windows.Forms.Button();
            this.buttonCook = new System.Windows.Forms.Button();
            this.buttonAddPan = new System.Windows.Forms.Button();
            this.checkBoxOn = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonWash = new System.Windows.Forms.Button();
            this.radioButtonClose = new System.Windows.Forms.RadioButton();
            this.radioButtonOpen = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPepper)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEggs)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox1.Controls.Add(this.numericUpDownOil);
            this.groupBox1.Controls.Add(this.numericUpDownPepper);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numericUpDownSalt);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.numericUpDownEggs);
            this.groupBox1.Font = new System.Drawing.Font("Minsk", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(320, 286);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ингредиенты";
            // 
            // numericUpDownOil
            // 
            this.numericUpDownOil.Location = new System.Drawing.Point(234, 91);
            this.numericUpDownOil.Name = "numericUpDownOil";
            this.numericUpDownOil.Size = new System.Drawing.Size(63, 33);
            this.numericUpDownOil.TabIndex = 13;
            this.numericUpDownOil.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDownPepper
            // 
            this.numericUpDownPepper.Location = new System.Drawing.Point(234, 195);
            this.numericUpDownPepper.Name = "numericUpDownPepper";
            this.numericUpDownPepper.Size = new System.Drawing.Size(63, 33);
            this.numericUpDownPepper.TabIndex = 12;
            this.numericUpDownPepper.ValueChanged += new System.EventHandler(this.numericUpDown6_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.SeaShell;
            this.label6.Font = new System.Drawing.Font("Minsk", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(18, 197);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 25);
            this.label6.TabIndex = 11;
            this.label6.Text = "Перец";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // numericUpDownSalt
            // 
            this.numericUpDownSalt.Location = new System.Drawing.Point(234, 140);
            this.numericUpDownSalt.Name = "numericUpDownSalt";
            this.numericUpDownSalt.Size = new System.Drawing.Size(63, 33);
            this.numericUpDownSalt.TabIndex = 10;
            this.numericUpDownSalt.ValueChanged += new System.EventHandler(this.numericUpDown5_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.SeaShell;
            this.label5.Font = new System.Drawing.Font("Minsk", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(18, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 9;
            this.label5.Text = "Соль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.SeaShell;
            this.label2.Font = new System.Drawing.Font("Minsk", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(16, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Масло";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.SeaShell;
            this.label1.Font = new System.Drawing.Font("Minsk", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Яйца";
            // 
            // numericUpDownEggs
            // 
            this.numericUpDownEggs.Location = new System.Drawing.Point(234, 45);
            this.numericUpDownEggs.Name = "numericUpDownEggs";
            this.numericUpDownEggs.Size = new System.Drawing.Size(63, 33);
            this.numericUpDownEggs.TabIndex = 1;
            this.numericUpDownEggs.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox2.Controls.Add(this.buttonBreakEggs);
            this.groupBox2.Font = new System.Drawing.Font("Minsk", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(351, 234);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(275, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Вилка";
            // 
            // buttonBreakEggs
            // 
            this.buttonBreakEggs.BackColor = System.Drawing.Color.SeaShell;
            this.buttonBreakEggs.Font = new System.Drawing.Font("Minsk", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBreakEggs.Location = new System.Drawing.Point(53, 32);
            this.buttonBreakEggs.Name = "buttonBreakEggs";
            this.buttonBreakEggs.Size = new System.Drawing.Size(158, 55);
            this.buttonBreakEggs.TabIndex = 0;
            this.buttonBreakEggs.Text = "Разбить яйца";
            this.buttonBreakEggs.UseVisualStyleBackColor = false;
            this.buttonBreakEggs.Click += new System.EventHandler(this.buttonBreakEggs_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox4.Controls.Add(this.buttonGetEggs);
            this.groupBox4.Controls.Add(this.buttonAddPepper);
            this.groupBox4.Controls.Add(this.buttonAddSalt);
            this.groupBox4.Controls.Add(this.buttonAddEggs);
            this.groupBox4.Controls.Add(this.buttonAddOil);
            this.groupBox4.Font = new System.Drawing.Font("Minsk", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(641, 48);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(309, 617);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Сковорода";
            // 
            // buttonGetEggs
            // 
            this.buttonGetEggs.BackColor = System.Drawing.Color.SeaShell;
            this.buttonGetEggs.Enabled = false;
            this.buttonGetEggs.Location = new System.Drawing.Point(40, 459);
            this.buttonGetEggs.Name = "buttonGetEggs";
            this.buttonGetEggs.Size = new System.Drawing.Size(225, 64);
            this.buttonGetEggs.TabIndex = 4;
            this.buttonGetEggs.Text = "Получить яичницу";
            this.buttonGetEggs.UseVisualStyleBackColor = false;
            this.buttonGetEggs.Click += new System.EventHandler(this.buttonGetEggs_Click);
            // 
            // buttonAddPepper
            // 
            this.buttonAddPepper.BackColor = System.Drawing.Color.SeaShell;
            this.buttonAddPepper.Enabled = false;
            this.buttonAddPepper.Location = new System.Drawing.Point(42, 363);
            this.buttonAddPepper.Name = "buttonAddPepper";
            this.buttonAddPepper.Size = new System.Drawing.Size(225, 64);
            this.buttonAddPepper.TabIndex = 3;
            this.buttonAddPepper.Text = "Добавить перец";
            this.buttonAddPepper.UseVisualStyleBackColor = false;
            this.buttonAddPepper.Click += new System.EventHandler(this.buttonAddPepper_Click);
            // 
            // buttonAddSalt
            // 
            this.buttonAddSalt.BackColor = System.Drawing.Color.SeaShell;
            this.buttonAddSalt.Enabled = false;
            this.buttonAddSalt.Location = new System.Drawing.Point(42, 276);
            this.buttonAddSalt.Name = "buttonAddSalt";
            this.buttonAddSalt.Size = new System.Drawing.Size(225, 64);
            this.buttonAddSalt.TabIndex = 2;
            this.buttonAddSalt.Text = "Добавить соль";
            this.buttonAddSalt.UseVisualStyleBackColor = false;
            this.buttonAddSalt.Click += new System.EventHandler(this.buttonAddSalt_Click);
            // 
            // buttonAddEggs
            // 
            this.buttonAddEggs.BackColor = System.Drawing.Color.SeaShell;
            this.buttonAddEggs.Enabled = false;
            this.buttonAddEggs.Location = new System.Drawing.Point(40, 140);
            this.buttonAddEggs.Name = "buttonAddEggs";
            this.buttonAddEggs.Size = new System.Drawing.Size(225, 64);
            this.buttonAddEggs.TabIndex = 1;
            this.buttonAddEggs.Text = "Добавить яйца";
            this.buttonAddEggs.UseVisualStyleBackColor = false;
            this.buttonAddEggs.Click += new System.EventHandler(this.buttonAddEggs_Click);
            // 
            // buttonAddOil
            // 
            this.buttonAddOil.BackColor = System.Drawing.Color.SeaShell;
            this.buttonAddOil.Location = new System.Drawing.Point(40, 54);
            this.buttonAddOil.Name = "buttonAddOil";
            this.buttonAddOil.Size = new System.Drawing.Size(225, 64);
            this.buttonAddOil.TabIndex = 0;
            this.buttonAddOil.Text = "Залить масло";
            this.buttonAddOil.UseVisualStyleBackColor = false;
            this.buttonAddOil.Click += new System.EventHandler(this.buttonAddOil_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox5.Controls.Add(this.buttonGetPan);
            this.groupBox5.Controls.Add(this.buttonCook);
            this.groupBox5.Controls.Add(this.buttonAddPan);
            this.groupBox5.Controls.Add(this.checkBoxOn);
            this.groupBox5.Font = new System.Drawing.Font("Minsk", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox5.Location = new System.Drawing.Point(12, 360);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(320, 305);
            this.groupBox5.TabIndex = 4;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Плита";
            // 
            // buttonGetPan
            // 
            this.buttonGetPan.BackColor = System.Drawing.Color.SeaShell;
            this.buttonGetPan.Enabled = false;
            this.buttonGetPan.Font = new System.Drawing.Font("Minsk", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonGetPan.Location = new System.Drawing.Point(46, 229);
            this.buttonGetPan.Name = "buttonGetPan";
            this.buttonGetPan.Size = new System.Drawing.Size(216, 41);
            this.buttonGetPan.TabIndex = 3;
            this.buttonGetPan.Text = "Убрать сковороду";
            this.buttonGetPan.UseVisualStyleBackColor = false;
            this.buttonGetPan.Click += new System.EventHandler(this.buttonGetPan_Click);
            // 
            // buttonCook
            // 
            this.buttonCook.BackColor = System.Drawing.Color.SeaShell;
            this.buttonCook.Enabled = false;
            this.buttonCook.Font = new System.Drawing.Font("Minsk", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonCook.Location = new System.Drawing.Point(46, 147);
            this.buttonCook.Name = "buttonCook";
            this.buttonCook.Size = new System.Drawing.Size(216, 41);
            this.buttonCook.TabIndex = 2;
            this.buttonCook.Text = "Готовить";
            this.buttonCook.UseVisualStyleBackColor = false;
            this.buttonCook.Click += new System.EventHandler(this.buttonCook_Click);
            // 
            // buttonAddPan
            // 
            this.buttonAddPan.BackColor = System.Drawing.Color.SeaShell;
            this.buttonAddPan.Font = new System.Drawing.Font("Minsk", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddPan.Location = new System.Drawing.Point(46, 89);
            this.buttonAddPan.Name = "buttonAddPan";
            this.buttonAddPan.Size = new System.Drawing.Size(216, 41);
            this.buttonAddPan.TabIndex = 1;
            this.buttonAddPan.Text = "Поставить сковороду";
            this.buttonAddPan.UseVisualStyleBackColor = false;
            this.buttonAddPan.Click += new System.EventHandler(this.buttonAddPan_Click);
            // 
            // checkBoxOn
            // 
            this.checkBoxOn.AutoSize = true;
            this.checkBoxOn.BackColor = System.Drawing.Color.SeaShell;
            this.checkBoxOn.Location = new System.Drawing.Point(111, 32);
            this.checkBoxOn.Name = "checkBoxOn";
            this.checkBoxOn.Size = new System.Drawing.Size(71, 29);
            this.checkBoxOn.TabIndex = 0;
            this.checkBoxOn.Text = "Вкл";
            this.checkBoxOn.UseVisualStyleBackColor = false;
            this.checkBoxOn.CheckedChanged += new System.EventHandler(this.checkBoxOn_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(351, 360);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 305);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.PeachPuff;
            this.groupBox3.Controls.Add(this.buttonWash);
            this.groupBox3.Controls.Add(this.radioButtonClose);
            this.groupBox3.Controls.Add(this.radioButtonOpen);
            this.groupBox3.Font = new System.Drawing.Font("Minsk", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(351, 48);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(275, 165);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Кран";
            // 
            // buttonWash
            // 
            this.buttonWash.BackColor = System.Drawing.Color.SeaShell;
            this.buttonWash.Location = new System.Drawing.Point(130, 38);
            this.buttonWash.Name = "buttonWash";
            this.buttonWash.Size = new System.Drawing.Size(125, 86);
            this.buttonWash.TabIndex = 2;
            this.buttonWash.Text = "Помыть скорлупу";
            this.buttonWash.UseVisualStyleBackColor = false;
            this.buttonWash.Click += new System.EventHandler(this.buttonWash_Click);
            // 
            // radioButtonClose
            // 
            this.radioButtonClose.AutoSize = true;
            this.radioButtonClose.Checked = true;
            this.radioButtonClose.Location = new System.Drawing.Point(17, 89);
            this.radioButtonClose.Name = "radioButtonClose";
            this.radioButtonClose.Size = new System.Drawing.Size(105, 29);
            this.radioButtonClose.TabIndex = 1;
            this.radioButtonClose.TabStop = true;
            this.radioButtonClose.Text = "Закрыт";
            this.radioButtonClose.UseVisualStyleBackColor = true;
            this.radioButtonClose.CheckedChanged += new System.EventHandler(this.radioButtonClose_CheckedChanged);
            // 
            // radioButtonOpen
            // 
            this.radioButtonOpen.AutoSize = true;
            this.radioButtonOpen.Location = new System.Drawing.Point(17, 45);
            this.radioButtonOpen.Name = "radioButtonOpen";
            this.radioButtonOpen.Size = new System.Drawing.Size(107, 29);
            this.radioButtonOpen.TabIndex = 0;
            this.radioButtonOpen.Text = "Открыт";
            this.radioButtonOpen.UseVisualStyleBackColor = true;
            this.radioButtonOpen.CheckedChanged += new System.EventHandler(this.radioButtonOpen_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Linen;
            this.ClientSize = new System.Drawing.Size(997, 694);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Кухня";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownOil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPepper)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSalt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEggs)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private void radioButtonOpen_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonOpen.Checked)
            {
                waterTap.State = true;
            }
        }

        private void radioButtonClose_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButtonClose.Checked)
            {
                waterTap.State = false;
            }
        }

        private void buttonWash_Click(object sender, EventArgs e)
        {
            if (numericUpDownEggs.Value > 0)
            {
                if (!waterTap.State)
                {
                    MessageBox.Show("Кран закрыт, как мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                eggs = new Egg[Convert.ToInt32(numericUpDownEggs.Value)];
                pan.Init(Convert.ToInt32(numericUpDownEggs.Value));
                for (int i = 0; i < eggs.Length; ++i)
                {
                    eggs[i] = new Egg();
                }
                for (int i = 0; i < eggs.Length; ++i)
                {
                    eggs[i].Dirty = 0;
                }
                numericUpDownEggs.Enabled = false;
                radioButtonClose.Checked = true;
                MessageBox.Show("Скорлупу помыли, можно разбивать", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Яиц то нет, что мыть?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonBreakEggs_Click(object sender, EventArgs e)
        {
            if (eggs == null)
            {
                MessageBox.Show("Яиц то нет, что разбивать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (eggs.Length == 0)
            {
                MessageBox.Show("Яиц то нет, что разбивать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i].Dirty > 0)
                {
                    MessageBox.Show("Скорлупа грязная!!! Помыть бы ее сначала, а уж потом чистить", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            for (int i = 0; i < eggs.Length; ++i)
            {
                fork.Break(eggs[i]);
            }
            buttonAddEggs.Enabled = true;
            MessageBox.Show("Скорлупу разбили, можно жарить", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddSalt_Click(object sender, EventArgs e)
        {
            salt = new Salt();
            salt.Count = Convert.ToInt32(numericUpDownSalt.Value);
            if (salt.Count > 0)
            {
                pan.AddSalt(salt);
                MessageBox.Show("Соль добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Соли же нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddPepper_Click(object sender, EventArgs e)
        {
            pepper = new Pepper();
            pepper.Count = Convert.ToInt32(numericUpDownPepper.Value);
            if (pepper.Count > 0)
            {
                pan.AddPepper(pepper);
                MessageBox.Show("Перец добавили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Перца же нет, что добавлять?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAddOil_Click(object sender, EventArgs e)
        {
            oil = new Oil[Convert.ToInt32(numericUpDownOil.Value)];
            int oilCount = Convert.ToInt32(numericUpDownOil.Value);
            pan.Init2(oilCount);
            if (oil.Length <= 0)
            {
                MessageBox.Show("Масла нет, что заливать?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            for (int i = 0; i < oil.Length; ++i)
            {
                oil[i] = new Oil();
            }
            for (int i = 0; i < oil.Length; ++i)
            {
                pan.AddOil(oil[i]);
            }
            buttonAddSalt.Enabled = true;
            buttonAddEggs.Enabled = true;

            MessageBox.Show("Масло залили", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddEggs_Click(object sender, EventArgs e)
        {
            if (eggs == null)
            {
                MessageBox.Show("Яиц то нет, что жарить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (eggs.Length == 0)
            {
                MessageBox.Show("Яиц то нет, что жарить собрались?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (oil == null)
            {
                MessageBox.Show("Следует сначала добавить масло.", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (oil.Length <= 0)
            {
                MessageBox.Show("Следует сначала добавить масло.", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!stove.State || !pan.State)
            {
                MessageBox.Show("Следует сначала раскалить масло.", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            for (int i = 0; i < eggs.Length; ++i)
            {
                if (eggs[i].Dirty > 0)
                {
                    MessageBox.Show("Скорлупа грязная!!! Какой ее варить, а ну мыть ее быстро!!!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                if (eggs[i].Have_shell)
                {
                    MessageBox.Show("Для начала следует очистить яйца от скорлупы.", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            for (int i = 0; i < eggs.Length; ++i)
            {
                pan.AddEgg(eggs[i]);
            }
            buttonAddSalt.Enabled = true;
            buttonAddPepper.Enabled = true;
            MessageBox.Show("Яйца добавили.", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonAddPan_Click(object sender, EventArgs e)
        {
            stove.Pan = pan;
            buttonCook.Enabled = true;
            pan.State = true;
            MessageBox.Show("Cковорода на плите", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void checkBoxOn_CheckedChanged(object sender, EventArgs e)
        {
            stove.State = checkBoxOn.Checked;
        }

        private void buttonCook_Click(object sender, EventArgs e)
        {
            if (!pan.ReadyToGo)
            {
                MessageBox.Show("У нас не все готово к жарке!", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!stove.State)
            {
                MessageBox.Show("Жарить собрались энергией космоса или все же включим плиту?", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            stove.Cook();
            if (stove.Pan.IsReady())
            {
                buttonGetPan.Enabled = true;
                buttonGetEggs.Enabled = true;
                checkBoxOn.Checked = false;
                MessageBox.Show("Готова!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Что-то пошло не так, яичница не пожарилась", "Ошибка логики", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void buttonGetPan_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Убрали с плиты", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void buttonGetEggs_Click(object sender, EventArgs e)
        {
            eggs = pan.GetEggs();
            MessageBox.Show("Мы сделали это! Приятного аппетита!", "Кухня", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown numericUpDownEggs;
        private System.Windows.Forms.NumericUpDown numericUpDownPepper;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownSalt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button buttonBreakEggs;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button buttonGetPan;
        private System.Windows.Forms.Button buttonCook;
        private System.Windows.Forms.Button buttonAddPan;
        private System.Windows.Forms.CheckBox checkBoxOn;
        private System.Windows.Forms.NumericUpDown numericUpDownOil;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonGetEggs;
        private System.Windows.Forms.Button buttonAddPepper;
        private System.Windows.Forms.Button buttonAddSalt;
        private System.Windows.Forms.Button buttonAddEggs;
        private System.Windows.Forms.Button buttonAddOil;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonWash;
        private System.Windows.Forms.RadioButton radioButtonClose;
        private System.Windows.Forms.RadioButton radioButtonOpen;
    
    private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown5_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }
    }
}
