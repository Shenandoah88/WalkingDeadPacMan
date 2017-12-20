namespace ZombieLandFinal
{
    partial class NextLevel
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PictureBox_1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_3 = new System.Windows.Forms.PictureBox();
            this.PictureBox_NextLevel = new System.Windows.Forms.PictureBox();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_NextLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PictureBox_1
            // 
            this.PictureBox_1.Image = global::ZombieLandFinal.Properties.Resources.Screen_Shot_2017_12_02_at_8_15_19_AM;
            this.PictureBox_1.Location = new System.Drawing.Point(321, 273);
            this.PictureBox_1.Name = "PictureBox_1";
            this.PictureBox_1.Size = new System.Drawing.Size(153, 101);
            this.PictureBox_1.TabIndex = 3;
            this.PictureBox_1.TabStop = false;
            // 
            // pictureBox_2
            // 
            this.pictureBox_2.Image = global::ZombieLandFinal.Properties.Resources.Screen_Shot_2017_12_02_at_8_15_04_AM;
            this.pictureBox_2.Location = new System.Drawing.Point(321, 273);
            this.pictureBox_2.Name = "pictureBox_2";
            this.pictureBox_2.Size = new System.Drawing.Size(153, 101);
            this.pictureBox_2.TabIndex = 2;
            this.pictureBox_2.TabStop = false;
            // 
            // pictureBox_3
            // 
            this.pictureBox_3.Image = global::ZombieLandFinal.Properties.Resources.Screen_Shot_2017_12_02_at_8_14_29_AM;
            this.pictureBox_3.Location = new System.Drawing.Point(321, 273);
            this.pictureBox_3.Name = "pictureBox_3";
            this.pictureBox_3.Size = new System.Drawing.Size(153, 101);
            this.pictureBox_3.TabIndex = 1;
            this.pictureBox_3.TabStop = false;
            // 
            // PictureBox_NextLevel
            // 
            this.PictureBox_NextLevel.BackColor = System.Drawing.Color.Red;
            this.PictureBox_NextLevel.Image = global::ZombieLandFinal.Properties.Resources.Screen_Shot_2017_12_02_at_8_13_53_AM;
            this.PictureBox_NextLevel.Location = new System.Drawing.Point(12, 44);
            this.PictureBox_NextLevel.Name = "PictureBox_NextLevel";
            this.PictureBox_NextLevel.Size = new System.Drawing.Size(761, 204);
            this.PictureBox_NextLevel.TabIndex = 0;
            this.PictureBox_NextLevel.TabStop = false;
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // NextLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(785, 419);
            this.Controls.Add(this.PictureBox_1);
            this.Controls.Add(this.pictureBox_2);
            this.Controls.Add(this.pictureBox_3);
            this.Controls.Add(this.PictureBox_NextLevel);
            this.Name = "NextLevel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NextLevel";
            this.Load += new System.EventHandler(this.NextLevel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox_NextLevel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox PictureBox_NextLevel;
        private System.Windows.Forms.PictureBox pictureBox_3;
        private System.Windows.Forms.PictureBox pictureBox_2;
        private System.Windows.Forms.PictureBox PictureBox_1;
        private System.Windows.Forms.Timer timer2;
    }
}