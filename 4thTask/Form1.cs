using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4thTask
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Width == 100 && button1.Height == 100)
            {
                button1.Width = 200;
                button1.Height = 200;
                button1.BackColor = Color.Red;
            }
            else
            {
                button1.Width = 100;
                button1.Height = 100;
                button1.BackColor = Color.Green;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.HotPink;
            if (button2.Location == new Point(500, 47))
            {
                button2.Location = new Point(400, 47);
            }
            else
            {
                button2.Location = new Point(500, 47);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.BackColor = Color.MediumPurple;
            button3.Left += 20;
            if (button3.Location == new Point(500, 260))
            {
                button3.Location = new Point(100, 260);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "D")
            {
                button4.Text = "d";
                button4.BackColor = Color.Aqua;
            }
            else
            {
                button4.Text ="D";
                button4.BackColor = Color.Teal;
            }
        }
    }
}
