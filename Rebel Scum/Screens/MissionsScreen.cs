using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RebelScum.Missions;
using RebelScum.Classes;

namespace RebelScum.Screens
{
    public partial class MissionsScreen : ScreenBase
    {

        public static string missionScope;
        public static string missionType;
        public static string mission;

        public MissionsScreen() : base()
        {
            InitializeComponent();
            activeMissionsTable.AutoGenerateColumns = false;
            activeMissionsTable.DataSource = RebelScumGame.activeMissionsBindingList;
        }

        public void activeMissionListRefresh(List<string> targetList)
        {
            //missionListDropdown.Items.Clear();
            //missionListDropdown.Items.Add(targetList);
        }

        private void missionScopeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //availablemissionListRefresh(null);
        }

        private void missionTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            //availablemissionListRefresh(null);
        }

        private void createMissionButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(missionTypeDropdown.Text))
            {
                var result = MessageBox.Show("You must select a mission type, dingus", "Dingus Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if(result == DialogResult.No)
                {
                    MessageBox.Show("Don't alegate");
                }
                return;
            }
            RebelScumGame.activeMissions.Add(MissionProvider.createMission("Test", missionTypeDropdown.Text, missionScopeDropdown.Text));
            RebelScumGame.refreshActiveMissionBinding();
            activeMissionsTable.DataSource = RebelScumGame.activeMissionsBindingList;
        }

        private void MissionsScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            MissionProvider.SaveActiveMissions();
        }
    }
}
