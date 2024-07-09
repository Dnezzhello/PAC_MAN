using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.Drawing.Printing;

namespace Pc_man_Game_MOO_ICT_1
{
    public partial class Form1 : Form
    {
        private SoundPlayer soundEating;
        private SoundPlayer soundBeginning;
        private SoundPlayer soundBackground;

        bool goup, godown, goleft, goright, isGameOver;

        int score, highestScore, playerSpeed, redGhostSpeed, redGhost1Speed, yellowGhostSpeed, pinkGhostX, pinkGhostY, pinkGhost1X, pinkGhost1Y,  yellowGhost1Speed, redGhost2Speed, yellowGhost2Speed;

        private void Form1_Load(object sender, EventArgs e)
        {
            soundBeginning.Play();

            // Wait for the beginning sound to finish before starting the background music
            int beginningDuration = 5000; // Adjust this value based on the actual duration of your beginning sound in milliseconds
            Timer backgroundMusicTimer = new Timer();
            backgroundMusicTimer.Interval = beginningDuration;
            backgroundMusicTimer.Tick += (s, args) =>
            {
                StartBackgroundMusic();
                backgroundMusicTimer.Stop();
                backgroundMusicTimer.Dispose();
            };
            backgroundMusicTimer.Start();
        }

        private void pictureBox54_Click(object sender, EventArgs e)
        {

        }

   

        public Form1()
        {
            soundEating = new SoundPlayer(Properties.Resources.pacman_chomp);
            soundBeginning = new SoundPlayer(Properties.Resources.pacman_beginning);
            soundBackground = new SoundPlayer(Properties.Resources.pac_man_background);
            InitializeComponent();
            highestScore = 0; // Initialize highest score
            resetGame();
        }


        private void StartBackgroundMusic()
        {
            soundBackground.PlayLooping();
        }


        public void StopBackgroundMusic()
        {
            soundBackground.Stop();
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            
            if (e.KeyCode == Keys.Left)
            {
                goleft = true;
                pacman.Image = Properties.Resources.left;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = true;
                pacman.Image = Properties.Resources.right;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = true;
                pacman.Image = Properties.Resources.Up;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = true;
                pacman.Image = Properties.Resources.down;
            }

        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goleft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goright = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goup = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                godown = false;
            }
            /*
            if (e.KeyCode  == Keys.Enter && isGameOver == true )
            {
                resetGame();
            }
            */
        }

        private void mainGameTimer(object sender, EventArgs e)
        {

            txtScore.Text = "ຄະແນນ: " + score;

            if (score > highestScore)
            {
                highestScore = score;
                txtHighestScore.Text = "ຄະແນນສູງສຸດ: " + highestScore;
            }

            if (goleft == true)
            {
                pacman.Left -= playerSpeed;
                pacman.Image = Properties.Resources.left;
            }
            if (goright == true)
            {
                pacman.Left += playerSpeed;
                pacman.Image = Properties.Resources.right;

            }
            if (godown == true)
            {
                pacman.Top += playerSpeed;
                pacman.Image = Properties.Resources.down;
            }
            if (goup == true)
            {
                pacman.Top -= playerSpeed;
                pacman.Image = Properties.Resources.Up;
            }

            if (pacman.Left < -10)
            {
                pacman.Left = 680;
            }
            if (pacman.Left > 680)
            {
                pacman.Left = -10;
            }
            if (pacman.Top < -10)
            {
                pacman.Top = 550;
            }
            if (pacman.Top > 550)
            {
                pacman.Top = 0;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                    if ((string)x.Tag == "coin" && x.Visible == true)
                    {
                        if (pacman.Bounds.IntersectsWith(x.Bounds))
                        {
                            score += 1;
                            x.Visible = false;
                        }
                    }

                }
                if ((string)x.Tag == "wall")
                {

                    if (pacman.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameOver("ທ່ານແພ້ແລ້ວ!");
                    }

                    if (pinkGhost.Bounds.IntersectsWith (x.Bounds ))
                    {
                        pinkGhostX = -pinkGhostX;
                    }

                    if (pinkGhost1.Bounds.IntersectsWith(x.Bounds))
                    {
                        pinkGhost1X = -pinkGhost1X;
                    }
                }

                if ((string)x.Tag == "ghost")
                {
                    if (pacman.Bounds.IntersectsWith(x.Bounds))
                    {
                        gameOver("ທ່ານແພ້ແລ້ວ!");
                    }
                }
            }

            // moving ghosts
            redGhost.Left += redGhostSpeed;
            if (redGhost.Bounds.IntersectsWith(pictureBox1.Bounds) || redGhost.Bounds.IntersectsWith(pictureBox2.Bounds))
            {
                redGhostSpeed = -redGhostSpeed;
            }


