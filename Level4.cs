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
    public partial class Level4 : Form
    {
        System.Media.SoundPlayer music = new System.Media.SoundPlayer();
        System.Media.SoundPlayer effect = new System.Media.SoundPlayer();
        List<PictureBox> brainsList = new List<PictureBox>();
        int score = 0;
        bool canUpwards = true;
        bool canLeft = true;
        bool canLeft2 = true;

        public Level4()
        {
            InitializeComponent();
            music.SoundLocation = "TWD_levelTheme.wav";
            effect.SoundLocation = "BrainEating.wav";
            KeyDown += new KeyEventHandler(Level4_KeyDown);
            scoreBoard.Text = $"Score: {score}";
            brainsList.Add(brains41);
            brainsList.Add(brains40);
            brainsList.Add(brains39);
            brainsList.Add(brains38);
            brainsList.Add(brains37);
            brainsList.Add(brains36);
            brainsList.Add(brains35);
            brainsList.Add(brains34);
            brainsList.Add(brains33);
            brainsList.Add(brains32);
            brainsList.Add(brains31);
            brainsList.Add(brains30);
            brainsList.Add(brains29);
            brainsList.Add(brains28);
            brainsList.Add(brains27);
            brainsList.Add(brains26);
            brainsList.Add(brains25);
            brainsList.Add(brains24);
            brainsList.Add(brains23);
            brainsList.Add(brains22);
            brainsList.Add(brains21);
            brainsList.Add(brains20);
            brainsList.Add(brains19);
            brainsList.Add(brains18);
            brainsList.Add(brains17);
            brainsList.Add(brains16);
            brainsList.Add(brains15);
            brainsList.Add(brains14);
            brainsList.Add(brains13);
            brainsList.Add(brains12);
            brainsList.Add(brains11);
            brainsList.Add(brains10);
            brainsList.Add(brains9);
            brainsList.Add(brains8);
            brainsList.Add(brains7);
            brainsList.Add(brains6);
            brainsList.Add(brains5);
            brainsList.Add(brains4);
            brainsList.Add(brains3);
            brainsList.Add(brains2);
            brainsList.Add(brains1);
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            DaryleMove();
            NeganMove();
            Rick1Move();


            if (rick1.Bounds.IntersectsWith(zombieGirl.Bounds) ||
                negan.Bounds.IntersectsWith(zombieGirl.Bounds) ||
                daryle.Bounds.IntersectsWith(zombieGirl.Bounds))

            {
                timer1.Stop();
                scoreBoard.Text = "GAME OVER!";
                string name = "Level4";
                GameOver go = new GameOver(name);
                go.Show();
                this.Close();
            }

            //if you collect all the brains, this moves you to the second level
            if (score == 41)
            {
                new Scores(score, "level4");
                string name = "Level4";
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
                    if (brain.Bounds.IntersectsWith(zombieGirl.Bounds))
                    {
                        brain.Dispose();
                        score++;
                        scoreBoard.Text = $"Score: {score}";
                    }
                }
            }

        }

        private void Rick1Move()
        {
            int x = rick1.Location.X;
            int y = rick1.Location.Y;

            if (canLeft == true)
            {
                rick1.Location = new Point(x - 10, y);
            }
            else
            {
                rick1.Location = new Point(x + 10, y);
            }

            if (rick1.Bounds.IntersectsWith(westBounds.Bounds))
            {
                rick1.Location = new Point(x + 10, y);
                canLeft = false;
            }

            if (rick1.Bounds.IntersectsWith(wall3.Bounds))
            {
                rick1.Location = new Point(x - 10, y);
                canLeft = true;
            }
        }
        private void NeganMove()
        {
            int x = negan.Location.X;
            int y = negan.Location.Y;

            if (canLeft2 == true)
            {
                negan.Location = new Point(x - 10, y);
            }
            else
            {
                negan.Location = new Point(x + 10, y);
            }

            if (negan.Bounds.IntersectsWith(westBounds.Bounds))
            {
                negan.Location = new Point(x + 10, y);
                canLeft2 = false;
            }

            if (negan.Bounds.IntersectsWith(wall4.Bounds))
            {
                negan.Location = new Point(x - 10, y);
                canLeft2 = true;
            }
        }


        private void DaryleMove()
        {
            int x = daryle.Location.X;
            int y = daryle.Location.Y;

            if (canUpwards == true)
            {
                daryle.Location = new Point(x, y - 10);
            }
            else
            {
                daryle.Location = new Point(x, y + 10);
            }

            if (daryle.Bounds.IntersectsWith(northBounds.Bounds))
            {
                daryle.Location = new Point(x, y + 10);
                canUpwards = false;
            }

            if (daryle.Bounds.IntersectsWith(southBounds.Bounds))
            {
                daryle.Location = new Point(x, y - 10);
                canUpwards = true;
            }
        }
        private void Level4_KeyDown(object sender, KeyEventArgs e)
        {
            int x = zombieGirl.Location.X;
            int y = zombieGirl.Location.Y;

            if (e.KeyCode == Keys.Right)
            {
                if (zombieGirl.Bounds.IntersectsWith(eastBounds.Bounds) ||
                    zombieGirl.Bounds.IntersectsWith(wall1.Bounds) ||
                    zombieGirl.Bounds.IntersectsWith(wall2.Bounds) ||
                    zombieGirl.Bounds.IntersectsWith(wall3.Bounds) ||
                    zombieGirl.Bounds.IntersectsWith(wall4.Bounds))
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
                if (zombieGirl.Bounds.IntersectsWith(westBounds.Bounds) ||
                    zombieGirl.Bounds.IntersectsWith(wall1.Bounds) ||
                    zombieGirl.Bounds.IntersectsWith(wall2.Bounds) ||
                    zombieGirl.Bounds.IntersectsWith(wall3.Bounds) ||
                    zombieGirl.Bounds.IntersectsWith(wall4.Bounds))
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
                if (zombieGirl.Bounds.IntersectsWith(northBounds.Bounds) ||
                   zombieGirl.Bounds.IntersectsWith(wall1.Bounds) ||
                    zombieGirl.Bounds.IntersectsWith(wall2.Bounds) ||
                    zombieGirl.Bounds.IntersectsWith(wall3.Bounds) ||
                    zombieGirl.Bounds.IntersectsWith(wall4.Bounds))
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
                if (zombieGirl.Bounds.IntersectsWith(southBounds.Bounds) ||
                    zombieGirl.Bounds.IntersectsWith(wall1.Bounds) ||
                    zombieGirl.Bounds.IntersectsWith(wall2.Bounds) ||
                    zombieGirl.Bounds.IntersectsWith(wall3.Bounds) ||
                    zombieGirl.Bounds.IntersectsWith(wall4.Bounds))
                {
                    y -= 20;
                }
                else
                {
                    y += 10;
                }

            }
            zombieGirl.Location = new Point(x, y);
        }

        void Level_4_ThemeLoad(object sender, EventArgs e)
        {
            music.PlayLooping();
        }

        void SoundEffect(object sender, EventArgs e)
        {
            effect.Play();
        }


    }
}







