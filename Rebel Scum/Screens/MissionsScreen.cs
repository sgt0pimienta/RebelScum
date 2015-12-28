using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RebelScum.Screens
{
    public partial class MissionsScreen : ScreenBase
    {

        public MissionsScreen() : base()
        {
            InitializeComponent();
            RefreshData();
        }

        protected void RefreshData() {
            label1.Text = RebelScumGame.GameStart.ToString();
            label2.Text = RebelScumGame.LastAction.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RebelScumGame.LastAction = DateTime.Now;
            RefreshData();
        }
    }
}
