using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Controls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++) //creating a loop
            {
                Button btn = new Button(); //creating a button
                btn.Text = "Afficher Nom";
                btn.Name = "button"+i;
                btn.Location = new Point(150, 50 * (i + 1));
                btn.Click += new EventHandler(button_Click); //event click and describe the fuction of the button; demand the system to Generate the method;can be add different functions;
                this.Controls.Add(btn);
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            Button buttonDeclencheur = (Button)sender; //gathering the info for this specific button
            label1.Text = buttonDeclencheur.Name; //describing the text
            buttonDeclencheur.Dispose(); //makes the button disappear after clicking on them
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < 7; j++)
            {
                Button btn1 = new Button();

            }
               

        }
    }
}
