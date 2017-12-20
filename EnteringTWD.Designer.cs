namespace ZombieLandFinal
{
    partial class EnteringTWD
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
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_Num3 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Num2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_Num1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_YouAreEntering = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Num3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Num2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Num1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_YouAreEntering)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 200;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // pictureBox_Num3
            // 
            this.pictureBox_Num3.Image = global::ZombieLandFinal.Properties.Resources.Screen_Shot_2017_12_03_at_4_38_19_PM;
            this.pictureBox_Num3.Location = new System.Drawing.Point(331, 338);
            this.pictureBox_Num3.Name = "pictureBox_Num3";
            this.pictureBox_Num3.Size = new System.Drawing.Size(141, 123);
            this.pictureBox_Num3.TabIndex = 4;
            this.pictureBox_Num3.TabStop = false;
            // 
            // pictureBox_Num2
            // 
            this.pictureBox_Num2.Image = global::ZombieLandFinal.Properties.Resources.Screen_Shot_2017_12_03_at_4_37_56_PM;
            this.pictureBox_Num2.Location = new System.Drawing.Point(331, 348);
            this.pictureBox_Num2.Name = "pictureBox_Num2";
            this.pictureBox_Num2.Size = new System.Drawing.Size(123, 123);
            this.pictureBox_Num2.TabIndex = 3;
            this.pictureBox_Num2.TabStop = false;
            // 
            // pictureBox_Num1
            // 
            this.pictureBox_Num1.Image = global::ZombieLandFinal.Properties.Resources.Screen_Shot_2017_12_03_at_4_37_44_PM;
            this.pictureBox_Num1.Location = new System.Drawing.Point(331, 348);
            this.pictureBox_Num1.Name = "pictureBox_Num1";
            this.pictureBox_Num1.Size = new System.Drawing.Size(101, 125);
            this.pictureBox_Num1.TabIndex = 2;
            this.pictureBox_Num1.TabStop = false;
            // 
            // pictureBox_YouAreEntering
            // 
            this.pictureBox_YouAreEntering.Image = global::ZombieLandFinal.Properties.Resources.Screen_Shot_2017_12_03_at_4_37_17_PM;
            this.pictureBox_YouAreEntering.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox_YouAreEntering.Name = "pictureBox_YouAreEntering";
            this.pictureBox_YouAreEntering.Size = new System.Drawing.Size(724, 526);
            this.pictureBox_YouAreEntering.TabIndex = 0;
            this.pictureBox_YouAreEntering.TabStop = false;
            // 
            // EnteringTWD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(715, 442);
            this.Controls.Add(this.pictureBox_Num3);
            this.Controls.Add(this.pictureBox_Num2);
            this.Controls.Add(this.pictureBox_Num1);
            this.Controls.Add(this.pictureBox_YouAreEntering);
            this.Name = "EnteringTWD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EnteringTWD";
            this.Load += new System.EventHandler(this.EnteringTWD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Num3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Num2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_Num1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_YouAreEntering)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_YouAreEntering;
        private System.Windows.Forms.PictureBox pictureBox_Num1;
        private System.Windows.Forms.PictureBox pictureBox_Num2;
        private System.Windows.Forms.PictureBox pictureBox_Num3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}