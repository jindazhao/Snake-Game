namespace Snake_Game
{
    partial class Snake
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
            this.Score = new System.Windows.Forms.Label();
            this.Food = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Score
            // 
            this.Score.AutoSize = true;
            this.Score.BackColor = System.Drawing.Color.Black;
            this.Score.ForeColor = System.Drawing.Color.White;
            this.Score.Location = new System.Drawing.Point(2, 0);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(151, 32);
            this.Score.TabIndex = 0;
            this.Score.Text = "Score: 0";
            // 
            // Food
            // 
            this.Food.AutoSize = true;
            this.Food.BackColor = System.Drawing.Color.Lime;
            this.Food.Location = new System.Drawing.Point(402, 172);
            this.Food.Name = "Food";
            this.Food.Size = new System.Drawing.Size(32, 32);
            this.Food.TabIndex = 1;
            this.Food.Text = " ";
            // 
            // Snake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.Food);
            this.Controls.Add(this.Score);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Snake";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Snake_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Score;
        private System.Windows.Forms.Label Food;
    }
}

