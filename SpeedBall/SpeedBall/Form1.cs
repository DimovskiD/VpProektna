using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedBall
{
    public partial class Form1 : Form
    {
     private Ball topce;
        public Form1()
        {
            InitializeComponent();
            topce = new SpeedBall.Ball();
        }

        private void pbGameEngine_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            topce.Draw(g, pbGameEngine.Width / 2 - topce.Radius, pbGameEngine.Height -2* topce.Radius-40);
        }
    }
}
