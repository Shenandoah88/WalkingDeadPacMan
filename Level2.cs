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
    public partial class Level2 : Form
    {
        System.Media.SoundPlayer music = new System.Media.SoundPlayer();
        System.Media.SoundPlayer effect = new System.Media.SoundPlayer();
        List<PictureBox> brainsList = new List<PictureBox>();
        int score = 0;
        bool canUpwards = true;
        bool canLeft = true;
        bool canDownwards = true;

        public Level2()
        {
            InitializeComponent();
            music.SoundLocation = "TWD_levelTheme.wav";
            effect.SoundLocation = "BrainEating.wav";
            KeyDown += new KeyEventHandler(Level2_KeyDown_1);
            scoreBoard.Text = $"Score: {score}";
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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            Rick1Move();
            NeganMove();
            DaryleMove();

            if (Rick1.Bounds.IntersectsWith(girlZombie.Bounds) ||
                Negan.Bounds.IntersectsWith(girlZombie.Bounds) ||
                Daryle.Bounds.IntersectsWith(girlZombie.Bounds))
            {
                timer1.Stop();
                scoreBoard.Text = "GAME OVER!";
                string name = "Level2";
                GameOver go = new GameOver(name);
                go.Show();
                this.Close();

            }

            //if you collect all the brains, this moves you to the second level
            if (score == 21)
            {
                new Scores(score, "level2");
                string name = "Level2";
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
                else if (brain.Bounds.IntersectsWith(girlZombie.Bounds))
                {
                    brain.Dispose();
                    score++;
                    scoreBoard.Text = $"Score: {score}";
                }
            }
        }



        private void NeganMove()
        {
            int x = Negan.Location.X;
            int y = Negan.Location.Y;

            if (canDownwards == true)
            {
                Negan.Location = new Point(x, y + 10);
            }
            else
            {
                Negan.Location = new Point(x, y - 10);
            }

            if (Negan.Bounds.IntersectsWith(northBounds.Bounds))
            {
                Negan.Location = new Point(x, y + 10);
                canDownwards = true;
            }

            if (Negan.Bounds.IntersectsWith(southBounds.Bounds))
            {
                Negan.Location = new Point(x, y - 10);
                canDownwards = false;
            }
        }

        private void DaryleMove()
        {
            int x = Daryle.Location.X;
            int y = Daryle.Location.Y;

            if (canLeft == true)
            {
                Daryle.Location = new Point(x - 10, y);
            }
            else
            {
                Daryle.Location = new Point(x + 10, y);
            }

            if (Daryle.Bounds.IntersectsWith(wall4.Bounds))
            {
                Daryle.Location = new Point(x + 10, y);
                canLeft = false;
            }

            if (Daryle.Bounds.IntersectsWith(eastBounds.Bounds))
            {
                Daryle.Location = new Point(x - 10, y);
                canLeft = true;
            }
        }


        private void Rick1Move()
        {
            int x = Rick1.Location.X;
            int y = Rick1.Location.Y;

            if (canUpwards == true)
            {
                Rick1.Location = new Point(x, y - 10);
            }
            else
            {
                Rick1.Location = new Point(x, y + 10);
            }

            if (Rick1.Bounds.IntersectsWith(northBounds.Bounds))
            {
                Rick1.Location = new Point(x, y + 10);
                canUpwards = false;
            }

            if (Rick1.Bounds.IntersectsWith(southBounds.Bounds))
            {
                Rick1.Location = new Point(x, y - 10);
                canUpwards = true;
            }


        }


        private void Level2_KeyDown_1(object sender, KeyEventArgs e)
        {
            int x = girlZombie.Location.X;
            int y = girlZombie.Location.Y;

            if (e.KeyCode == Keys.Right)
            {
                if (girlZombie.Bounds.IntersectsWith(eastBounds.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall1.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall2.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall3.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall4.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall5.Bounds))
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
                if (girlZombie.Bounds.IntersectsWith(westBounds.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall1.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall2.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall3.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall4.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall5.Bounds))
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
                if (girlZombie.Bounds.IntersectsWith(northBounds.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall1.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall2.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall3.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall4.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall5.Bounds))
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
                if (girlZombie.Bounds.IntersectsWith(southBounds.Bounds) ||
                   girlZombie.Bounds.IntersectsWith(wall1.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall2.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall3.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall4.Bounds) ||
                    girlZombie.Bounds.IntersectsWith(wall5.Bounds))
                {
                    y -= 20;
                }
                else
                {
                    y += 10;
                }

            }
            girlZombie.Location = new Point(x, y);
        }


        private void SoundEffect(object sender, EventArgs e)
        {
            effect.Play();
        }

        private void Level_2_ThemeLoad(object sender, EventArgs e)
        {
            music.PlayLooping();
        }


    }
}

