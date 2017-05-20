using SpeedBall.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Xml.Serialization;

namespace SpeedBall
{
    class Forms
    {
        public List<Shape> forms { get; set; }
        public int highScore { get; set; }
        private int h;
        public int level { get; set; }
        public int limit { get; set; }
        private int tick;
        private double increment;
        public List<Score> _highScores = new List<Score>();
        public Score score;
        public Forms(int height) {
            forms = new List<Shape>();
            h = height;
            highScore = 0;
            level = 1;
            limit = 20;
            tick = 100;
            increment = 1;
            score = new Score(0, "ABC");

                  

        }

        public void addToForms(Shape form) {
            forms.Add(form);
        }
        public void removeForm(Shape form)
        {
            for(int i=0;i<forms.Count;i++ )
            {
                if (form.Equals(forms[i]))
                    forms.RemoveAt(i);
            }
        }

        public void move()
        {
            for (int i = 0; i < forms.Count;i++ )
            {
                forms[i].Move();
                if (forms[i].A.Y > h)
                { 
                    forms.RemoveAt(i);
                    updatescore();

                }
                if(forms.Count!=0)
                if (forms[i].A.Y + (forms[i] as Rectangle).h > h) (forms[i] as Rectangle).h -= 10;
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Shape form in forms) {
                form.Draw(g);
            }
        }
    
        internal void updatescore()
        {
            highScore += 1;

            score.score = highScore;
        }
        internal int updateHighScore()
        {
          //  highScore += 1;
           if (highScore >=limit&&highScore<=(limit+limit/2))
            {
                int tmp= updateLevel();

                if(tmp<=0)
                {
                    tmp = 25;
                }
                tick = tmp;
                increment += 1;
                return tmp;
            }

            else return tick;
        }

        public void  sameColor()
        {
            highScore += 2;
        }

        public int updateLevel()
        {
            
                //treba da se dosredi logikata na povisokite leveli
                
                level++;
                limit = limit + (int)(limit / 2);
                return tick - (int)(10*increment);

        }

        //Scoring system
        internal void setHighScore()
        {

            var serializer = new XmlSerializer(_highScores.GetType());

            object obj;
            using (var reader = new StreamReader("highscores.xml"))
            {
                obj = serializer.Deserialize(reader.BaseStream);
            }
            _highScores = (List<Score>)obj;
         
            _highScores.Sort(delegate(Score s1, Score s2) { return -1*s1.score.CompareTo(s2.score); });
            
            if (_highScores.Count > 5 )
            {
                _highScores.RemoveAt(_highScores.Count-1);

            }
            if (_highScores[4].score<score.score) {
                NameForm nf = new NameForm();
                if (nf.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    score.ID=nf.name;
                }
          

            _highScores.Add(score);
            _highScores.Sort(delegate(Score s1, Score s2) { return -1 * s1.score.CompareTo(s2.score); });

            if (_highScores.Count > 5)
            {
                _highScores.RemoveAt(_highScores.Count - 1);

            }

            
            using (var writer = new StreamWriter("highscores.xml", false))
            {
                serializer.Serialize(writer.BaseStream, _highScores);
            }

            }
        }
    }
}
