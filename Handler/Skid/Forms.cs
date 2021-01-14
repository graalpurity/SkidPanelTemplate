using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skid_Panel_Template_V2.Handler.Skid
{
    public static class Forms
    {
        public static void Home(object sender, EventArgs e)
        {
            var Main = new MainFrm();
            //Main.Panel.Controls.Add(object);
        }

        public static void ClearPanel()
        {
            var Main = new MainFrm();
            Main.Panel.Controls.Clear();
        }
    }
}
