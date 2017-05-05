using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpeedBall
{
    class Ball
    {
        public float Radius { get; set; }
        public Ball()
        {
            Radius = 20;
        }
        public void Draw(Graphics g,float X,float Y)
        {
     
            Brush b = new SolidBrush(Color.Blue);
            g.FillEllipse(b, X, Y, Radius * 2, Radius * 2);
        }
       
    }
}
