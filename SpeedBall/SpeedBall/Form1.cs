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
         private Random random;
         Timer timer;
         Timer timerMove;
        Timer ColorTimer;
         Forms forms = new Forms();



        public Form1()
        {

            InitializeComponent();

          
            topce = new SpeedBall.Ball(pbGameEngine.Width / 2, pbGameEngine.Height);



            ColorTimer = new Timer();
            ColorTimer.Interval = 10000;
            ColorTimer.Tick += ColorTimer_tick;
            ColorTimer.Start();

            timer = new Timer();
            timer.Interval = 3000;
            timer.Tick += timer_Tick;
            timerMove = new Timer();
            timerMove.Interval = 100;
            timerMove.Tick += timerMove_Tick;
            timer.Start();
            timerMove.Start();
        }

        void ColorTimer_tick(object sender,EventArgs e)
        {
            topce.changeColor();
        }

        void timerMove_Tick(object sender, EventArgs e)
        {
            forms.move();
            Invalidate(true);

        }
       

        void timer_Tick(object sender, EventArgs e)
        {
            random = new Random();
            forms.addToForms(new Rectangle(RandNumber(10,pbGameEngine.Width-10),RandNumber(30,100),RandNumber(30,100)));
            Invalidate();
        }


        private void pbGameEngine_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(Color.White);
            topce.Draw(g);
 	forms.Draw(e.Graphics);
        }

       

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Left)
            {
                topce.ChangeDirection(Direction.levo);
               
                topce.Move();
                Invalidate(true);
                return true;
            }
            if (keyData == Keys.Right)
            {
                topce.ChangeDirection(Direction.desno);
               
                topce.Move();
                Invalidate(true);
                return true;
            }
           
            return base.ProcessCmdKey(ref msg, keyData);
        }



           
        

        public static int RandNumber(int Low, int High)
        {
            Random rndNum = new Random(int.Parse(Guid.NewGuid().ToString().Substring(0, 8), System.Globalization.NumberStyles.HexNumber));

            int rnd = rndNum.Next(Low, High);

            return rnd;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
