using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo6_F2C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int degreF;
            degreF = Int32.Parse(textBox1.Text);
            double degreC;
            degreC = (degreF - 32) / 1.8;
            label1.Text = degreC.ToString();
        }
    }
}
