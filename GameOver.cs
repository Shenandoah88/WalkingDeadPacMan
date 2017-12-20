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
 * This form displays when a player loses a level. Gives the 
 * player an option of restarting the level, or the whole game.
 */
namespace ZombieLandFinal
{
    public partial class GameOver : Form
    {

        string _level;

        public GameOver(string lvl)
        {
            InitializeComponent();
            _level = lvl;
        }

        private void btn_yes_Click(object sender, EventArgs e)
        {
            switch (_level)
            {
                case "Form1":
                    Form1 lvl1 = new Form1();
                    lvl1.Show();
                    break;
                case "Level2":
                    Level2 lvl2 = new Level2();
                    lvl2.Show();
                    break;
                case "Level3":
                    Level3 lvl3 = new Level3();
                    lvl3.Show();
                    break;
                case "Level4":
                    Level4 lvl4 = new Level4();
                    lvl4.Show();
                    break;
                case "Level5":
                    Level5 lvl5 = new Level5();
                    lvl5.Show();
                    break;
            }
            this.Close();
        }

        private void btn_no_Click(object sender, EventArgs e)
        {
            MainPage mp = new MainPage();
            mp.Show();
            this.Hide();
        }
    }
}
