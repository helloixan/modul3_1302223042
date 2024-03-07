using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace modul3_1302223042
{
    public partial class Form1 : Form
    {
        public int num1, num2, num3;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button1.Text;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button4.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button5.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button6.Text;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button7.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button8.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button9.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            label1.Text = label1.Text + "" + button10.Text;
        }

        public void button11_Click(object sender, EventArgs e)
        {
            // tombol +
            if (num1 == 0)
            {
                num1 = int.Parse(label1.Text);
            } else
            {
                num3 = int.Parse(label1.Text);
            }
            label1.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // tombol =
            int result;
            num2 = int.Parse(label1.Text);

            if (num3 == 0)
            {
                result = num1 + num2;
            } 
            else
            {
                result = num1 + num2 + num3;
            }
            label1.Text = result.ToString();
        }
    }
}
