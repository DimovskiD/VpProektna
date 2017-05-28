using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpeedBall
{
    enum Direction { levo ,desno}
    [Serializable]
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

            current = ColorBall.randomColor();
            b = new SolidBrush(current);

            current= ColorBall.randomColor();
            b = new SolidBrush(current);


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


        public Rectangle checkCollisions(Forms f) {
            List<Shape> forms = f.forms;

            foreach (Shape form in forms) {
                Rectangle tmp = form as Rectangle;
                float DeltaX = X - Math.Max(tmp.A.X, Math.Min(X,tmp.A.X + tmp.w));
                float DeltaY = (Y-Radius-40) - Math.Max(tmp.A.Y, Math.Min(Y-Radius-40, tmp.A.Y + tmp.h));

                if ((DeltaX * DeltaX + DeltaY * DeltaY) < (Radius * Radius))
                    return tmp;

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
