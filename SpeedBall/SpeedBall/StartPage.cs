using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace SpeedBall
{
    public partial class StartPage : Form
    {
       
        public StartPage()
        {
            InitializeComponent();
           

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
           
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
        }

        private void rbPanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void rbEasy_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void btnStart_Paint(object sender, PaintEventArgs e)
        {
           
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Difficulty form4 = new Difficulty();
            form4.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Help form3 = new Help();
            form3.Show();
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
