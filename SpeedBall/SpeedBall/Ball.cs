using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpeedBall
{
    enum Direction { levo ,desno}
    
    class Ball:Shape
    {
        public bool flag { get; set; }
        public float Radius { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public ColorControler ColorBall { get; set; }
        public Direction Nasoka { get; set; }
        public Brush b { get; set; }
        public Color current { get; private set; }
        public Ball(float X,float Y)
        {
            ColorBall = new ColorControler();
            this.X = X;
            this.Y = Y;
            Radius = 20;
            b = new SolidBrush(ColorBall.randomColor());
            flag = true;
        }

        public void changeColor()
        {
            current = ColorBall.randomColor();
            b = new SolidBrush(current);
            
        }

        public override void  Draw(Graphics g)
        {
            g.FillEllipse(b, X - Radius ,Y - 2 * Radius - 40, Radius * 2, Radius * 2);     
         
        }
        public void ChangeDirection(Direction nasoka)
        {
            Nasoka = nasoka;
        }
        public override void Move()
        {
            if (flag == true)
            {
                if (Nasoka == Direction.desno)
                    X += 20;
                if (Nasoka == Direction.levo)
                    X -= 20;
            }
            

        }


        //treba da se dosredi, ima bug
        public Rectangle checkCollisions(Forms f)
        {
            List<Shape> forms = f.forms;
            float y = Y - 2*Radius - 40; //najgorna tocka na topceto
            float y2 = Y - 40; //najdolna tocka na topceto
            foreach (Shape form in forms) {
                Rectangle tmp = form as Rectangle;

                int x1 = tmp.A.X;
                int y1 = tmp.A.Y+tmp.h;
                int x2 = tmp.A.X + tmp.w;

                if (X >= x1 && X <= x2)
                {
                    if (y <= y1&&tmp.A.Y<=y2) return tmp;
                }
                
            }
            return null;
           

        }
        public bool checkLimits(int W)
        {
            if (X-40 < 1 || X+40 > W)
                return true;
            else
                return false;
        }

        
    }
}
