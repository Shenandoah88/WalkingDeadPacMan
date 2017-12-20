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
 * Each level has a list of brains, keeps track of the brains, 
 * removes them when a zombie eats one, and increases the score.
 * has a zombie aka the player, with a method allowing them to 
 * move with arrow keys, also preventing the zombie form walking
 * through walls. There are humans who have move methods that have
 * them moving based on their location. inside the timer the game plays 
 * and interacts with the player based on their moves.
 * 
 */
namespace ZombieLandFinal
{
    public partial class Form1 : Form
    {
        System.Media.SoundPlayer music = new System.Media.SoundPlayer();
        System.Media.SoundPlayer effect = new System.Media.SoundPlayer();
        List<PictureBox> brainsList = new List<PictureBox>();
        int score = 0;
        bool canUpwards = true;
        bool canLeft = true;

        public Form1()
        {
            InitializeComponent();
            music.SoundLocation = "TWD_levelTheme.wav";
            effect.SoundLocation = "BrainEating.wav";
            KeyDown += new KeyEventHandler(Form1_KeyDown);
            scoreBoard.Text = $"Score: {score}";
            brainsList.Add(brain18);
            brainsList.Add(brain19);
            brainsList.Add(brain20);
            brainsList.Add(brain3);
            brainsList.Add(brain6);
            brainsList.Add(brain5);
            brainsList.Add(brain2);
            brainsList.Add(brain12);
            brainsList.Add(brain4);
            brainsList.Add(brain14);
            brainsList.Add(brain13);
            brainsList.Add(brain15);
            brainsList.Add(brain16);
            brainsList.Add(brain17);
            brainsList.Add(brain7);
            brainsList.Add(brain1);
            brainsList.Add(brain11);
            brainsList.Add(brain8);
            brainsList.Add(brain9);
            brainsList.Add(brain10);

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            GlenMove();
            RickMove();

            if (rick.Bounds.IntersectsWith(zombie.Bounds) ||
                glen.Bounds.IntersectsWith(zombie.Bounds))
            {
                timer1.Stop();
                scoreBoard.Text = "GAME OVER!";

                string name = "Form1";
                GameOver go = new GameOver(name);
                go.Show();
                this.Close();

            }

            //if you collect all the brains, this moves you to the second level
            
            if (score == 20)
            {
                new Scores(score, "level1");
                string name = "Form1";
                NextLevel nl = new NextLevel(name);
                nl.Show();
                this.Close();
            }

            //score counter and disposes of brains.
            foreach (PictureBox brain in brainsList)
            {
                if (brain.IsDisposed)
                {

                }
                else
                {        
                    if (brain.Bounds.IntersectsWith(zombie.Bounds))
                    {
                        brain.Dispose();
                        score++;
                        scoreBoard.Text = $"Score: {score}";
                    }
                }
            }

        }

        private void RickMove()
        {
            int x = rick.Location.X;
            int y = rick.Location.Y;

            if (canLeft == true)
            {
                rick.Location = new Point(x - 10, y);
            }
            else
            {
                rick.Location = new Point(x + 10, y);
            }

            if (rick.Bounds.IntersectsWith(obstacle2.Bounds))
            {
                rick.Location = new Point(x + 10, y);
                canLeft = false;
            }

            if (rick.Bounds.IntersectsWith(obstacle4.Bounds))
            {
                rick.Location = new Point(x - 10, y);
                canLeft = true;
            }
        }


        private void GlenMove()
        {
            int x = glen.Location.X;
            int y = glen.Location.Y;

            if (canUpwards == true)
            {
                glen.Location = new Point(x, y - 10);
            }
            else
            {
                glen.Location = new Point(x, y + 10);
            }

            if (glen.Bounds.IntersectsWith(northBounds.Bounds))
            {
                glen.Location = new Point(x, y + 10);
                canUpwards = false;
            }

            if (glen.Bounds.IntersectsWith(southBounds.Bounds))
            {
                glen.Location = new Point(x, y - 10);
                canUpwards = true;
            }


        }

        void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            int x = zombie.Location.X;
            int y = zombie.Location.Y;

            if (e.KeyCode == Keys.Right)
            {
                if (zombie.Bounds.IntersectsWith(eastBounds.Bounds) ||
                    zombie.Bounds.IntersectsWith(obstacle1.Bounds) ||
                    zombie.Bounds.IntersectsWith(obstacle2.Bounds) ||
                    zombie.Bounds.IntersectsWith(obstacle3.Bounds) ||
                    zombie.Bounds.IntersectsWith(obstacle4.Bounds))
                {
                    x -= 20;
                }
                else
                {
                    x += 10;
                }

            }
            else if (e.KeyCode == Keys.Left)
            {
                if (zombie.Bounds.IntersectsWith(westBounds.Bounds) ||
                    zombie.Bounds.IntersectsWith(obstacle1.Bounds) ||
                    zombie.Bounds.IntersectsWith(obstacle2.Bounds) ||
                    zombie.Bounds.IntersectsWith(obstacle3.Bounds) ||
                    zombie.Bounds.IntersectsWith(obstacle4.Bounds))
                {
                    x += 20;
                }
                else
                {
                    x -= 10;
                }

            }
            else if (e.KeyCode == Keys.Up)
            {
                if (zombie.Bounds.IntersectsWith(northBounds.Bounds) ||
                    zombie.Bounds.IntersectsWith(obstacle1.Bounds) ||
                    zombie.Bounds.IntersectsWith(obstacle2.Bounds) ||
                    zombie.Bounds.IntersectsWith(obstacle3.Bounds) ||
                    zombie.Bounds.IntersectsWith(obstacle4.Bounds))
                {
                    y += 20;
                }
                else
                {
                    y -= 10;
                }

            }
            else if (e.KeyCode == Keys.Down)
            {
                if (zombie.Bounds.IntersectsWith(southBounds.Bounds) ||
                    zombie.Bounds.IntersectsWith(obstacle1.Bounds) ||
                    zombie.Bounds.IntersectsWith(obstacle2.Bounds) ||
                    zombie.Bounds.IntersectsWith(obstacle3.Bounds) ||
                    zombie.Bounds.IntersectsWith(obstacle4.Bounds))
                {
                    y -= 20;
                }
                else
                {
                    y += 10;
                }

            }
            zombie.Location = new Point(x, y);
        }

        private void LevelTheme_Load(object sender, EventArgs e)
        {
            music.PlayLooping(); ;
        }

        private void SoundEffect(object sender, EventArgs e)
        {
            effect.Play();
        }
    }

}



