using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZombieLandFinal
{
    public partial class EnteringTWD : Form
    {
        public EnteringTWD()
        {
            InitializeComponent();
        }

        private void EnteringTWD_Load(object sender, EventArgs e)
        {
            pictureBox_Num1.Visible = false;
            pictureBox_Num2.Visible = false;
            pictureBox_Num3.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox_Num3.Visible == false && pictureBox_Num2.Visible == false && pictureBox_Num1.Visible == false)
            {
                pictureBox_Num3.Visible = true;
            }
            else if (pictureBox_Num3.Visible == true)
            {
                pictureBox_Num3.Visible = false;
                pictureBox_Num2.Visible = true;
            }
            else if (pictureBox_Num2.Visible == true)
            {
                pictureBox_Num2.Visible = false;
                pictureBox_Num1.Visible = true;
            }
            else if (pictureBox_Num1.Visible == true)
            {
                pictureBox_Num1.Visible = false;
                Form1 lvl1 = new Form1();
                lvl1.Show();
                timer1.Stop();
                timer2.Start();
                return;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Hide();
        }

    }
}