            redGhost1.Left += redGhost1Speed;
            if (redGhost1.Bounds.IntersectsWith(pictureBox3.Bounds) || redGhost1.Bounds.IntersectsWith(pictureBox55.Bounds))
            {
                redGhost1Speed = -redGhost1Speed;
            }

            redGhost2.Left += redGhost2Speed;
            if (redGhost2.Bounds.IntersectsWith(pictureBox55.Bounds) || redGhost2.Bounds.IntersectsWith(pictureBox73.Bounds))
            {
                redGhost2Speed = -redGhost2Speed;
            }

            yellowGhost.Left -= yellowGhostSpeed;

            if (yellowGhost.Bounds.IntersectsWith(pictureBox4.Bounds) || yellowGhost.Bounds.IntersectsWith(pictureBox3.Bounds))
            {
                yellowGhostSpeed = -yellowGhostSpeed;
            }


            yellowGhost1.Left -= yellowGhost1Speed;

            if (yellowGhost1.Bounds.IntersectsWith(pictureBox54.Bounds) || yellowGhost1.Bounds.IntersectsWith(pictureBox76.Bounds))
            {
                yellowGhost1Speed = -yellowGhost1Speed;
            }


            yellowGhost2.Left -= yellowGhost2Speed;

            if (yellowGhost2.Bounds.IntersectsWith(pictureBox56.Bounds) || yellowGhost2.Bounds.IntersectsWith(pictureBox78.Bounds))
            {
                yellowGhost2Speed = -yellowGhost2Speed;
            }


            pinkGhost.Left -= pinkGhostX;
            pinkGhost.Top -= pinkGhostY;

            if (pinkGhost.Top < 0 || pinkGhost.Top > 320)
            {
                pinkGhostY = -pinkGhostY;
            }

            if (pinkGhost.Left < 0 || pinkGhost.Left > 920)
            {
                pinkGhostX = -pinkGhostX;
            }

            pinkGhost1.Top -= pinkGhost1Y;
            pinkGhost1.Left -= pinkGhost1X;
           
            
            if (pinkGhost1.Top < 0 || pinkGhost1.Top > 480)
            {
                pinkGhost1Y = -pinkGhost1Y;
            }

            if (pinkGhost1.Left < 0 || pinkGhost1.Left > 924)
            {
                pinkGhost1X = -pinkGhost1X;
            }


            if (score == 101)
            {
                gameOver("ທ່ານຊະນະແລ້ວ!");
            }
            
            
        }

        private void resetGame()
        {
            txtScore.Text = "ຄະແນນ: 0";
            txtHighestScore.Text = "ຄະແນນສູງສຸດ: " + highestScore;
            score = 0;




            // Reset movement flags
            goleft = false;
            goright = false;
            goup = false;
            godown = false;

            // Reset Pac-Man image to default (you may need to adjust this based on your resources)
            pacman.Image = Properties.Resources.right;

            redGhostSpeed = 5;
            redGhost1Speed = 2;
            redGhost2Speed = 5;
            yellowGhostSpeed = 5;
            yellowGhost1Speed = 7;
            yellowGhost2Speed = 2;
            pinkGhostX = 5;
            pinkGhostY = 5;
            pinkGhost1X = 5;
            pinkGhost1Y = 5;
            playerSpeed = 8;

            isGameOver = false;

            pacman.Left = 31;
            pacman.Top = 91;


            redGhost.Left = 150;
            redGhost.Top = 40;

            yellowGhost.Left = 290;
            yellowGhost.Top = 280;


            pinkGhost.Left = 300;
            pinkGhost.Top = 150;

            pinkGhost1.Left = 143;
            pinkGhost1.Top = 484;


            foreach (Control x in this.Controls)
            {
                if (x is PictureBox)
                {
                   x.Visible = true;
                }
            }


            // Start the background music after a delay
            Timer backgroundMusicTimer = new Timer();
            backgroundMusicTimer.Interval = 5000; // Adjust this value based on the length of your beginning sound
            backgroundMusicTimer.Tick += (s, args) =>
            {
                StartBackgroundMusic();
                backgroundMusicTimer.Stop();
                backgroundMusicTimer.Dispose();
            };
            backgroundMusicTimer.Start();

            gameTimer.Start();
        }


        private void gameOver(String message)
        {
            isGameOver = true;
            gameTimer.Stop();

            if (score > highestScore)
            {
                highestScore = score;
            }

            txtScore.Text = "ຄະແນນ: " + score;
            txtHighestScore.Text = "ຄະແນນສູງສຸດ: " + highestScore + Environment.NewLine + message;

            using (var gameOverDialog = new GameOverDialog(this))  // Pass 'this' to the dialog
            {
                gameOverDialog.Message = message;
                gameOverDialog.Score = score;
                gameOverDialog.HighScore = highestScore;

                if (gameOverDialog.ShowDialog() == DialogResult.OK)
                {
                    resetGame();
                }
                else
                {
                    this.Close();
                }
            }
        }
    }
}
