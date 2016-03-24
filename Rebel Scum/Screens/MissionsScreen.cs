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
using RebelScum.Galaxies;

namespace RebelScum.Screens
{
    public partial class MissionsScreen : ScreenBase
    {

        public static string missionScope;
        public static string missionType;
        public static string mission;
        public static BindingList<Mission> activeMissionsBindingList;
        public static List<MissionTemplate> availableMissionList;

        public MissionsScreen() : base()
        {
            InitializeComponent();
            activeMissionsTable.AutoGenerateColumns = false;
            activeMissionsBindingList = new BindingList<Mission>(MissionProvider.FetchLoadedMissions());
            activeMissionsTable.DataSource = activeMissionsBindingList;
        }

        public void RefreshAvailableMissions()
        {
            missionNameDropdown.Items.Clear();
            availableMissionList = new List<MissionTemplate>((MissionProvider.BuildPossibleMissionList(this.missionTypeDropdown.Text, this.missionScopeDropdown.Text)));
            foreach (MissionTemplate element in availableMissionList)
            {
                missionNameDropdown.Items.Add(element.Name);
            }
        }

        public void RefreshTargetSystems()
        {
            targetSystemDropdown.Items.Clear();
            if (missionScopeDropdown.Text != "Galaxy")
            {
                foreach (String starSystemName in GalaxyManager.FetchSystemNames())
                {
                    targetSystemDropdown.Items.Add(starSystemName);
                }
            }
            //else { targetSystemDropdown.Items.Add("N/A"); }
        }

        public void RefreshTargetPlanets()
        {
            targetPlanetDropdown.Items.Clear();
            if (missionScopeDropdown.Text == "Planet")
            {
                foreach (String planetName in GalaxyManager.FetchLocalPlanetNames(targetSystemDropdown.Text))
                {
                    targetPlanetDropdown.Items.Add(planetName);
                }
            }
            //else { targetPlanetDropdown.Items.Add("N/A"); }

        }

        private void missionScopeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAvailableMissions();
            RefreshTargetPlanets();
            RefreshTargetSystems();
        }

        private void missionTypeDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshAvailableMissions();
        }

        private void createMissionButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(missionTypeDropdown.Text))
            {
                var result = MessageBox.Show("You must select a mission type, dingus", "Dingus Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            activeMissionsBindingList.Add(MissionProvider.CreateMission(missionNameDropdown.Text, missionTypeDropdown.Text, missionScopeDropdown.Text, targetSystemDropdown.Text, targetPlanetDropdown.Text));
        }

        private void MissionsScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            MissionProvider.SerializeActiveMissions();
        }

        private void btnDeleteMission_Click(object sender, EventArgs e)
        {
            activeMissionsBindingList.Remove((Mission)activeMissionsTable.SelectedRows[0].DataBoundItem);
        }

        private void MissionsScreen_Load(object sender, EventArgs e)
        {

        }

        private void missionListDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void targetSystemDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            RefreshTargetPlanets();
        }
    }
}
