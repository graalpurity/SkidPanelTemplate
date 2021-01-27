using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skid_Panel_Template_V2.Handler;
using static Skid_Panel_Template_V2.Handler.DiscordH;
using System.Threading;

namespace Skid_Panel_Template_V2.Frms.Controls
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void topMostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (topMostCheckBox.Checked)
            {
                MainFrm.topMost = true;
                MainFrm.ActiveForm.TopMost = true;
            }
            else
            {
                MainFrm.topMost = false;
                MainFrm.ActiveForm.TopMost = false;
            }
        }

        private void closeRpcBtn_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(CheckRPC));
            if(Discord.Initilized == true)
            {
                Discord.Close();
            }
            else
            {
                MessageBox.Show("Discord is not initilized","Skid Panel Template");
            }
        }

        private void restartRpcBtn_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(CheckRPC));
            if (Discord.Initilized == true)
            {
                MessageBox.Show("Discord it already initilized, cannot restart", "Skid Panel Template");
            }
            else
            {
                Discord.Restart();
            }
        }

        public static void CheckRPC()
        {
            Discord.Check();
        }
    }
}
