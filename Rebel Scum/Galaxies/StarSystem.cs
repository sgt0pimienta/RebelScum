using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelScum.Galaxies
{
    [Serializable]
    public class StarSystem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public List<Planet> Planets { get; set; }

        public override string ToString()
        {
            return Name;
        }

        public int TotalCarbon
        {
            get
            {
                return Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Carbon").Quantity);
            }
        }


        public StarSystem()
        {
            Planets = new List<Planet>();
        }
    }
}
