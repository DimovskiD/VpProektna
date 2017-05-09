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
         private Forms forms;


        public Form1()
        {

            InitializeComponent();

            this.DoubleBuffered = true;
      
            topce = new SpeedBall.Ball(pbGameEngine.Width / 2, pbGameEngine.Height);

            forms = new Forms(pbGameEngine.Height);

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
            Rectangle tmp = topce.checkCollisions(forms);
           
            timerMove.Interval = forms.updateHighScore();
            //proverka dali topceto e vo dozvolena oblast
            if(topce.checkLimits(pbGameEngine.Width))
            {
                timer.Stop();
                ColorTimer.Stop();
                timerMove.Stop();
                topce.flag = false;
            }
            lblTick.Text = timerMove.Interval.ToString();
            lblLimit.Text = forms.limit.ToString();
            if (tmp != null)
            {
                ColorTimer.Stop();
                ColorTimer.Tag = new Object();
                
                if (tmp.cr.currentColor == topce.current)
                {
                     forms.sameColor();//increment highscore +2
                    forms.removeForm(tmp);//Clean same color rectange
                    
                }
                else
                {
                    timer.Stop();
                    ColorTimer.Stop();
                    timerMove.Stop();
                    topce.flag = false; //koga se sluci sudir zapri gi site tajmeri i onevozmozi dvizenje na topceto
                }
            }
            else
            {
                if (ColorTimer.Tag != null)
                {
                    ColorTimer.Tag = null;
                    ColorTimer.Start();
                }
                
            }
            Invalidate(true);

        }
       

        void timer_Tick(object sender, EventArgs e)
        {
            random = new Random();
            int c = RandNumber(12, pbGameEngine.Width - 100);
            forms.addToForms(new Rectangle(c,RandNumber(30,100),RandNumber(30,100)));
           
            Invalidate();
        }


        private void pbGameEngine_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.Clear(Color.White);
            //krajni granici za topceto
            Brush b = new SolidBrush(Color.Red);
            g.FillRectangle(b, pbGameEngine.Width-10, pbGameEngine.Height - 80, 10, 90);
            g.FillRectangle(b,pbGameEngine.Left, pbGameEngine.Height - 80, 10, 90); 
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

        private void lbl_Click(object sender, EventArgs e)
        {

        }

        private void lblHighScore_Paint(object sender, PaintEventArgs e)
        {
            lblHighScore.Text = forms.highScore.ToString();
        }

        private void lblLevel_Paint(object sender, PaintEventArgs e)
        {
            lblLevel.Text = String.Format("Level {0}",forms.level.ToString());
        }
    }
}
