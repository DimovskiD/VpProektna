using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedBall
{
    [Serializable]
    class Rectangle : Shape
    {
        public int w { get; set; }
        public int h { get; set; }
        public Brush b { get; set; }
        public bool zigzag { get; set; }
        public ColorControler cr { get; set; }
        public int RandomBroj{get;set;}
        public Rectangle(int c,int width, int height)
        {
        //    int x = c.Next(0,624);
          //  Point a = new Point(x, 0);
            this.A = new Point(c,12);
            //dodavanje random broj za pulsiranje [sekoja instanca posebno]
            Random r = new Random();
            RandomBroj = r.Next(40);
            w = width;
            zigzag = false;
            h = height;
            b = new SolidBrush(Color.Green);
            cr = new ColorControler();
            b = cr.ChangeColor(this, b);
        }

       

        public override void Draw(Graphics g)
        {
            g.FillRectangle(b, A.X, A.Y, w, h);
            
        }

        public override void Move()
        {
            A = new Point(A.X, A.Y + 10);
        }
        public void checkLimits()
        {
            if (A.X>60 && A.Y <w-50)
                zigzag = true;

        }
        public void ZigZagMove(bool t)
        {
            if (t)
            { 
            this.A =new Point( this.A.X+30,this.A.Y);               
                    }
            else
            {
                this.A = new Point(this.A.X - 30, this.A.Y);
            }
        }
    }
}
