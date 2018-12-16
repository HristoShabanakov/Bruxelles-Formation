using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PongWithClass
{
    public partial class Form1 : Form
    {
        Ball balle = new Ball();
        Palette palette1 = new Palette();
        Palette palette2 = new Palette();
        public Form1()
        {
            InitializeComponent();
            balle.Position = new Point(100, 100);
            balle.RepresentationGraphique = pictureBoxBalle;
            palette1.RepresentationGraphique = pictureBoxPalette1;
            palette1.Position = pictureBoxPalette1.Location;
            palette2.RepresentationGraphique = pictureBoxPalette2;
            palette2.Position = pictureBoxPalette2.Location;
        }

        private void timerBall_Tick(object sender, EventArgs e)
        {
            balle.Bouger();
            balle.Rebondir(balle.ToucheUnBordDe(panel1));
            if(balle.ToucheObjet(palette1))
            {
                balle.Rebondir(1);
            }
            if (balle.ToucheObjet(palette2))
            {
                balle.Rebondir(3);
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData==Keys.Up)
            {
                palette1.MoveUp();
            }
            if (keyData == Keys.Down)
            {
                palette1.MoveDown();
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void timerPalette2_Tick(object sender, EventArgs e)
        {
            if(balle.Position.Y < palette2.Position.Y)
            {
                palette2.MoveUp();
            }
            else
            {
                palette2.MoveDown();
            }
        }
    }
}
