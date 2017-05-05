namespace SpeedBall
{
    partial class Form1
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
            ((System.ComponentModel.ISupportInitialize)(this.pbGameEngine)).BeginInit();
            this.SuspendLayout();
            // 
            // pbGameEngine
            // 
            this.pbGameEngine.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbGameEngine.Location = new System.Drawing.Point(12, 12);
            this.pbGameEngine.Name = "pbGameEngine";
            this.pbGameEngine.Size = new System.Drawing.Size(415, 711);
            this.pbGameEngine.TabIndex = 0;
            this.pbGameEngine.TabStop = false;
            this.pbGameEngine.Paint += new System.Windows.Forms.PaintEventHandler(this.pbGameEngine_Paint);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(445, 689);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(139, 34);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "New Game";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 736);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pbGameEngine);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pbGameEngine)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbGameEngine;
        private System.Windows.Forms.Button btnReset;
    }
}

