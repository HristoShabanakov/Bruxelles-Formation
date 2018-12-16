using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongWithClass
{
    class Ball
    {
        int vitesseX=5;
        int vitesseY=5;
        Point position;
        public Point Position
        {
            get { return position; }
            set { position = value; }
        }
        PictureBox representationGraphique;
        public PictureBox RepresentationGraphique
        {
            get { return representationGraphique; }
            set { representationGraphique = value; }
        }

        public void Bouger()
        {
            position.X += vitesseX;
            position.Y += vitesseY;
            representationGraphique.Location = position;
        }
        public void Rebondir(int bord)
        {
            if(bord == 1 || bord == 3)
            {
                vitesseX = -vitesseX;
            }
            if (bord == 2 || bord == 4)
            {
                vitesseY = -vitesseY;
            }
        }
        public bool ToucheObjet(Palette p)
        {
            return representationGraphique.Bounds.IntersectsWith(p.RepresentationGraphique.Bounds);
        }
        public int ToucheUnBordDe(Panel p)
        {
            if(representationGraphique.Left<0)
            {
                return 1;
            }
            if (representationGraphique.Top < 0)
            {
                return 2;
            }
            if (representationGraphique.Right > p.Width)
            {
                return 3;
            }
            if (representationGraphique.Bottom > p.Height)
            {
                return 4;
            }

            return 0;
        }
    }
}
