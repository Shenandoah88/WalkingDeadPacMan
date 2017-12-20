namespace ZombieLandFinal
{
    partial class GameOver
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
            this.btn_no = new System.Windows.Forms.Button();
            this.btn_yes = new System.Windows.Forms.Button();
            this.pictureBox_GameOver = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_no
            // 
            this.btn_no.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_no.Image = global::ZombieLandFinal.Properties.Resources.Screen_Shot_2017_12_01_at_2_20_05_PM;
            this.btn_no.Location = new System.Drawing.Point(429, 332);
            this.btn_no.Name = "btn_no";
            this.btn_no.Size = new System.Drawing.Size(286, 112);
            this.btn_no.TabIndex = 2;
            this.btn_no.UseVisualStyleBackColor = false;
            this.btn_no.Click += new System.EventHandler(this.btn_no_Click);
            // 
            // btn_yes
            // 
            this.btn_yes.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_yes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_yes.FlatAppearance.BorderSize = 3;
            this.btn_yes.Image = global::ZombieLandFinal.Properties.Resources.Screen_Shot_2017_12_01_at_2_19_59_PM;
            this.btn_yes.Location = new System.Drawing.Point(73, 332);
            this.btn_yes.Name = "btn_yes";
            this.btn_yes.Size = new System.Drawing.Size(320, 112);
            this.btn_yes.TabIndex = 1;
            this.btn_yes.UseVisualStyleBackColor = false;
            this.btn_yes.Click += new System.EventHandler(this.btn_yes_Click);
            // 
            // pictureBox_GameOver
            // 
            this.pictureBox_GameOver.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.pictureBox_GameOver.Image = global::ZombieLandFinal.Properties.Resources.Screen_Shot_2017_12_01_at_2_20_10_PM;
            this.pictureBox_GameOver.Location = new System.Drawing.Point(73, -42);
            this.pictureBox_GameOver.Name = "pictureBox_GameOver";
            this.pictureBox_GameOver.Size = new System.Drawing.Size(642, 368);
            this.pictureBox_GameOver.TabIndex = 0;
            this.pictureBox_GameOver.TabStop = false;
            // 
            // GameOver
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(785, 448);
            this.Controls.Add(this.btn_no);
            this.Controls.Add(this.btn_yes);
            this.Controls.Add(this.pictureBox_GameOver);
            this.Name = "GameOver";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Over";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_GameOver)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_GameOver;
        private System.Windows.Forms.Button btn_yes;
        private System.Windows.Forms.Button btn_no;
    }
}