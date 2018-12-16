using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationDebugger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Récupération des données
            string contenuTextBox1 = textBox1.Text;

            // Calcul
            int resultatDuParse;
            bool estCeQueCaABienParse;
            estCeQueCaABienParse = int.TryParse(contenuTextBox1, out resultatDuParse);

            // Affichage
            if (estCeQueCaABienParse)
                textBox2.Text = (resultatDuParse + 10).ToString();
            else
                textBox2.Text = "Utilisateur n'a pas bien tout compris";
        }
     }
}
