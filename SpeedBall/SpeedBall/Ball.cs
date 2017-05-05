using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpeedBall
{
    enum Direction { levo ,desno}
    class Ball
    {
        public float Radius { get; set; }
        public float X { get; set; }
        public float Y { get; set; }
        public Direction Nasoka { get; set; }
        public Ball(float X,float Y)
        {
            this.X = X;
            this.Y = Y;
            Radius = 20;
        }
        public void Draw(Graphics g)
        {
     
            Brush b = new SolidBrush(Color.Blue);
            g.FillEllipse(b, X-Radius, Y - 2 * Radius - 40, Radius * 2, Radius * 2);
        }
        public void ChangeDirection(Direction nasoka)
        {
            Nasoka = nasoka;
        }
        public void Move()
        {
            if (Nasoka == Direction.desno)
                X += 110;
            if (Nasoka == Direction.levo)
                X -= 110;

        }
       
    }
}
