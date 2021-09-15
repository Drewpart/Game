
namespace Game
{
    partial class Warzone
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
            this.pressPlay = new System.Windows.Forms.Label();
            this.start = new System.Windows.Forms.Button();
            this.play = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pressPlay
            // 
            this.pressPlay.AutoSize = true;
            this.pressPlay.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pressPlay.Location = new System.Drawing.Point(285, 114);
            this.pressPlay.Name = "pressPlay";
            this.pressPlay.Size = new System.Drawing.Size(257, 31);
            this.pressPlay.TabIndex = 0;
            this.pressPlay.Text = "Press Start To PLay";
            // 
            // start
            // 
            this.start.Font = new System.Drawing.Font("Sitka Display", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start.Location = new System.Drawing.Point(240, 191);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(334, 111);
            this.start.TabIndex = 1;
            this.start.Text = "START";
            this.start.UseVisualStyleBackColor = true;
            this.start.Click += new System.EventHandler(this.button1_Click);
            // 
            // play
            // 
            this.play.AutoSize = true;
            this.play.Font = new System.Drawing.Font("Yu Gothic Light", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.play.ForeColor = System.Drawing.Color.DarkOrange;
            this.play.Location = new System.Drawing.Point(375, 145);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(66, 26);
            this.play.TabIndex = 2;
            this.play.Text = "Play!!!";
            this.play.Click += new System.EventHandler(this.label1_Click);
            // 
            // Warzone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.play);
            this.Controls.Add(this.start);
            this.Controls.Add(this.pressPlay);
            this.Name = "Warzone";
            this.Text = "Warzone";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pressPlay;
        private System.Windows.Forms.Button start;
        private System.Windows.Forms.Label play;
    }
}

