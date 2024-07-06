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

namespace Pc_man_Game_MOO_ICT_1
{
    public partial class Form1 : Form
    {

        bool goup, godown, goleft, goright, isGameOver;

        int score, playerSpeed, redGhostSpeed, redGhost1Speed, yellowGhostSpeed, pinkGhostX, pinkGhostY, pinkGhost1X, pinkGhost1Y,  yellowGhost1Speed, redGhost2Speed, yellowGhost2Speed;

        private void pictureBox54_Click(object sender, EventArgs e)
        {

        }

        public Form1()
        {
            InitializeComponent();
            resetGame();
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

            if (e.KeyCode  == Keys.Enter && isGameOver == true )
            {
                resetGame();
            }
        }

        private void mainGameTimer(object sender, EventArgs e)
        {

            txtScore.Text = "Score: " + score;

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
                        gameOver("You Lose!");
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
                        gameOver("You Lose!");
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
                gameOver("You Win!");
            }
            
            
        }

        private void resetGame()
        {
            txtScore.Text = "Score: 0";
            score = 0;

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
            pacman.Top = 46;


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

            gameTimer.Start();



        }


        private void gameOver(String message)
        {
            isGameOver = true;

            gameTimer.Start();

            txtScore.Text = "Score: " + score + Environment.NewLine + message;


        }
    }
}
