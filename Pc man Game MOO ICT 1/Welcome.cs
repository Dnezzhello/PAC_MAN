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
        public Welcome()
        {
            soundClick = new SoundPlayer(Properties.Resources.click_bottom_);
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {

            soundClick.PlaySync();
            Form1 mainForm = new Form1();

            this.Hide();

            mainForm.ShowDialog();
            

            this.Close();

        }

        private void btnGameDetail_Click(object sender, EventArgs e)
        {
            soundClick.Play();
        }
    }
}
