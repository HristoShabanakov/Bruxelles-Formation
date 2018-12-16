using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lotto
{
    public partial class Form1 : Form
    {
        const int nbLignes = 10;
        const int nbColonnes = 10;
        const int lageurLabel = 30;
        const int hauteurLabel = 15;

        int nbValeursChoisies = 0;

        Label[,] Grille;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void genererLaGrille()
        {
            //On calcule la position de chaque label en fonction
            //de la taille du panel, le nombre de colonnes et
            //le nombre de lignes et la taille du label
            int largeur = panelGrille.Width / nbColonnes;
            int xpos = largeur / 2 - lageurLabel / 2;
            int hauteur = panelGrille.Height / nbLignes;
            int ypos = hauteur / 2 - hauteurLabel / 2;

            Grille = new Label[nbLignes, nbColonnes];
            for (int i = 0; i < nbLignes; i++)
            {
                for (int j = 0; j < nbColonnes; j++)
                {
                    //Pour chaque élément de la grille on crée un nouveau Label
                    Grille[i, j] = new Label();

                    //On définit la taille de chaque label afin qu'ils aient tous la même taille
                    Grille[i, j].Size = new Size(lageurLabel, hauteurLabel);

                    //On centre le texte dans le label
                    Grille[i, j].TextAlign = ContentAlignment.MiddleCenter;      

                    //On calcule la valeur à afficher 
                    //dans chaque label en fonction de i et j
                    int valeur = i * nbColonnes + j + 1;
                    Grille[i, j].Text = valeur.ToString();

                    //On définit la position du label en fonction 
                    //des indices i et j
                    Grille[i, j].Location = new Point(xpos+largeur*j, ypos+hauteur*i);

                    //On associe la fonction de coloration à l'eventement Click
                    Grille[i, j].Click += new EventHandler(ColorierCase);
                    //On ajoute chaque label au panel  
                    panelGrille.Controls.Add(Grille[i, j]);
                }
         
            } 
        }

        private void ColorierCase(object sender, EventArgs e)
        {
            Label l = (Label)sender;
            if (l.BackColor != Color.Green)
            {              
                if (nbValeursChoisies < 6)
                {
                    nbValeursChoisies++;
                    l.BackColor = Color.Green;
                }
            }
            else
            {
                nbValeursChoisies--;
                l.BackColor = Color.DimGray;
            }

        }


        private void buttonGenererValeursAleatoires_Click(object sender, EventArgs e)
        {
            initialiserCouleurGrille();
            Random rnd = new Random();
            for (int i = 0; i < 6; i++)
            {
                int ligne = rnd.Next(nbLignes);
                int colonne = rnd.Next(nbColonnes);
                Grille[ligne, colonne].BackColor = Color.Red;
            }
        }

        private void initialiserCouleurGrille()
        {
            for (int i = 0; i < nbLignes; i++)
            {
                for (int j = 0; j < nbColonnes; j++)
                {
                    Grille[i, j].BackColor = Color.DimGray;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            genererLaGrille();
            initialiserCouleurGrille();
            
        }
        private void WinMode()
        {
            List<int> numbers = new List<int>();
            
        }
    }
}
