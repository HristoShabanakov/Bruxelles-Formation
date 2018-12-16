using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex03_Variable2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "=>"){
                label2.Text = label1.Text;
                label1.Text = "";
                button1.Text = "<=";
            } else
            {
                label1.Text = label2.Text;
                label2.Text = "";
                button1.Text = "=>";
            }
        
        }
    }
}
