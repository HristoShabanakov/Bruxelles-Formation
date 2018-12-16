using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo10_NombreMystere
{
    public partial class Form1 : Form
    {
        int nombreMystere;
        int compteur;
        int nombreDeSecondeRestante;

        public Form1()
        {
            InitializeComponent();
            Reset();
        }

        void Reset()
        {
            Random objetRandom = new Random();
            nombreMystere = objetRandom.Next(99) + 1;
            Console.WriteLine(nombreMystere);
            compteur = 0;
            button1.Text = "Essai";
            nombreDeSecondeRestante = 10;
            timer1.Enabled = true;
            label1.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(button1.Text=="Essai")
            {
                compteur++;
                nombreDeSecondeRestante = 10;
                if (Int32.Parse(textBox1.Text) == nombreMystere)
                {
                    label1.Text = "Bravo, vous avez trouvé en " + compteur.ToString() + " fois";
                    button1.Text = "Rejouer";
                    timer1.Enabled = false;
                }
                if (Int32.Parse(textBox1.Text) < nombreMystere)
                {
                    label1.Text = "Trop petit";
                }
                if (Int32.Parse(textBox1.Text) > nombreMystere)
                {
                    label1.Text = "Trop grand";
                }
            }
            else
            {
                Reset();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label4.Text = nombreDeSecondeRestante.ToString() + " S";
            if (nombreDeSecondeRestante < 5) label4.ForeColor = Color.Red;
            else label4.ForeColor = Color.Black;
            nombreDeSecondeRestante--;
            if (nombreDeSecondeRestante==0)
            {
                compteur++;
                nombreDeSecondeRestante = 10;
            }
        }
    }
}
