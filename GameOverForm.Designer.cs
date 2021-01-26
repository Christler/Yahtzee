
namespace Yahtzee
{
    partial class GameOverForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.playAgainBtn = new System.Windows.Forms.Button();
            this.scoreLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.namesLbl = new System.Windows.Forms.Label();
            this.scoresLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(196, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Over!";
            // 
            // exitBtn
            // 
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.Location = new System.Drawing.Point(152, 170);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(96, 38);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // playAgainBtn
            // 
            this.playAgainBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playAgainBtn.Location = new System.Drawing.Point(296, 170);
            this.playAgainBtn.Name = "playAgainBtn";
            this.playAgainBtn.Size = new System.Drawing.Size(96, 38);
            this.playAgainBtn.TabIndex = 2;
            this.playAgainBtn.Text = "Play Again";
            this.playAgainBtn.UseVisualStyleBackColor = true;
            this.playAgainBtn.Click += new System.EventHandler(this.playAgainBtn_Click);
            // 
            // scoreLbl
            // 
            this.scoreLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLbl.Location = new System.Drawing.Point(222, 131);
            this.scoreLbl.Name = "scoreLbl";
            this.scoreLbl.Size = new System.Drawing.Size(100, 23);
            this.scoreLbl.TabIndex = 3;
            this.scoreLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "High Scores";
            // 
            // namesLbl
            // 
            this.namesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.namesLbl.Location = new System.Drawing.Point(12, 246);
            this.namesLbl.Name = "namesLbl";
            this.namesLbl.Size = new System.Drawing.Size(257, 140);
            this.namesLbl.TabIndex = 6;
            this.namesLbl.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // scoresLbl
            // 
            this.scoresLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoresLbl.Location = new System.Drawing.Point(275, 246);
            this.scoresLbl.Name = "scoresLbl";
            this.scoresLbl.Size = new System.Drawing.Size(258, 140);
            this.scoresLbl.TabIndex = 7;
            // 
            // GameOverForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 395);
            this.Controls.Add(this.scoresLbl);
            this.Controls.Add(this.namesLbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.scoreLbl);
            this.Controls.Add(this.playAgainBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.label1);
            this.Name = "GameOverForm";
            this.Text = "Game Over";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button playAgainBtn;
        private System.Windows.Forms.Label scoreLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label namesLbl;
        private System.Windows.Forms.Label scoresLbl;
    }
}