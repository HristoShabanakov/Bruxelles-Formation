using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            // this function clears the richtextbox after each calculation

            for (int j = 1; j <=20; j++)
            {
                richTextBox1.Text += "     " + j.ToString() + " x " + textBox1.Text + " = " + (Int32.Parse(textBox1.Text) * j).ToString()+"\n";
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int i = 1;
            while (i < 10)
            {
                i++;
                richTextBox2.Text += "     " + i.ToString() + " x " + textBox2.Text + " = " + (Int32.Parse(textBox2.Text) * i).ToString() + "\n";
            }
        }
    }
}
