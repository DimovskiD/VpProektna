using SpeedBall.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace SpeedBall
{
    public partial class GameEngine : Form
    {
         int p;
         private Ball topce;
         private Random random;
         Timer timer;
         Timer timerMove;
         Timer ColorTimer;
         private Forms forms;


        public GameEngine()
        {

            InitializeComponent();

            this.DoubleBuffered = true;

            newGame(p);
        }

        public GameEngine(int pr)
        {

            InitializeComponent();

            this.DoubleBuffered = true;
            p = pr;
            newGame(p);
        }


        public void newGame(int pref=3000) {

            topce = new SpeedBall.Ball(pbGameEngine.Width / 2, pbGameEngine.Height);

            forms = new Forms(pbGameEngine.Height);

            ColorTimer = new Timer();
            ColorTimer.Interval = 10000;
            ColorTimer.Tick += ColorTimer_tick;
            ColorTimer.Start();

            timer = new Timer();
            if (pref == 0) pref = 3000;
            timer.Interval = pref;
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
<<<<<<< HEAD:SpeedBall/SpeedBall/Form1.cs

=======
            //proverka dali topceto e vo dozvolena oblast
            if(topce.checkLimits(pbGameEngine.Width))
            {
                gameOver(true);
            }
>>>>>>> 472a8dc5ef5ddffa093bf25ce46c25b796318417:SpeedBall/SpeedBall/GameEngine.cs
            lblTick.Text = timerMove.Interval.ToString();
            lblLimit.Text = forms.limit.ToString();
            if (tmp != null)
            {
                ColorTimer.Stop();
                ColorTimer.Tag = new Object();
                
                if (tmp.cr.currentColor == topce.current)
                {
<<<<<<< HEAD:SpeedBall/SpeedBall/Form1.cs
                     forms.sameColor();
                    forms.removeForm(tmp);
=======
                     forms.sameColor();//increment highscore +2
                    forms.removeForm(tmp);//Clean same color rectange
>>>>>>> 472a8dc5ef5ddffa093bf25ce46c25b796318417:SpeedBall/SpeedBall/GameEngine.cs
                    
                }
                else
                {
                    gameOver(true);
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

        private async void gameOver(Boolean b)
        {
            
            timer.Stop();
            ColorTimer.Stop();
            timerMove.Stop();
            topce.flag = false;
            if (b)
            {
                await Task.Delay(TimeSpan.FromSeconds(2));
                this.Hide();
                HighScore hs = new HighScore();
                hs.score = forms.highScore;
                hs.Closed += (s, args) => this.Close(); //koga se iskluci vtorata forma se isklucuva i aplikacijata
                forms.setHighScore();
                hs.Show();
            }
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            this.gameOver(false);
            newGame(p);
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.gameOver(false);
            StartPage form1 = new StartPage();
            form1.Closed += (s, args) => this.Close(); //koga se iskluci vtorata forma se isklucuva i aplikacijata
            form1.Show();
        }
    }
}
