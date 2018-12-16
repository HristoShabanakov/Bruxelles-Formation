using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongWithClass
{
    class Palette
    {
        int shift = 5;
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

        public void MoveUp()
        {
            position.Y -= shift;
            RepresentationGraphique.Location = position;
        }
        public void MoveDown()
        {
            position.Y += shift;
            RepresentationGraphique.Location = position;
        }
    }
}
