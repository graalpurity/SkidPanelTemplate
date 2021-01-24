using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Skid_Panel_Template_V2.Handler.DiscordH;

namespace Skid_Panel_Template_V2.Frms.Controls
{
    public partial class Booter : UserControl
    {
        public Booter()
        {
            InitializeComponent();
        }

        private void Booter_Load(object sender, EventArgs e)
        {

        }

        private void bootBtn_Click(object sender, EventArgs e)
        {
            MainFrm.Frying = true;
            Discord.Frying();
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            MainFrm.Frying = false;
            Discord.Frying(); //update the status to false
        }
    }
}
