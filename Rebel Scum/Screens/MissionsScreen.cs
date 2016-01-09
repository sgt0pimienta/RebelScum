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

namespace RebelScum.Screens
{
    public partial class MissionsScreen : ScreenBase
    {

        public static string missionScope;
        public static string missionType;
        public static string mission;
        public static BindingList<Mission> activeMissionsBindingList;

        public static MissionTemplate missioninitiator;

        public MissionsScreen() : base()
        {
            InitializeComponent();
            activeMissionsTable.AutoGenerateColumns = false;
            activeMissionsBindingList = new BindingList<Mission>(RebelScumGame.ActiveMissions);
            activeMissionsTable.DataSource = activeMissionsBindingList;

            missioninitiator = new MissionTemplate();
            missioninitiator.Id = 1;
            missioninitiator.Alignment = "Rebellion";
            missioninitiator.Scope = "System";
            missioninitiator.Name = "Agressive blockade of system trading";
            missioninitiator.Type = "Economic";
            RebelScumGame.AllMissionTemplates.Add(missioninitiator);
            MissionProvider.WriteAllMissionsList();
        }

        public void ActiveMissionListRefresh(List<string> targetList)
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
            //if (string.IsNullOrWhiteSpace(missionTypeDropdown.Text))
            //{
            //    var result = MessageBox.Show("You must select a mission type, dingus", "Dingus Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //    if(result == DialogResult.No)
            //    {
            //        MessageBox.Show("Don't alegate");
            //    }
            //    return;
            //}

            activeMissionsBindingList.Add(MissionProvider.CreateMission("Test", missionTypeDropdown.Text, missionScopeDropdown.Text));
        }

        private void MissionsScreen_FormClosing(object sender, FormClosingEventArgs e)
        {
            //activeMissionsBindingList = new BindingList<Mission>(RebelScumGame.activeMissions);
            //RebelScumGame.activeMissions = activeMissionsBindingList.ToList();
            MissionProvider.SaveActiveMissions();
            //
            //** ^^^ Poner en MainMenu o en RebelScumGame ^^^ **
            //
        }

        private void btnDeleteMission_Click(object sender, EventArgs e)
        {
            activeMissionsBindingList.Remove((Mission)activeMissionsTable.SelectedRows[0].DataBoundItem);
        }
    }
}
