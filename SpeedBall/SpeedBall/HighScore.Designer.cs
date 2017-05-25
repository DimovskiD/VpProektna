namespace SpeedBall
{
    partial class HighScore
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
            this.lblHighScore = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.btnNewGame = new System.Windows.Forms.Button();
            this.btnMainMenu = new System.Windows.Forms.Button();
            this.lblTopScore = new System.Windows.Forms.Label();
            this.lblPreviousBest = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblHighScore
            // 
            this.lblHighScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHighScore.Location = new System.Drawing.Point(92, 102);
            this.lblHighScore.Name = "lblHighScore";
            this.lblHighScore.Size = new System.Drawing.Size(426, 214);
            this.lblHighScore.TabIndex = 0;
            this.lblHighScore.Text = "0";
            this.lblHighScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblHighScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblText
            // 
            this.lblText.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblText.Location = new System.Drawing.Point(92, 18);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(426, 73);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Your Score";
            this.lblText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNewGame
            // 
            this.btnNewGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewGame.Location = new System.Drawing.Point(236, 642);
            this.btnNewGame.Name = "btnNewGame";
            this.btnNewGame.Size = new System.Drawing.Size(183, 63);
            this.btnNewGame.TabIndex = 2;
            this.btnNewGame.Text = "New Game";
            this.btnNewGame.UseVisualStyleBackColor = true;
            this.btnNewGame.Click += new System.EventHandler(this.btnNewGame_Click);
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Location = new System.Drawing.Point(12, 642);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Size = new System.Drawing.Size(200, 63);
            this.btnMainMenu.TabIndex = 3;
            this.btnMainMenu.Text = "Back To Menu";
            this.btnMainMenu.UseVisualStyleBackColor = true;
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // lblTopScore
            // 
            this.lblTopScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopScore.Location = new System.Drawing.Point(91, 332);
            this.lblTopScore.Name = "lblTopScore";
            this.lblTopScore.Size = new System.Drawing.Size(426, 73);
            this.lblTopScore.TabIndex = 4;
            this.lblTopScore.Text = "Top Scores";
            this.lblTopScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblPreviousBest
            // 
            this.lblPreviousBest.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreviousBest.Location = new System.Drawing.Point(92, 405);
            this.lblPreviousBest.Name = "lblPreviousBest";
            this.lblPreviousBest.Size = new System.Drawing.Size(426, 185);
            this.lblPreviousBest.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(440, 642);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 63);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HighScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 736);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblPreviousBest);
            this.Controls.Add(this.lblTopScore);
            this.Controls.Add(this.btnMainMenu);
            this.Controls.Add(this.btnNewGame);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblHighScore);
            this.Name = "HighScore";
            this.Text = "HighScore";
            this.Load += new System.EventHandler(this.HighScore_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.HighScore_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblHighScore;
        private System.Windows.Forms.Label lblText;
        private System.Windows.Forms.Button btnNewGame;
        private System.Windows.Forms.Button btnMainMenu;
        private System.Windows.Forms.Label lblTopScore;
        private System.Windows.Forms.Label lblPreviousBest;
        private System.Windows.Forms.Button button1;
    }
}