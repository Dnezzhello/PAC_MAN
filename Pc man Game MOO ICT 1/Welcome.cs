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
    public partial class Welcome : Form
    {
        private SoundPlayer soundClick;
        private SoundPlayer soundTheme;
        public Welcome()
        {
            soundClick = new SoundPlayer(Properties.Resources.click_bottom_);
            soundTheme = new SoundPlayer(Properties.Resources.GTA_San_Andreas_Theme);
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            soundTheme.Stop();
            soundClick.PlaySync();
            Main mainForm = new Main();

            this.Hide();

            mainForm.ShowDialog();
            

            this.Close();

        }

        private void btnGameDetail_Click(object sender, EventArgs e)
        {
            
            soundClick.PlaySync();
            soundTheme.Play();
            GameManual gameManual = new GameManual();
            this.Hide();
            gameManual.ShowDialog();
            this.Close();
        }

        private void Welcome_Load(object sender, EventArgs e)
        {
            soundTheme.Play();
        }
    }
}
