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
    public partial class Difficulty : Form
    {
        private int p;
      new string Name;
        public Difficulty()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (rbEasy.Checked) p = 3000;
            if (rbNormal.Checked) p = 2700;
            if (rbHard.Checked) p = 2000;
            if (rbInsane.Checked) p = 1000;
            Name = tbName.Text;
            this.Hide();
            GameEngine form1 = new GameEngine(p,Name);
            form1.Closed += (s, args) => this.Close(); //koga se iskluci vtorata forma se isklucuva i aplikacijata
            form1.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
