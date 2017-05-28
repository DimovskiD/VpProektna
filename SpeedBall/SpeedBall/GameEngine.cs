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
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;


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
        //Timer PulseRectange;
        Timer ZigZag;


        Timer Check;

      bool t;

        private Forms forms;
        private bool flag;
        new string Name;
        UsersScene korisnici;
        User korisnik;
        bool firsttime;
        string prevName;
        string currName;
        bool flagName;

        public GameEngine()
        {

            InitializeComponent();

            this.DoubleBuffered = true;
            
            newGame(p);
        }

        public GameEngine(int pr,string name)
        {

            InitializeComponent();

            Name = name;
            this.DoubleBuffered = true;
            p = pr;
            newGame(p);
        }

        public void loadUsers()
        {
            try
            {
                using (FileStream fileStream = new FileStream("topScores.txt", FileMode.Open))
                {
                    IFormatter formater = new BinaryFormatter();
                    korisnici = (UsersScene)formater.Deserialize(fileStream);
                    korisnici.Sort();
                }
            }
            catch (Exception ex)
            {
                korisnici = new UsersScene();
            }
        }
        public void fillUsers()
        {
            foreach(User u in korisnici.lista)
            {
                lbUsersScore.Items.Add(u);

            }
        }
        public void newGame(int pref=3000) {


            topce = new SpeedBall.Ball(pbGameEngine.Width / 2, pbGameEngine.Height);
            
            loadUsers();
            fillUsers();
            //Check if passed some of Users
            Check = new Timer();
            Check.Interval = 2000;
            Check.Tick += Check_tick;
            Check.Start();
            flagName = true;
            firsttime = true;
            /*pulsing rectangles
            PulseRectange = new Timer();
            PulseRectange.Interval = 450;
            PulseRectange.Tick += PulseRectange_tick;
            PulseRectange.Start();
             * */
            forms = new Forms(pbGameEngine.Height);
            //Timer for color changing
            ColorTimer = new Timer();
            ColorTimer.Interval = 10000;
            ColorTimer.Tick += ColorTimer_tick;
            ColorTimer.Start();
           // timer zigzag
            ZigZag = new Timer();
            ZigZag.Interval = 750;
            ZigZag.Tick += ZigZag_tick;
            ZigZag.Start(); 
            flag = true;
            timer = new Timer();
            t = true;
            if (pref == 0) pref = 3000;
            timer.Interval = pref;
            timer.Tick += timer_Tick;
            timerMove = new Timer();
            timerMove.Interval = 100;
            timerMove.Tick += timerMove_Tick;
            timer.Start();
            timerMove.Start();
            korisnik= new User(Name);
        }
        void Check_tick(object sender,EventArgs e)
        {
            if(forms.highScore>korisnici.maxScore())
            {
                lbPassed.Text = "";
                lbPassed.Visible = false;
               

                
            }
            
            if (firsttime)
            {
                currName = korisnici.Checking(forms.highScore);
                if (currName != null)
                {
                    if (flagName)
                    {
                        lbPassed.Text = "Cograts you passed \n" + currName;
                        lbPassed.Visible = true;
                        firsttime = false;
                        flagName = false;
                    }
                    else
                    {
                        if(currName!=prevName)
                        {
                            lbPassed.Text = "Cograts you passed \n" + currName;
                            lbPassed.Visible = true;
                            firsttime = false;
                        }
                    }
                }
            }
            else 
            {
                lbPassed.Visible =false;
                firsttime = true;
                prevName = currName;
            }
        }
       void ZigZag_tick(object sender,EventArgs e)
        {
            forms.CheckLimit();
            if (t)
            {
                
                forms.ZigZagMove(t);
                t = false;
            }
            else
            {
                forms.ZigZagMove(t);
                t = true;
            }
        }
        /* 
       void PulseRectange_tick(object sender,EventArgs e)
        {
            
            if(flag)
            {
                foreach(Shape shape in forms.forms)
                {
                    Rectangle tmp = shape as Rectangle;
                    tmp.w = tmp.w+tmp.RandomBroj;
                    tmp.h = tmp.h+ tmp.RandomBroj;
                }
                flag = false;
            }
            else
            {
                foreach (Shape shape in forms.forms)
                {
                    Rectangle tmp = shape as Rectangle;
                    tmp.w = tmp.w - tmp.RandomBroj;
                    tmp.h = tmp.h - tmp.RandomBroj;
                }
                flag = true;
            }
            Invalidate();
        }
        * */
        void ColorTimer_tick(object sender,EventArgs e)
        {
            topce.changeColor();
        }


        void timerMove_Tick(object sender, EventArgs e)
        {
            forms.move();
            Rectangle tmp = topce.checkCollisions(forms);
            int lvl = forms.level;
            timerMove.Interval = forms.updateHighScore();
            if (forms.level != lvl)
            {

                if (timer.Interval > 500)
                {
                    if (p == 3000)
                        timer.Interval -= 300;
                    if (p == 2700)
                        timer.Interval -= 220;
                    if (p == 2000)
                        timer.Interval -= 150;
                    if (p == 1300)
                        timer.Interval -= 90;
                
                

                
                
                }
            }

            //proverka dali topceto e vo dozvolena oblast
            if(topce.checkLimits(pbGameEngine.Width))
            {

                timer.Stop();
                ColorTimer.Stop();
                timerMove.Stop();
                topce.flag = false;

                gameOver(true);

            }

           
         
            if (tmp != null)
            {
                ColorTimer.Stop();
                ColorTimer.Tag = new Object();
                
                if (tmp.cr.currentColor == topce.current)
                {

                    forms.sameColor();//increment highscore +2
                    forms.removeForm(tmp);//Clean same color rectange
                    forms.sameColor();
                    forms.removeForm(tmp);
                    forms.sameColor();//increment highscore +2
                    forms.removeForm(tmp);//Clean same color rectange
                    
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
        public void serialize()
        {
            korisnici.Sort();
            using (FileStream fileStream = new FileStream("topScores.txt", FileMode.OpenOrCreate))
            {
                IFormatter formater = new BinaryFormatter();
                formater.Serialize(fileStream, korisnici);
            }
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
                korisnik.SetScore(forms.highScore);                                        //   forms.setHighScore();
                if (korisnici.lista.Count >= 3)
                {
                    if (forms.highScore > korisnici.maxScore())
                    {
                        NameForm nf = new NameForm();

                        nf.name = korisnik.Name;
                        if (nf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                        {

                        }

                    }
                }   
                korisnici.AddUser(korisnik);
                serialize();
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
      
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            // the next two lines of code (not comments) are needed to get the highest 
            // possible quiality of anti-aliasing. Remove them if you want the image to render faster.
            g.CompositingQuality = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
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
          
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.gameOver(false);
            StartPage form1 = new StartPage();
            form1.Closed += (s, args) => this.Close(); //koga se iskluci vtorata forma se isklucuva i aplikacijata
            form1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.gameOver(false);
            newGame(p);
        }

        private void lbUsersScore_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
