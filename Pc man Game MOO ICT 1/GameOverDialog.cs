using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Pc_man_Game_MOO_ICT_1
{


    public partial class GameOverDialog : Form
    {

        SoundPlayer soundDeath = new SoundPlayer(@"D:\C#\computer-graphic\pac-man\PAC_MAN\Pc man Game MOO ICT 1\Media\pacman_death.wav");
        SoundPlayer soundBackground = new SoundPlayer(@"D:\C#\computer-graphic\pac-man\PAC_MAN\Pc man Game MOO ICT 1\Media\pacman_beginning.wav");

        public string Message { get; set; }
        public int Score { get; set; }
        public int HighScore { get; set; }  

        public GameOverDialog()
        {
            InitializeComponent();

        }

        private void GameOverDialog_Load(object sender, EventArgs e)
        {
            lblEndGame.Text = Message;
            score.Text = $"ຄະແນນ: {Score}";
            highestScore.Text = $"ຄະແນນສູງສຸດ: {HighScore}";
            soundDeath.Play();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
            soundBackground.Play();
        }

        private void lblEndGame_Click(object sender, EventArgs e)
        {

        }
    }
}
