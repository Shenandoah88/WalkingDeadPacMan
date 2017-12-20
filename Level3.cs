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
    public partial class Level3 : Form
    {
        System.Media.SoundPlayer music = new System.Media.SoundPlayer();
        System.Media.SoundPlayer effect = new System.Media.SoundPlayer();
        List<PictureBox> brainsList = new List<PictureBox>();
        int score = 0;
        bool canRight = true;
        bool canLeft = true;
        bool canLeft2 = true;
        public Level3()
        {
            InitializeComponent();
            music.SoundLocation = "TWD_levelTheme.wav";
            effect.SoundLocation = "BrainEating.wav";
            KeyDown += new KeyEventHandler(Level3_KeyDown);
            scoreBoard.Text = $"Score: {score}";
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
        private void Timer1_Tick(object sender, EventArgs e)
        {

            DaryleMove();
            NeganMove();

            //if the zombie runs into one of the humans the game is over, can reset
            if (daryle.Bounds.IntersectsWith(zombie.Bounds) ||
                negan.Bounds.IntersectsWith(zombie.Bounds))
            {
                timer1.Stop();
                scoreBoard.Text = "GAME OVER!";
                string name = "Level3";
                GameOver go = new GameOver(name);
                go.Show();
                this.Close();
            }

            //if you collect all the brains, this moves you to the second level
            if (score == 28)
            {
                new Scores(score, "level3");
                string name = "Level3";
                NextLevel nl = new NextLevel(name);
                nl.Show();
                this.Close();
            }

            //score counter and disposes of brains
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
        //the move methods set up the auto movement of the humans , sets speed and direction
        private void NeganMove()
        {
            int x = negan.Location.X;
            int y = negan.Location.Y;

            if (canLeft == true)
            {
                negan.Location = new Point(x - 5, y);
            }
            else
            {
                negan.Location = new Point(x + 5, y);
            }

            if (negan.Bounds.IntersectsWith(westBounds.Bounds))
            {
                negan.Location = new Point(x + 5, y);
                canLeft = false;
            }

            if (negan.Bounds.IntersectsWith(eastBounds.Bounds))
            {
                negan.Location = new Point(x - 5, y);
                canLeft = true;
            }
        }


        //the move methods set up the auto movement of the humans , sets speed and direction
        private void DaryleMove()
        {
            int x = daryle.Location.X;
            int y = daryle.Location.Y;

            if (canLeft2 == true)
            {
                daryle.Location = new Point(x - 5, y);
            }
            else
            {
                daryle.Location = new Point(x + 5, y);
            }

            if (daryle.Bounds.IntersectsWith(westBounds.Bounds))
            {
                daryle.Location = new Point(x - 5, y);
                canLeft2 = false;
            }

            if (daryle.Bounds.IntersectsWith(eastBounds.Bounds))
            {
                daryle.Location = new Point(x - 5, y);
                canLeft2 = true;
            }
        }
        //Method to allow user to control the zombie using the arrow keys
        private void Level3_KeyDown(object sender, KeyEventArgs e)
        {
            int x = zombie.Location.X;
            int y = zombie.Location.Y;

            if (e.KeyCode == Keys.Right)
            {
                if (zombie.Bounds.IntersectsWith(eastBounds.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall1.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall2.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall3.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall4.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall5.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall6.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall7.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall8.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall9.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall10.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall11.Bounds) ||
                    zombie.Bounds.IntersectsWith(scoreBoard.Bounds))
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
                    zombie.Bounds.IntersectsWith(wall1.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall2.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall3.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall4.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall5.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall6.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall7.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall8.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall9.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall10.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall11.Bounds) ||
                    zombie.Bounds.IntersectsWith(scoreBoard.Bounds))
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
                    zombie.Bounds.IntersectsWith(wall1.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall2.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall3.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall4.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall5.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall6.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall7.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall8.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall9.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall10.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall11.Bounds) ||
                    zombie.Bounds.IntersectsWith(scoreBoard.Bounds))
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
                    zombie.Bounds.IntersectsWith(wall1.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall2.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall3.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall4.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall5.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall6.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall7.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall8.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall9.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall10.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall11.Bounds) ||
                    zombie.Bounds.IntersectsWith(scoreBoard.Bounds))
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
    }
}



