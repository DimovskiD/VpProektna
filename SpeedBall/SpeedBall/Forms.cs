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
        public int limit { get; set; }
        private int tick;
        private double increment;
        public Forms(int height) {
            forms = new List<Shape>();
            h = height;
            highScore = 0;
            level = 1;
            limit = 20;
            tick = 100;
            increment = 1;
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
    }
}
