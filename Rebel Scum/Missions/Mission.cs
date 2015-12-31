using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RebelScum.Classes;
using System.Xml.Serialization;

namespace RebelScum.Missions
{
    [Serializable]
    public class Mission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MissionTemplate MissionTemplate { get; set; }
        public string MissionScope { get; set; }
        public string MissionType { get; set; }

        [XmlIgnore]
        public Planet TargetPlanet { get; set; }
        public StarSystem TargetSystem { get; set; }

        public int TargetPlanetId { get; set; }
    }
}
