using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovePictureBoxWithKeys
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            Point p = pictureBox1.Location;

            if(keyData==Keys.Up)
            {
                p.Y -= 5;
                pictureBox1.Location = p;
            }
            if (keyData == Keys.Down)
            {
                p.Y += 5;
                pictureBox1.Location = p;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
