﻿namespace SpeedBall
{
    partial class GameEngine
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pbGameEngine = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.lblTick = new System.Windows.Forms.Label();
            this.lblLimit = new System.Windows.Forms.Label();
<<<<<<< HEAD:SpeedBall/SpeedBall/Form1.Designer.cs
=======
            this.btnBack = new System.Windows.Forms.Button();
>>>>>>> 472a8dc5ef5ddffa093bf25ce46c25b796318417:SpeedBall/SpeedBall/GameEngine.Designer.cs
            ((System.ComponentModel.ISupportInitialize)(this.pbGameEngine)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGameEngine
            // 
            this.pbGameEngine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGameEngine.Location = new System.Drawing.Point(2, 13);
            this.pbGameEngine.Name = "pbGameEngine";
            this.pbGameEngine.Size = new System.Drawing.Size(415, 711);
            this.pbGameEngine.TabIndex = 0;
            this.pbGameEngine.TabStop = false;
            this.pbGameEngine.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGameEngine_Paint);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(441, 690);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(151, 34);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "New Game";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // lblHighScore
            // 
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(442, 97);
            this.lblHighScore.MaximumSize = new System.Drawing.Size(154, 62);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(154, 62);
            this.lblHighScore.TabIndex = 2;
            this.lblHighScore.Text = "0";
            this.lblHighScore.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblHighScore.Click += new System.EventHandler(this.lbl_Click);
            this.lblHighScore.Paint += new System.Windows.Forms.PaintEventHandler(this.lblHighScore_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(532, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Score";
            // 
            // lblLevel
            // 
            this.lblLevel.BackColor = System.Drawing.Color.Transparent;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(438, 12);
            this.lblLevel.MaximumSize = new System.Drawing.Size(154, 62);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(154, 61);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.Text = "Level 1";
            this.lblLevel.TextAlign = System.Drawing.ContentAlignment.TopRight;
            this.lblLevel.Paint += new System.Windows.Forms.PaintEventHandler(this.lblLevel_Paint);
            // 
            // lblTick
            // 
            this.lblTick.AutoSize = true;
            this.lblTick.Location = new System.Drawing.Point(505, 214);
            this.lblTick.Name = "lblTick";
            this.lblTick.Size = new System.Drawing.Size(0, 13);
            this.lblTick.TabIndex = 5;
            // 
            // lblLimit
            // 
            this.lblLimit.AutoSize = true;
            this.lblLimit.Location = new System.Drawing.Point(469, 397);
            this.lblLimit.Name = "lblLimit";
            this.lblLimit.Size = new System.Drawing.Size(35, 13);
            this.lblLimit.TabIndex = 6;
            this.lblLimit.Text = "label2";
            // 
<<<<<<< HEAD:SpeedBall/SpeedBall/Form1.Designer.cs
            // Form1
=======
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(441, 650);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(151, 34);
            this.btnBack.TabIndex = 7;
            this.btnBack.Text = "Back To Menu";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // GameEngine
>>>>>>> 472a8dc5ef5ddffa093bf25ce46c25b796318417:SpeedBall/SpeedBall/GameEngine.Designer.cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 736);
<<<<<<< HEAD:SpeedBall/SpeedBall/Form1.Designer.cs
=======
            this.Controls.Add(this.btnBack);
>>>>>>> 472a8dc5ef5ddffa093bf25ce46c25b796318417:SpeedBall/SpeedBall/GameEngine.Designer.cs
            this.Controls.Add(this.lblLimit);
            this.Controls.Add(this.lblTick);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pbGameEngine);
            this.Name = "GameEngine";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGameEngine_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameEngine)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGameEngine;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Label lblTick;
        private System.Windows.Forms.Label lblLimit;
<<<<<<< HEAD:SpeedBall/SpeedBall/Form1.Designer.cs
=======
        private System.Windows.Forms.Button btnBack;
>>>>>>> 472a8dc5ef5ddffa093bf25ce46c25b796318417:SpeedBall/SpeedBall/GameEngine.Designer.cs
    }
}
