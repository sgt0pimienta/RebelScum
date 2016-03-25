using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RebelScum.Model;
using RebelScum.Engine;

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
            activeMissionsBindingList = new BindingList<Mission>(GameState.ActiveMissions);
            activeMissionsTable.DataSource = activeMissionsBindingList;
        }

        public void RefreshAvailableMissions()
        {
            missionNameDropdown.Items.Clear();

            foreach (MissionTemplate template in GameState.AllMissionTemplates)
            {
                if ((template.Scope == this.missionScopeDropdown.Text)&&(template.Type == this.missionTypeDropdown.Text))
                {
                    missionNameDropdown.Items.Add(template.Name);
                }
            }
        }

        public void RefreshTargetSystems()
        {
            targetSystemDropdown.Items.Clear();
            if (missionScopeDropdown.Text != "Galaxy")
            {
                foreach (StarSystem starSystem in GameState.Galaxy.StarSystems)
                {
                    targetSystemDropdown.Items.Add(starSystem.Name);
                }
            }
        }

        public void RefreshTargetPlanets()
        {
            targetPlanetDropdown.Items.Clear();
            if (missionScopeDropdown.Text == "Planet")
            {
                foreach (StarSystem starSystem in GameState.Galaxy.StarSystems)
                {
                    if (starSystem.Name == targetSystemDropdown.Text)
                    {
                        foreach (Planet planet in starSystem.Planets)
                        {
                            targetPlanetDropdown.Items.Add(planet.Name);
                        }
                    }
                }
            }
        }

        public bool ValidateMissionParameters()
        {
            if (string.IsNullOrWhiteSpace(missionScopeDropdown.Text))
            {
                MessageBox.Show("Select mission scope", "Invalid Mission", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return false;
            }
            else
            {
                if (missionScopeDropdown.Text == "Galaxy")
                {
                    if ((string.IsNullOrWhiteSpace(missionTypeDropdown.Text)) || (string.IsNullOrWhiteSpace(missionNameDropdown.Text)))
                    {
                        MessageBox.Show("Missing mission parameters", "Invalid Mission", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return false;
                    }
                }
                else if (missionScopeDropdown.Text == "System")
                {
                    if ((string.IsNullOrWhiteSpace(missionTypeDropdown.Text) || (string.IsNullOrWhiteSpace(missionNameDropdown.Text) || (string.IsNullOrWhiteSpace(targetSystemDropdown.Text)))))
                    {
                        MessageBox.Show("Missing mission parameters", "Invalid Mission", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return false;
                    }
                }
                else if (missionScopeDropdown.Text == "Planet")
                {
                    if ((string.IsNullOrWhiteSpace(missionTypeDropdown.Text) || (string.IsNullOrWhiteSpace(missionNameDropdown.Text) || (string.IsNullOrWhiteSpace(targetSystemDropdown.Text) || (string.IsNullOrWhiteSpace(targetPlanetLabel.Text))))))
                    {
                        MessageBox.Show("Missing mission parameters", "Invalid Mission", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        return false;
                    }
                }
                return true;
            }
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
            if (ValidateMissionParameters() == true)
            {
                if (ValidateMissionParameters() == true)
                {
                    activeMissionsBindingList.Add(RebelEngine.MissionEngine.CreateMission(missionNameDropdown.Text, missionTypeDropdown.Text, missionScopeDropdown.Text, targetSystemDropdown.Text, targetPlanetDropdown.Text));
                }
            }
        }

        private void MissionsScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
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
