using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RebelScum.Screens
{
    public partial class ScreenBase : Form
    {

        public ScreenBase() : base()
        {
            InitializeComponent();
        }

        private void ScreenBase_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Owner.Show();
        }
    }
}

