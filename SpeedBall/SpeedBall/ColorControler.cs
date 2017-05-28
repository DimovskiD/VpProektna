using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace SpeedBall
{
    [Serializable]
    class ColorControler
    {
        public List<Color> colors { get; set; }
        public Color currentColor { get; private set; }
        public ColorControler()
        {
            
            colors = new List<Color>();
            colors.Add(Color.FromArgb(51,102,153));
            colors.Add(Color.FromArgb(102,153,0));
            colors.Add(Color.FromArgb(204,51,102));
            colors.Add(Color.FromArgb(255,204,102));
            colors.Add(Color.FromArgb(104,71,141));
            currentColor = randomColor();
        }
        public Brush ChangeColor(Shape s, Brush b)
        {
            currentColor = randomColor();
            b = new SolidBrush(currentColor);
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
