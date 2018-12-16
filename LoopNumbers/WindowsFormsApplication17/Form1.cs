using System;
using System.Windows.Forms;

namespace WindowsFormsApplication17
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {



            for (int i = 1; i <= 50; i++)
            {

                richTextBox1.Text += i.ToString() + " \n ";

            }
        }
    }
}
