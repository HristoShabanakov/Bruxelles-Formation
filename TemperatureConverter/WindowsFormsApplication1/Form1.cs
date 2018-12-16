using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBoxInput.Text = "0";
            comboBoxInputUnit.SelectedItem = "C";
            comboBoxOutputUnit.SelectedItem = "K";
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            convertTemperature();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            convertTemperature();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            convertTemperature();
        }

        //Convertit la température entrée dans le textbox selon les
        //unités indiquées dans les combobox
        private void convertTemperature()
        {
            double inputValue = 0;

            if (double.TryParse(textBoxInput.Text,out inputValue))
            {
                Temperature temp = new Temperature();

                if(comboBoxInputUnit.Text == "C")
                {
                    temp.Celcius = inputValue;
                }
                if (comboBoxInputUnit.Text == "K")
                {
                    temp.Kelvin = inputValue;
                }
                if (comboBoxInputUnit.Text == "F")
                {
                    temp.Fahrenheit = inputValue;
                }
                if (comboBoxOutputUnit.Text == "C")
                {
                    labelOutput.Text = temp.Celcius.ToString();
                }
                if (comboBoxOutputUnit.Text == "K")
                {
                    labelOutput.Text = temp.Kelvin.ToString();
                }
                if (comboBoxOutputUnit.Text == "F")
                {
                    labelOutput.Text = temp.Fahrenheit.ToString();
                }
            }
            else
            {
                labelOutput.Text = "Wrong Input !";
            }
        }

        private void labelOutput_SizeChanged(object sender, EventArgs e)
        {
            labelOutput.Left = comboBoxOutputUnit.Left - labelOutput.Width - 10;
        }
    }
}
