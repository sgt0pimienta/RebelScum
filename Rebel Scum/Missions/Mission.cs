using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RebelScum.Galaxies;
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
        public List<int> TargetPlanetId { get; set; }

        [XmlIgnore]
        public Planet TargetPlanet { get; set; }
        public StarSystem TargetSystem { get; set; }

        public Mission()
        {

        }

        public Mission(string name, string type, string scope /*List<Planet> target planets */ )
        {
            Name = name;
            MissionType = type;
            MissionScope = scope;
        }

    }
}
