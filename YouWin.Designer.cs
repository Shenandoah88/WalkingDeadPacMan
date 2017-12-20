namespace ZombieLandFinal
{
    partial class YouWin
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
            this.winGraphics = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.winGraphics)).BeginInit();
            this.SuspendLayout();
            // 
            // winGraphics
            // 
            this.winGraphics.Image = global::ZombieLandFinal.Properties.Resources.Screen_Shot_2017_12_02_at_8_17_22_AM;
            this.winGraphics.Location = new System.Drawing.Point(91, 12);
            this.winGraphics.Name = "winGraphics";
            this.winGraphics.Size = new System.Drawing.Size(800, 456);
            this.winGraphics.TabIndex = 0;
            this.winGraphics.TabStop = false;
            // 
            // YouWin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(785, 419);
            this.Controls.Add(this.winGraphics);
            this.Name = "YouWin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YouWin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.YouWin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.winGraphics)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox winGraphics;
    }
}