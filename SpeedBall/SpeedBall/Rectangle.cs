using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedBall
{
    class Rectangle : Shape
    {
        public int w { get; set; }
        public int h { get; set; }
        public Rectangle(int c,int width, int height)
        {
        //    int x = c.Next(0,624);
          //  Point a = new Point(x, 0);
            this.A = new Point(c,0);
            w = width;
            h = height;
            
        }


        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color.Green);
            g.FillRectangle(b, A.X, A.Y, w, h);
            

        }

        public override void Move()
        {
            A = new Point(A.X, A.Y + 10);
        }
    }
}
