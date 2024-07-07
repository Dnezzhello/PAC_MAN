using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pc_man_Game_MOO_ICT_1
{
    public partial class GameOverDialog : Form
    {
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
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void lblEndGame_Click(object sender, EventArgs e)
        {

        }
    }
}
