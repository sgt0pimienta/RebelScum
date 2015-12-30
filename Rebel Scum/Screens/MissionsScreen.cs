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

            var missions = MissionProvider.GetMissions();

            MissionProvider.GetMissions();

        }

        public void missionListRefresh(List<string> targetList)
        {
            missionListDropdown.Items.Clear();
            missionListDropdown.Items.Add(targetList);
        }

        private void missionScopeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            missionListRefresh(null);
        }

        private void missionTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            missionListRefresh(null);
        }

        private void createMissionButton_Click(object sender, EventArgs e)
        {

        }
    }
}
