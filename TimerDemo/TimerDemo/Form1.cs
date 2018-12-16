using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TimerDemo
{
    public partial class Form1 : Form
    {
        int pas = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(pictureBoxBalle.Right >= panel1.Width || pictureBoxBalle.Left <= 0)
            {
                pas = -pas;
            }
            Point newLocation = pictureBoxBalle.Location;
            newLocation.X += pas;
            pictureBoxBalle.Location = newLocation;
        }
    }
}
