using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpeedBall
{
    class ColorControler
    {
        public List<Color> colors { get; set; }

        public ColorControler()
        {
            colors = new List<Color>();
            colors.Add(Color.Blue);
            colors.Add(Color.Green);
            colors.Add(Color.Pink);
            colors.Add(Color.Yellow);
            colors.Add(Color.Black);
        }
        public Brush ChangeColor(Shape s, Brush b)
        {
            b = new SolidBrush(randomColor());
            return b; 
        }

        public Color randomColor()
        {
            Random r = new Random();
            int boja = r.Next(colors.Count);
            return colors[boja];
        }
    }
}
