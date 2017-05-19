using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using SpeedBall.Properties;
using System.Reflection;
using System.Xml.Serialization;

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
            this.Hide();
            StartPage sp = new StartPage();
            sp.Closed += (s, args) => this.Close(); //koga se iskluci vtorata forma se isklucuva i aplikacijata
            sp.Show();
        }

        private void btnNewGame_Click(object sender, EventArgs e)
        {
            this.Hide();
            GameEngine f1 = new GameEngine();
            f1.Closed += (s, args) => this.Close(); //koga se iskluci vtorata forma se isklucuva i aplikacijata
            f1.Show();
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
            List<Score> _entities = new List<Score>();
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
            }     
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
