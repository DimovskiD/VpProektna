using System;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SpeedBall
{
    public partial class HighScore : Form
    {
        public int score {get;set;}
        public HighScore()
        {
            score = 0;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
           
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
           
        }

        private void HighScore_Paint(object sender, PaintEventArgs e)
        {
            lblHighScore.Text = score.ToString();
        }

        private void HighScore_Load(object sender, EventArgs e)
        {
            loadHighScore();
        }

        private void loadHighScore()
        {

          /*  List<Score> _entities = new List<Score>();
            var serializer = new XmlSerializer(_entities.GetType());
            object obj;
            using (var reader = new StreamReader("../../../SpeedBall/Resources/topScore.txt"))
            {
                obj = serializer.Deserialize(reader.BaseStream);
            }
            _entities = (List<Score>)obj;

            /* List<Score> _entities = new List<Score>();
             var serializer = new XmlSerializer(_entities.GetType());
             object obj;
             using (var reader = new StreamReader("highscores.xml"))
             {
                 obj = serializer.Deserialize(reader.BaseStream);
             }
             _entities = (List<Score>)obj;


             for (int i = 0; i < _entities.Count; i++)
             {

                 lblPreviousBest.Text += String.Format("{0}. {1}, {2} \n", i+1, _entities[i].score, _entities[i].ID);
             } */*/
            UsersScene korisnici = new UsersScene();
            using(FileStream fileStream=new FileStream("topScores.txt",FileMode.Open))
            {
                IFormatter formater = new BinaryFormatter();
                korisnici = (UsersScene)formater.Deserialize(fileStream);
            }
            korisnici.Sort();
            lbUsers.Text = korisnici.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartPage sp = new StartPage();
            sp.Closed += (s, args) => this.Close(); //koga se iskluci vtorata forma se isklucuva i aplikacijata
            sp.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameEngine f1 = new GameEngine();
            f1.Closed += (s, args) => this.Close(); //koga se iskluci vtorata forma se isklucuva i aplikacijata
            f1.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
