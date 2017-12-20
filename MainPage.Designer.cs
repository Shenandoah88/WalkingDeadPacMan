namespace ZombieLandFinal
{
    partial class MainPage
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
            this.pictureBox_TheGameLogo = new System.Windows.Forms.PictureBox();
            this.btn_instructions = new System.Windows.Forms.Button();
            this.btn_play = new System.Windows.Forms.Button();
            this.pictureBox_IntroVideo = new System.Windows.Forms.PictureBox();
            this.pictureBox_TWDLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TheGameLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IntroVideo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TWDLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox_TheGameLogo
            // 
            this.pictureBox_TheGameLogo.Image = global::ZombieLandFinal.Properties.Resources.Screen_Shot_2017_12_03_at_4_39_22_PM;
            this.pictureBox_TheGameLogo.Location = new System.Drawing.Point(584, 153);
            this.pictureBox_TheGameLogo.Name = "pictureBox_TheGameLogo";
            this.pictureBox_TheGameLogo.Size = new System.Drawing.Size(171, 51);
            this.pictureBox_TheGameLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TheGameLogo.TabIndex = 4;
            this.pictureBox_TheGameLogo.TabStop = false;
            // 
            // btn_instructions
            // 
            this.btn_instructions.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_instructions.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_instructions.Image = global::ZombieLandFinal.Properties.Resources.Screen_Shot_2017_12_03_at_4_38_57_PM;
            this.btn_instructions.Location = new System.Drawing.Point(552, 336);
            this.btn_instructions.Name = "btn_instructions";
            this.btn_instructions.Size = new System.Drawing.Size(225, 56);
            this.btn_instructions.TabIndex = 3;
            this.btn_instructions.UseVisualStyleBackColor = true;
            this.btn_instructions.Click += new System.EventHandler(this.btn_instructions_Click);
            // 
            // btn_play
            // 
            this.btn_play.Image = global::ZombieLandFinal.Properties.Resources.Screen_Shot_2017_12_03_at_4_38_42_PM;
            this.btn_play.Location = new System.Drawing.Point(552, 265);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(116, 56);
            this.btn_play.TabIndex = 2;
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // pictureBox_IntroVideo
            // 
            this.pictureBox_IntroVideo.Image = global::ZombieLandFinal.Properties.Resources.NewestIntroVideo;
            this.pictureBox_IntroVideo.Location = new System.Drawing.Point(9, 153);
            this.pictureBox_IntroVideo.Name = "pictureBox_IntroVideo";
            this.pictureBox_IntroVideo.Size = new System.Drawing.Size(537, 257);
            this.pictureBox_IntroVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_IntroVideo.TabIndex = 1;
            this.pictureBox_IntroVideo.TabStop = false;
            // 
            // pictureBox_TWDLogo
            // 
            this.pictureBox_TWDLogo.Image = global::ZombieLandFinal.Properties.Resources.screen_shot_2017_07_22_at_12_41_03_am_e1500704141223;
            this.pictureBox_TWDLogo.Location = new System.Drawing.Point(-1, -16);
            this.pictureBox_TWDLogo.Name = "pictureBox_TWDLogo";
            this.pictureBox_TWDLogo.Size = new System.Drawing.Size(786, 248);
            this.pictureBox_TWDLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_TWDLogo.TabIndex = 0;
            this.pictureBox_TWDLogo.TabStop = false;
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(785, 419);
            this.Controls.Add(this.pictureBox_TheGameLogo);
            this.Controls.Add(this.btn_instructions);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.pictureBox_IntroVideo);
            this.Controls.Add(this.pictureBox_TWDLogo);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Walking Dead Game";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TheGameLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_IntroVideo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_TWDLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_TWDLogo;
        private System.Windows.Forms.PictureBox pictureBox_IntroVideo;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_instructions;
        private System.Windows.Forms.PictureBox pictureBox_TheGameLogo;
    }
}