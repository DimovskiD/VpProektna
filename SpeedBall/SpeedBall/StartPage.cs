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
    public partial class StartPage : Form
    {
        private int p;
        public StartPage()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (rbEasy.Checked) p = 3000;
            if (rbNormal.Checked) p = 2700;
            if (rbHard.Checked) p = 2000;
            if (rbInsane.Checked) p = 1000;

            this.Hide();
            GameEngine form1 = new GameEngine(p);
            form1.Closed += (s, args) => this.Close(); //koga se iskluci vtorata forma se isklucuva i aplikacijata
            form1.Show();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help form3 = new Help();
            form3.Show();
            this.Hide();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}
