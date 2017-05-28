namespace SpeedBall
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameEngine));
            this.pbGameEngine = new System.Windows.Forms.PictureBox();
            this.lblHighScore = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbUsersScore = new System.Windows.Forms.ListBox();
            this.lbPassed = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbGameEngine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::SpeedBall.Properties.Resources.start_button_back_v_01;
            this.pictureBox1.Location = new System.Drawing.Point(442, 575);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(150, 70);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::SpeedBall.Properties.Resources.start_button_new_game;
            this.pictureBox2.Location = new System.Drawing.Point(442, 654);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(150, 70);
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // lbUsersScore
            // 
            this.lbUsersScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsersScore.FormattingEnabled = true;
            this.lbUsersScore.ItemHeight = 16;
            this.lbUsersScore.Location = new System.Drawing.Point(428, 236);
            this.lbUsersScore.Name = "lbUsersScore";
            this.lbUsersScore.Size = new System.Drawing.Size(168, 292);
            this.lbUsersScore.TabIndex = 10;
            this.lbUsersScore.SelectedIndexChanged += new System.EventHandler(this.lbUsersScore_SelectedIndexChanged);
            // 
            // lbPassed
            // 
            this.lbPassed.BackColor = System.Drawing.Color.Transparent;
            this.lbPassed.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPassed.Location = new System.Drawing.Point(12, 22);
            this.lbPassed.Name = "lbPassed";
            this.lbPassed.Size = new System.Drawing.Size(392, 65);
            this.lbPassed.TabIndex = 11;
            this.lbPassed.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbPassed.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(424, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "All Users Score";
            // 
            // GameEngine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 733);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbPassed);
            this.Controls.Add(this.lbUsersScore);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblHighScore);
            this.Controls.Add(this.pbGameEngine);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GameEngine";
            this.Text = "SpeedBall";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGameEngine_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pbGameEngine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGameEngine;
        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblLevel;


        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ListBox lbUsersScore;
        private System.Windows.Forms.Label lbPassed;
        private System.Windows.Forms.Label label2;
    }
}

