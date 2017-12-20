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
 * The main page is the starting form. The player can choose
 * to read the instructions or start the game. This form also
 * plays the theme music
 * 
 */

namespace ZombieLandFinal
{
    public partial class MainPage : Form
    {
        System.Media.SoundPlayer music = new System.Media.SoundPlayer();
        public static List<Scores> scores = new List<Scores>();
        public MainPage()
        {
            InitializeComponent();
            music.SoundLocation = "TWD_theme.wav";
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            EnteringTWD entering = new EnteringTWD();
            entering.Show();
            music.Stop();
            this.Hide();

        }

        private void btn_instructions_Click(object sender, EventArgs e)
        {
            InstructionForm Instructions = new InstructionForm();
            music.Stop();
            Instructions.Show();
            this.Hide();
        }

        private void MainPage_Load(object sender, EventArgs e)
        {
            music.Play();
        }

        public static void DisplayScores()
        {
            var Level1Scores =
                from s in scores
                where s._level == "Level1"
                select s._score;

            var Level2Scores =
    from s in scores
    where s._level == "Level2"
    select s._score;

            var Level3Scores =
    from s in scores
    where s._level == "Level3"
    select s._score;

            var Level4Scores =
    from s in scores
    where s._level == "Level4"
    select s._score;

            var Level5Scores =
    from s in scores
    where s._level == "Level5"
    select s._score;
        }
    }
}
