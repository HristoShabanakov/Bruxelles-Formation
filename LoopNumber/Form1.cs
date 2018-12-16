using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i=1; i<=10; i++)
            {
                label1.Text += "     " + i.ToString() + " x " + textBox1.Text +" = "+ (Int32.Parse(textBox1.Text) * i).ToString();
            }
            
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            for (int i = 2; i < 20; i++)
            {
                richTextBox1.Text += "     " + i.ToString() + " x " + richTextBox1.Text + " = " + (Int32.Parse(richTextBox1.Text) * i).ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int j = 2; j < 20; j++)
            {
                richTextBox1.Text += "     " + j.ToString() + " x " + richTextBox1.Text + " = " + (Int32.Parse(richTextBox1.Text) * j).ToString();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
