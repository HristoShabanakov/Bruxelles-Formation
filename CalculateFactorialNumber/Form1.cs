using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int factorial(int number)
        {
            int CalculeDufactorial = 1;
            while (number>1)
            {
                CalculeDufactorial = CalculeDufactorial * number;
                number--;
            }
            return CalculeDufactorial;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = factorial(Int32.Parse(textBox1.Text)).ToString();
        }
    }
    
}
