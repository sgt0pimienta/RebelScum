using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rebel_Scum
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void MissionsButton_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void MissionsButton_Click(object sender, EventArgs e)
        {
            Screens.MissionsScreen MissionsScreen = new Screens.MissionsScreen();
            MissionsScreen.Owner = this;
            MissionsScreen.Show();
            this.Hide();
        }
    }
}
