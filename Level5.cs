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
    public partial class Level5 : Form
    {
        System.Media.SoundPlayer music = new System.Media.SoundPlayer();
        System.Media.SoundPlayer effect = new System.Media.SoundPlayer();
        List<PictureBox> brainsList = new List<PictureBox>();
        int score = 0;
        bool canRight = true;
        bool canLeft = true;
        bool canLeft2 = true;

        public Level5()
        {
            InitializeComponent();
            music.SoundLocation = "TWD_levelTheme.wav";
            effect.SoundLocation = "BrainEating.wav";
            KeyDown += new KeyEventHandler(Level5_KeyDown);
            scoreBoard.Text = $"Score: {score}";
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

        private void Timer1_Tick(object sender, EventArgs e)
        {
            DaryleMove();
            Rick1Move();
            NeganMove();

            //if the zombie runs into one of the humans the game is over, can reset
            if (rick1.Bounds.IntersectsWith(zombie.Bounds) ||
                daryle.Bounds.IntersectsWith(zombie.Bounds) ||
                negan.Bounds.IntersectsWith(zombie.Bounds))
            {
                timer1.Stop();
                scoreBoard.Text = "GAME OVER!";
                string name = "Level5";
                GameOver go = new GameOver(name);
                go.Show();
                this.Close();
            }

            //if you collect all the brains, this moves you to the second level
            if (score == 38)
            {
                new Scores(score, "level5");
                YouWin win = new YouWin();
                win.Show();
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
                negan.Location = new Point(x - 35, y);
            }
            else
            {
                negan.Location = new Point(x + 35, y);
            }

            if (negan.Bounds.IntersectsWith(westBounds.Bounds))
            {
                negan.Location = new Point(x + 35, y);
                canLeft = false;
            }

            if (negan.Bounds.IntersectsWith(eastBounds.Bounds))
            {
                negan.Location = new Point(x - 35, y);
                canLeft = true;
            }
        }

        //the move methods set up the auto movement of the humans , sets speed and direction
        private void Rick1Move()
        {
            int x = rick1.Location.X;
            int y = rick1.Location.Y;

            if (canRight == true)
            {
                rick1.Location = new Point(x + 35, y);
            }
            else
            {
                rick1.Location = new Point(x - 35, y);
            }

            if (rick1.Bounds.IntersectsWith(westBounds.Bounds))
            {
                rick1.Location = new Point(x + 35, y);
                canRight = true;
            }

            if (rick1.Bounds.IntersectsWith(eastBounds.Bounds))
            {
                rick1.Location = new Point(x - 35, y);
                canRight = false;
            }
        }
        //the move methods set up the auto movement of the humans , sets speed and direction
        private void DaryleMove()
        {
            int x = daryle.Location.X;
            int y = daryle.Location.Y;

            if (canLeft2 == true)
            {
                daryle.Location = new Point(x - 35, y);
            }
            else
            {
                daryle.Location = new Point(x + 35, y);
            }

            if (daryle.Bounds.IntersectsWith(wall13.Bounds))
            {
                daryle.Location = new Point(x - 35, y);
                canLeft2 = false;
            }

            if (daryle.Bounds.IntersectsWith(eastBounds.Bounds))
            {
                daryle.Location = new Point(x - 35, y);
                canLeft2 = true;
            }
        }
        //Method to allow user to control the zombie using the arrow keys
        private void Level5_KeyDown(object sender, KeyEventArgs e)
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
                    zombie.Bounds.IntersectsWith(wall12.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall13.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall14.Bounds))
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
                    zombie.Bounds.IntersectsWith(wall12.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall13.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall14.Bounds))
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
                    zombie.Bounds.IntersectsWith(wall12.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall13.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall14.Bounds))
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
                    zombie.Bounds.IntersectsWith(wall12.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall13.Bounds) ||
                    zombie.Bounds.IntersectsWith(wall14.Bounds))
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

        private void scoreBoard_Click(object sender, EventArgs e)
        {

        }
    }
}




