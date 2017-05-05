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

        public float Radius { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public ColorControler ColorBall { get; set; }
        public Direction Nasoka { get; set; }
        public Brush b { get; set; }
        public Ball(float X,float Y)
        {
            ColorBall = new ColorControler();
            this.X = X;
            this.Y = Y;
            Radius = 20;
            b = new SolidBrush(ColorBall.randomColor());
        }

        public void changeColor()
        {
            b = new SolidBrush(ColorBall.randomColor());
            
        }

        public override void  Draw(Graphics g)
        {
          
            g.FillEllipse(b, X-Radius, Y - 2 * Radius - 40, Radius * 2, Radius * 2);
        }
        public void ChangeDirection(Direction nasoka)
        {
            Nasoka = nasoka;
        }
        public override void Move()
        {
            if (Nasoka == Direction.desno)
                X += 20;
            if (Nasoka == Direction.levo)
                X -= 20;

        }

       
    }
}
