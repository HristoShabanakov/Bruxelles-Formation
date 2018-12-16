using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo5b
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
            // Ici je déclare une variable x de type entier
            int x = 0;
            x = Int32.Parse(textBox1.Text);
            int y;
            y = Int32.Parse(textBox2.Text);
            int somme;
            somme = x + y;
            label4.Text = somme.ToString();
        }
    }
}
