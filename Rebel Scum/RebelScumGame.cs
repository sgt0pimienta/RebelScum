using RebelScum.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RebelScum.Missions;
using RebelScum.Galaxies;
using System.Xml.Serialization;
using System.ComponentModel;

namespace RebelScum
{
    [Serializable]
    public static partial class RebelScumGame
    {
        //Missions
        public static DateTime GameStart { get; set; }
        public static List<MissionTemplate> AllMissionTemplates { get; set; }
        public static List<Mission> ActiveMissions { get; set; }
        public static int CreatedMissionCount { get; set; }

        //Galaxy
        public static Galaxy Galaxy { get; set;}
        public static int CreatedPlanetCount { get; set; }
        public static int PlanetCount { get; set; }
        public static int CreatedSystemCount { get; set; }
        public static int SystemCount { get; set; }

        static RebelScumGame()
        {
            ActiveMissions = MissionProvider.GetActiveMissions();
            CreatedMissionCount = ActiveMissions.Count;
            AllMissionTemplates = new List<MissionTemplate>();
            Galaxy = GalaxyManager.createGalaxy();
        }
    }
}
