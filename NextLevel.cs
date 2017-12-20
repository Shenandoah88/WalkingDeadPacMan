using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * Authors Jonathan Ostler, Marcell Romero, Shenandoah Stubbs
 * Form pops up in between levels when the player eats all the 
 * brains.. Tells the player they are advancing to the next level.
 * 
 */
namespace ZombieLandFinal
{
    public partial class NextLevel : Form
    {
        string _level;
        public NextLevel(string lvl)
        {
            InitializeComponent();
            _level = lvl;
        }

        private void NextLevel_Load(object sender, EventArgs e)
        {
            PictureBox_1.Visible = false;
            pictureBox_2.Visible = false;
            pictureBox_3.Visible = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBox_3.Visible == false && pictureBox_2.Visible == false && PictureBox_1.Visible == false)
            {
                pictureBox_3.Visible = true;
            }
            else if (pictureBox_3.Visible == true)
            {
                pictureBox_3.Visible = false;
                pictureBox_2.Visible = true;
            }
            else if (pictureBox_2.Visible == true)
            {
                pictureBox_2.Visible = false;
                PictureBox_1.Visible = true;
            }
            else if (PictureBox_1.Visible == true)
            {
                PictureBox_1.Visible = false;

                switch (_level)
                {
                    case "Form1":
                        Level2 lvl2 = new Level2();
                        lvl2.Show();
                        break;
                    case "Level2":
                        Level3 lvl3 = new Level3();
                        lvl3.Show();
                        break;
                    case "Level3":
                        Level4 lvl4 = new Level4();
                        lvl4.Show();
                        break;
                    case "Level4":
                        Level5 lvl5 = new Level5();
                        lvl5.Show();
                        break;


                }

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
