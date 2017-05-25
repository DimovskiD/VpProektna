using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpeedBall
{
    public partial class Help : Form
    {
        public Help()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

            StartPage form2 = new StartPage();

            form2.Show();
            this.Hide();
        }
    }
}
