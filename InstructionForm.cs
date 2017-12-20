using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
/*
 * Authors Jonathan Ostler, Marcell Romero, Shenandoah Stubbs
 * This form displays the instructions for the game.
 */
namespace ZombieLandFinal
{
    public partial class InstructionForm : Form
    {
        System.Media.SoundPlayer music = new System.Media.SoundPlayer();
        PrivateFontCollection zomfont = new PrivateFontCollection();
        string instructions = null;

        public InstructionForm()
        {

            InitializeComponent();
            music.SoundLocation = "TWD_theme.wav";
            zomfont.AddFontFile("zomfont.ttf");
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(zomfont.Families[0], 15, FontStyle.Regular);
            }

            try
            {
                using (StreamReader reader = new StreamReader("Resources/Zombie_Instructions.txt"))
                {
                    while (!reader.EndOfStream)
                    {
                        instructions = string.Join("", reader.ReadLine());
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("A problem occured:");
                Console.WriteLine(ex.Message);
            }
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            MainPage Main = new MainPage();
            music.Stop();
            Main.Show();
            this.Hide();

        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            Form1 Level1 = new Form1();
            music.Stop();
            Level1.Show();
            this.Hide();
        }

        private void InstructionMusic_Load(object sender, EventArgs e)
        {
            music.Play();
        }
    }
}
