﻿using System;
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

            this.Hide();
            Difficulty hs = new Difficulty();
       
            hs.Closed += (s, args) => this.Close(); //koga se iskluci vtorata forma se isklucuva i aplikacijata
           
            hs.Show();
            
           
         
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Help form3 = new Help();
            form3.Closed += (s, args) => this.Close(); //koga se iskluci vtorata forma se isklucuva i aplikacijata

            form3.Show();
           
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
