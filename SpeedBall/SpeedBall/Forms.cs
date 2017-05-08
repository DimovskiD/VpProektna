using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace SpeedBall
{
    class Forms
    {
        public List<Shape> forms { get; set; }
        public int highScore { get; set; }
        private int h;
        public int level { get; set; }
        private int limit;
        private int tick;
        private double increment;
        public Forms(int height) {
            forms = new List<Shape>();
            h = height;
            highScore = 0;
            level = 1;
            limit = 20;
            tick = 3000;
            increment = 1;
        }

        public void addToForms(Shape form) {
            forms.Add(form);
        }

        public void move()
        {
            for (int i = 0; i < forms.Count;i++ )
            {
                forms[i].Move();
                if (forms[i].A.Y > h)
                { 
                    forms.RemoveAt(i);
                    updateHighScore();

                }
                if (forms[i].A.Y + (forms[i] as Rectangle).h > h) (forms[i] as Rectangle).h -= 10;
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Shape form in forms) {
                form.Draw(g);
            }
        }


        internal int updateHighScore()
        {
            highScore += level;
            if (highScore % limit == 0)
            {
                int tmp= updateLevel();
                increment += 0.2;
                return tmp;
            }

            else return tick;
        }

        public int updateLevel()
        {
            
                //treba da se dosredi logikata na povisokite leveli
                level++;
                limit = limit + (int)(limit / 2);
                return tick - (int)(200*increment);
        }
    }
}
