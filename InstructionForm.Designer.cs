using System;
using System.IO;

namespace ZombieLandFinal
{
    partial class InstructionForm
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
            this.txt_instructions = new System.Windows.Forms.TextBox();
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_instructions
            // 
            this.txt_instructions.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_instructions.Enabled = false;
            this.txt_instructions.ForeColor = System.Drawing.Color.White;
            this.txt_instructions.Location = new System.Drawing.Point(143, 12);
            this.txt_instructions.Multiline = true;
            this.txt_instructions.Name = "txt_instructions";
            this.txt_instructions.Size = new System.Drawing.Size(490, 313);
            this.txt_instructions.TabIndex = 0;
            this.txt_instructions.Text = "Traverse a world where you are the zombie and are being hunted down. Dodge the hu" +
    "nters and eat as many brains as you can! Beware, if the hunters catch you they w" +
    "ill kill on sight!";
            // 
            // btn_play
            // 
            this.btn_play.Image = global::ZombieLandFinal.Properties.Resources.Screen_Shot_2017_12_03_at_4_381;
            this.btn_play.Location = new System.Drawing.Point(183, 331);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(163, 70);
            this.btn_play.TabIndex = 2;
            this.btn_play.UseVisualStyleBackColor = true;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // btn_back
            // 
            this.btn_back.Image = global::ZombieLandFinal.Properties.Resources.Screen_Shot_2017_12_03_at_4_39_32_PM;
            this.btn_back.Location = new System.Drawing.Point(385, 331);
            this.btn_back.Margin = new System.Windows.Forms.Padding(1);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(219, 70);
            this.btn_back.TabIndex = 2;
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // InstructionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(785, 419);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.txt_instructions);
            this.Name = "InstructionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Walking Dead Game";
            this.Load += new System.EventHandler(this.InstructionMusic_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_instructions;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_play;
    }
}