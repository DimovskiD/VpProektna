using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedBall
{
    class Forms
    {
        List<Shape> forms;

        public Forms() {
            forms = new List<Shape>();
        }

        public void addToForms(Shape form) {
            forms.Add(form);
        }

        public void move()
        {
            foreach (Shape form in forms)
            {
                form.Move();
            }
        }

        public void Draw(Graphics g)
        {
            foreach (Shape form in forms) {
                form.Draw(g);
            }
        }

    }
}
