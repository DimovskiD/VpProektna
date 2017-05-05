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
         Timer timer;
         Timer timerMove;
         Forms forms = new Forms();


        public Form1()
        {

            InitializeComponent();
            topce = new SpeedBall.Ball();


            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += timer_Tick;
            timerMove = new Timer();
            timerMove.Interval = 100;
            timerMove.Tick += timerMove_Tick;
            timer.Start();
            timerMove.Start();
        }


        void timerMove_Tick(object sender, EventArgs e)
        {
            forms.move();
            Invalidate(true);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            forms.addToForms(new Rectangle(new Point(0,0),30,50));
            Invalidate();
        }


        private void pbGameEngine_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            topce.Draw(g, pbGameEngine.Width / 2 - topce.Radius, pbGameEngine.Height -2* topce.Radius-40);
            forms.Draw(e.Graphics);
        }

    
    }
}
