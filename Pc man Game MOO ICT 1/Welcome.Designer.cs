namespace Pc_man_Game_MOO_ICT_1
{
    partial class Welcome
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnGameDetail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.LightPink;
            this.btnStart.Font = new System.Drawing.Font("Noto Sans Lao", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(897, 5);
            this.btnStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(244, 69);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnGameDetail
            // 
            this.btnGameDetail.BackColor = System.Drawing.Color.LightPink;
            this.btnGameDetail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGameDetail.Font = new System.Drawing.Font("Noto Sans Lao", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGameDetail.Location = new System.Drawing.Point(231, 5);
            this.btnGameDetail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGameDetail.Name = "btnGameDetail";
            this.btnGameDetail.Size = new System.Drawing.Size(237, 69);
            this.btnGameDetail.TabIndex = 2;
            this.btnGameDetail.Text = "ຄູ່ມື";
            this.btnGameDetail.UseVisualStyleBackColor = false;
            this.btnGameDetail.Click += new System.EventHandler(this.btnGameDetail_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Pc_man_Game_MOO_ICT_1.Properties.Resources.welcome;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1368, 799);
            this.Controls.Add(this.btnGameDetail);
            this.Controls.Add(this.btnStart);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Welcome";
            this.Text = "Welcome";
            this.Load += new System.EventHandler(this.Welcome_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnGameDetail;
    }
}