using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpeedBall
{
     abstract class Shape
    {
       public Point A { get; set; }
       


        abstract public void Draw(Graphics g);
        abstract public void Move();
        
    }
}
