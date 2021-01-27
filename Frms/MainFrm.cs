using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Skid_Panel_Template_V2.Handler;
using static Skid_Panel_Template_V2.Handler.Skid.Forms;
using static Skid_Panel_Template_V2.Handler.DiscordH;

namespace Skid_Panel_Template_V2
{ 

    public partial class MainFrm : Form
    {
        public static bool topMost = false;
        public static bool Frying = false;

        public MainFrm()
        {
            InitializeComponent();
        }

        private void MainFrm_Load(object sender, EventArgs e)
        {
            Discord.DiscordID();
            Discord.Start();
            Panel.Controls.Clear();
            var Home = new Frms.Controls.Home();
            Panel.Controls.Add(Home);
        }

        private void booterBtn_Click(object sender, EventArgs e)
        {
            Discord.Booter();
            Panel.Controls.Clear();
            var Booter = new Frms.Controls.Booter();
            Panel.Controls.Add(Booter);
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            Discord.Settings();
            Panel.Controls.Clear();
            var Settings = new Frms.Controls.Settings();
            Panel.Controls.Add(Settings);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            Discord.Homepage();
            Panel.Controls.Clear();
            var Home = new Frms.Controls.Home();
            Panel.Controls.Add(Home);
        }
    }
}
