using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pc_man_Game_MOO_ICT_1
{
    public partial class GameManual : Form
    {
        private SoundPlayer soundClick;
        public GameManual()
        {
            InitializeComponent();
            soundClick = new SoundPlayer(Properties.Resources.click_bottom_);
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            soundClick.PlaySync();
            Welcome welcome = new Welcome();
            this.Hide();
            welcome.ShowDialog();
            this.Close();
        }
    }
}
