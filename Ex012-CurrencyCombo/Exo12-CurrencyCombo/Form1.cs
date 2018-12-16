using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exo12_CurrencyCombo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Console.WriteLine("Changement de devise vers " + comboBox1.Text);
            changeCurrency();
        }

        void changeCurrency()
        {
            int montant;
            Int32.TryParse(textBox1.Text, out montant);
            double montantCalcule=0;
            if ((comboBox1.Text == "USD") && (comboBox2.Text == "EUR")) montantCalcule = montant * 1.1;
            if ((comboBox1.Text == "EUR") && (comboBox2.Text == "USD")) montantCalcule = montant * 0.9;
            double montantCalculeEnEntier = Math.Round(montantCalcule);
            label1.Text = montantCalculeEnEntier.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            changeCurrency();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            changeCurrency();
        }
    }
}
