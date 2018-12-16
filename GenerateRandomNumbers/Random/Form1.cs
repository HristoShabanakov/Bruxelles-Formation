using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Random
{
    public partial class Form1 : Form
    {

        const int nbLignes = 5; //declaring variables x
        const int nbColonnes = 6;// declaring variables y
        Label[,] Grille; //declaration of a new label
        public Form1()
        {
            InitializeComponent();
            genenerLaGrille();
            initialiserCouleurGrille();
        }

        private void genenerLaGrille()
        {
            Grille = new Label[nbLignes, nbColonnes]; // assigning value of the object Label
            for (int i = 0; i < nbLignes; i++) // creating a Loop i which represent vertical columns in the table
            {
                for (int j = 0; j < nbColonnes; j++) // creating a Loop j which represent horizontal colums in the table
                {
                    Grille[i, j] = new Label();//each event will create a new label in the table
                    Grille[i, j].Location = new Point(60 + 50 * i, 60 + 30 * j); //creating coordinates of the table
                    Grille[i, j].AutoSize = true;
                    int valeur = i * nbColonnes + j + 1;
                    Grille[i, j].Text = valeur.ToString();
                    this.Controls.Add(Grille[i, j]);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            initialiserCouleurGrille();
            System.Random rnd = new System.Random();//namespace of the project was also called random,thats why we use system.random to clarify the function random
            for (int i = 0; i < 6; i++) //another loop which will generate the random numbers by lines and columns
            {
                int ligne = rnd.Next(nbLignes);
                int colonne = rnd.Next(nbColonnes);
                Grille[ligne, colonne].BackColor = Color.Red;
            }
        }




        private void initialiserCouleurGrille()
        {
            for (int i = 0; i < nbLignes; i++) // i represent vertical columns in the table (x)
            {
                for (int j = 0; j < nbColonnes; j++)// j represent vertical columns in the table (y)
                {
                    Grille[i, j].BackColor = Color.Empty;
                }
            }
        }

       
        }
    }
 
