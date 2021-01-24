using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
    }
}
