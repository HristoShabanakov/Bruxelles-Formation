using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        int pasX = 5;
        int pasY = 5;

        public Form1()
        {
            InitializeComponent();
            SetInitialLocations();
        }

        private void panelAirDeJeu_SizeChanged(object sender, EventArgs e)
        {
            SetInitialLocations();
        }

        private void SetInitialLocations()
        {
            Point newPalette1Location = new Point();
            newPalette1Location.X = 60;
            int yValue = panelAirDeJeu.Height / 2 - pictureBoxPalette1.Height / 2;
            newPalette1Location.Y = yValue;
            pictureBoxPalette1.Location = newPalette1Location;

            Point newPalette2Location = new Point();
            newPalette2Location.Y = yValue;
            int xValue = panelAirDeJeu.Width - 10 - pictureBoxPalette2.Width;
            newPalette2Location.X = xValue;
            pictureBoxPalette2.Location = newPalette2Location;

            Point newBalleLocation = new Point();
            newBalleLocation.X = panelAirDeJeu.Width / 2 - pictureBoxBalle.Width / 2;
            newBalleLocation.Y = panelAirDeJeu.Height / 2 - pictureBoxBalle.Height / 2;
            pictureBoxBalle.Location = newBalleLocation;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (pictureBoxBalle.Left <= pictureBoxPalette1.Right &&
                pictureBoxPalette1.Bounds.IntersectsWith(pictureBoxBalle.Bounds))
            {
                pasX = -pasX;
            }
            if (pictureBoxBalle.Right >= pictureBoxPalette2.Left &&
                pictureBoxPalette2.Bounds.IntersectsWith(pictureBoxBalle.Bounds))
            {
                pasX = -pasX;
            }
            if (pictureBoxBalle.Right >= panelAirDeJeu.Width || pictureBoxBalle.Left <= 0)
            {
                //pasX = -pasX;
                SetInitialLocations();
            }
            if (pictureBoxBalle.Bottom >= panelAirDeJeu.Height || pictureBoxBalle.Top <= 0)
            {
                pasY = -pasY;
            }
            Point newLocation = pictureBoxBalle.Location;
            newLocation.X += pasX;
            newLocation.Y += pasY;
            pictureBoxBalle.Location = newLocation;

            Point newPaletteLocation = pictureBoxPalette2.Location;
            newPaletteLocation.Y = pictureBoxBalle.Location.Y - pictureBoxPalette2.Height / 2 + pictureBoxBalle.Height/2;
            pictureBoxPalette2.Location = newPaletteLocation;
        }

        private void panelAirDeJeu_MouseMove(object sender, MouseEventArgs e)
        {
            Point newLocation = pictureBoxPalette1.Location;
            newLocation.Y = e.Y;
            if (e.Y + pictureBoxPalette1.Height > panelAirDeJeu.Height)
            {
                newLocation.Y = pictureBoxPalette1.Top;
            }
            if (pictureBoxPalette1.Top<0 )
            {
                newLocation.Y = 0;
            }
            
            pictureBoxPalette1.Location = newLocation;

        }
    }
}
