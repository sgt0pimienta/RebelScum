using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rebel_Scum.Screens
{
    public class Screen : Form
    {
        public Screen() : base()
        {
            Height = 480;
            Width = 640;
            this.FormClosing += Screen_FormClosing;
        }

        private void Screen_FormClosing(object sender, EventArgs e)
        {
            this.Owner.Show();
        }
    }
}
