using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            textBox1.Text = "15";
            textBox2.Text = "15";
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label6.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
            button9.Visible = false;
            button9.Visible = false;
            button10.Visible = true;
            textBox1.Visible = false;
            textBox2.Visible = false;
            dataGridView1.Visible = false;
            this.Size = new Size(460, 300);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            dataGridView1.RowCount = y;
            dataGridView1.ColumnCount = x;
            for (int i = 0; i < x; i++)
            {
                dataGridView1.Columns[i].Width = 24;
            }
            for (int i = 0; i < y; i++)
            {
                dataGridView1.Rows[i].Height = 20;
            }
          
        }

        private void button2_Click(object sender, EventArgs e)
        {   int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            int[,] a = new int[x, y]; int sum = 0;
            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < y; i++)
                {
                    a[i, j] = int.Parse(dataGridView1[i,j].Value.ToString());
                  
                    if (a[0, j] == 1)
                    {
                          sum +=  a[i, j];
                    } 
                } if (a[0, j] == 1)
                {
                    MessageBox.Show(Convert.ToString("средне арифметическое значение = " + sum/x), 
                        "Тюлемисова Дана",MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                }sum = 0;
            } 
            for (int j = 0; j < x; j++)
            {
                if (a[0, j] == 1)
                {MessageBox.Show("Строка - " + Convert.ToString(j + 1) + " начинается с единицы", 
                    "Тюлемисова Дана", MessageBoxButtons.OKCancel, MessageBoxIcon.Information); }
                else
                { MessageBox.Show(Convert.ToString(j + 1) + " - строка начинается не с единицы",
                    "Тюлемисова Дана", MessageBoxButtons.OKCancel, MessageBoxIcon.Error); }}}


        private void button4_Click(object sender, EventArgs e)
        {  int x = Convert.ToInt32(textBox1.Text);
            int y = Convert.ToInt32(textBox2.Text);
            Random Ra = new Random();
            for (int w = 0; w < x; w++)
            {
                for (int r = 0; r < y; r++)
                { dataGridView1[w, r].Value = Ra.Next(-50, 50); }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.BackColor = Color.Yellow;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.GreenYellow;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DodgerBlue;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkViolet;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.HotPink;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label6.Left < this.Width)
            { label6.Left += 2; }
            else
            { label6.Left = -label6.Width; }

        }

        private void Form1_Activated(object sender, EventArgs e)
        {
        
        }

        private void Form1_Activated_1(object sender, EventArgs e)
        {
         
        }

        private void button10_Click(object sender, EventArgs e)
        {
            
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label6.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = false;
            textBox1.Visible = true;
            textBox2.Visible = true;
            dataGridView1.Visible = true;
            timer1.Start();
            this.Size = new Size(650, 550); 
                   }
    }
}
