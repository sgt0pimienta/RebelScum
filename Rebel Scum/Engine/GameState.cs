using RebelScum.Screens;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RebelScum.Engine;
using RebelScum.Services;
using RebelScum.Model;
using System.Xml.Serialization;
using System.ComponentModel;

namespace RebelScum.Engine
{
    [Serializable]
    public static partial class GameState
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
        public static List<string> PlanetNames { get; set; }
        public static List<string> StarSystemNames { get; set; }

        //Calendar
        public static int Day { get; set; }
        public static int Month { get; set; }
        public static int Year { get; set; }

        static GameState()
        {
            ActiveMissions = MissionManager.DeserializeActiveMissions();
            AllMissionTemplates = MissionManager.DeserializeMissionTemplateList();
            PlanetNames = GalaxyManager.DeserializePlanetNames();
            StarSystemNames = GalaxyManager.DeserializeSystemNames();
            //CLEARLY BROKEN, CreatedMissionCount = ActiveMissions.Count; == Duplicate mission ID's if you close and open the game.
            CreatedMissionCount = ActiveMissions.Count;
            Galaxy = RebelEngine.GalaxyEngine.CreateGalaxy();
        }
    }
}
