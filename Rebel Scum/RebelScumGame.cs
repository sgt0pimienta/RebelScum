using RebelScum.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RebelScum.Missions;
using RebelScum.Classes;
using System.Xml.Serialization;
using System.ComponentModel;

namespace RebelScum
{
    [Serializable]
    public static class RebelScumGame
    {
        public static DateTime GameStart { get; set; }
        public static List<MissionTemplate> allMissionTemplates { get; set; }
        public static List<Mission> activeMissions { get; set;}
        public static int activeMissionCount { get; set; }

        
        static RebelScumGame()
        {
            activeMissions = MissionProvider.GetActiveMissions();
            activeMissionCount = activeMissions.Count;
        }
    }
}
