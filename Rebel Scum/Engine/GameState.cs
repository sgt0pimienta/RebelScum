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
    public class GameState
    {
        //Missions
        public DateTime GameStart { get; set; }
        public List<MissionTemplate> AllMissionTemplates { get; set; }
        public List<Mission> ActiveMissions { get; set; }
        public int CreatedMissionCount { get; set; }

        //Galaxy
        public Galaxy Galaxy { get; set;}
        public int CreatedPlanetCount { get; set; }
        public int PlanetCount { get; set; }
        public int CreatedSystemCount { get; set; }
        public int SystemCount { get; set; }
        public List<string> PlanetNames { get; set; }
        public List<string> StarSystemNames { get; set; }

        //Calendar
        public int SimpleDate { get; set; }
        public string ComplexDate { get; set; }

        public GameState()
        {
            ActiveMissions = new List<Mission>();
        }
    }
}
