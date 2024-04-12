using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace oyun
{
    public partial class Form1 : Form
    {
        int xal = 12;
        int total = 0;
        string p1 ="pisik";
        string p2 = "panter";
        string p3 = "suiti";
        string p4 = "yaquar";
        string p5 = "qus";
        int rInt = 0;
        Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Visible = false;
            if (button1.Visible = false) ;
            {
                xal -= 1;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button3.Visible = false;
            if (button3.Visible = false) ;
            {
                xal -= 1;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                rInt = random.Next(1, 5);

                string path = @"C:\Users\student\Desktop\pictures\";
                pictureBox1.Image = Image.FromFile(path + rInt.ToString() + ".png");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button2.Visible = false;
            if (button2.Visible = false) ;
            {
                xal -= 1;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button4.Visible = false;
            if (button4.Visible = false) ;
            {
                xal -= 1;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button5.Visible = false;
            if (button5.Visible = false) ;
            {
                xal -= 1;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button6.Visible = false;
            if (button6.Visible = false) ;
            {
                xal -= 1;
            }
        }
            

        private void button7_Click(object sender, EventArgs e)
        {
            button7.Visible = false;
            if (button7.Visible = false) ;
            {
                xal -= 1;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            button8.Visible = false;
            if (button8.Visible = false) ;
            {
                xal -= 1;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            button9.Visible = false;
            if (button9.Visible = false) ;
            {
                xal -= 1;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            button10.Visible = false;
            if (button10.Visible = false) ;
            {
                xal -= 1;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            button11.Visible = false;
            if (button11.Visible = false) ;
            {
                xal -= 1;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            button12.Visible = false;
            if (button11.Visible = false) ;
            {
                xal -= 1;
            }

        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (( rInt == 1 && textBox1.Text == p1) || (rInt == 2 && textBox1.Text == p2)|| (rInt == 3 && textBox1.Text == p3)|| (rInt == 4 && textBox1.Text == p4)|| (rInt == 5 && textBox1.Text == p5))
            {
                 MessageBox.Show("Doğrudur!Xalınız:" + xal);
                total += xal;
            }
            else
            {
                MessageBox.Show("Yalnışdır");
            }
            rInt = random.Next(1, 5);
            string path = @"C:\Users\student\Desktop\pictures\";
            pictureBox1.Image = Image.FromFile(path + rInt.ToString() + ".png");
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button7.Visible = true;
            button8.Visible = true;
            button9.Visible = true;
            button10.Visible = true;
            button11.Visible = true;
            button12.Visible = true;
            textBox1.Clear();
            
            xal = 12;
            label2.Text = total.ToString();

        }


    }

}


