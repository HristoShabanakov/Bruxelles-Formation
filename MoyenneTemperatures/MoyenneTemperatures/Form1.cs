using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoyenneTemperatures
{
    public partial class Form1 : Form
    {
        TextBox[] temperatureTextBox;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int moyenne = 0;
            int temperatureMin = 100;
            int temperatureMax = -100;
            for (int i = 0; i < 7; i++)
            {
                moyenne = moyenne + Int32.Parse(temperatureTextBox[i].Text);
                if (Int32.Parse(temperatureTextBox[i].Text) > temperatureMax) temperatureMax = Int32.Parse(temperatureTextBox[i].Text);
                if (Int32.Parse(temperatureTextBox[i].Text) < temperatureMin) temperatureMin = Int32.Parse(temperatureTextBox[i].Text);
            }
            moyenne = moyenne / 7;
            label5.Text = moyenne.ToString();
            label4.Text = temperatureMin.ToString();
            label6.Text = temperatureMax.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            temperatureTextBox = new TextBox[7];
            Random rnd = new Random();

            for (int i = 0; i < 7; i++)
            {
                temperatureTextBox[i] = new TextBox();
                temperatureTextBox[i].Location = new Point(15, 25*i +15);
                temperatureTextBox[i].Width = 40;
                temperatureTextBox[i].Text = rnd.Next(0, 25).ToString();
                this.Controls.Add(temperatureTextBox[i]);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
