namespace Pc_man_Game_MOO_ICT_1
{
    partial class GameOverDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameOverDialog));
            this.score = new System.Windows.Forms.Label();
            this.highestScore = new System.Windows.Forms.Label();
            this.btnRestart = new System.Windows.Forms.Button();
            this.lblEndGame = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.BackColor = System.Drawing.Color.Gold;
            this.score.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.score.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.Location = new System.Drawing.Point(212, 123);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(93, 40);
            this.score.TabIndex = 0;
            this.score.Text = "ຄະແນນ: ";
            this.score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // highestScore
            // 
            this.highestScore.AutoSize = true;
            this.highestScore.BackColor = System.Drawing.Color.Gold;
            this.highestScore.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.highestScore.Font = new System.Drawing.Font("Noto Sans Lao", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highestScore.Location = new System.Drawing.Point(439, 123);
            this.highestScore.Name = "highestScore";
            this.highestScore.Size = new System.Drawing.Size(146, 40);
            this.highestScore.TabIndex = 1;
            this.highestScore.Text = "ຄະແນນສູງສຸດ: ";
            this.highestScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.SteelBlue;
            this.btnRestart.Font = new System.Drawing.Font("SimSun", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestart.Location = new System.Drawing.Point(212, 344);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(373, 53);
            this.btnRestart.TabIndex = 2;
            this.btnRestart.Text = "Restart Game";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // lblEndGame
            // 
            this.lblEndGame.AutoSize = true;
            this.lblEndGame.BackColor = System.Drawing.Color.Transparent;
            this.lblEndGame.Font = new System.Drawing.Font("Noto Sans Lao", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEndGame.ForeColor = System.Drawing.Color.IndianRed;
            this.lblEndGame.Location = new System.Drawing.Point(259, 36);
            this.lblEndGame.Name = "lblEndGame";
            this.lblEndGame.Size = new System.Drawing.Size(284, 78);
            this.lblEndGame.TabIndex = 3;
            this.lblEndGame.Text = "ທ່ານຊະນະແລ້ວ";
            this.lblEndGame.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEndGame.Click += new System.EventHandler(this.lblEndGame_Click);
            // 
            // GameOverDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEndGame);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.highestScore);
            this.Controls.Add(this.score);
            this.Name = "GameOverDialog";
            this.Text = "GameOverDialog";
            this.Load += new System.EventHandler(this.GameOverDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label highestScore;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.Label lblEndGame;
    }
}