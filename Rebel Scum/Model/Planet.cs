using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RebelScum.UnitsResources;

namespace RebelScum.Model
{
    [Serializable]
    public class Planet
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public int Size { get; set; }
        public int Temperature { get; set; }

        public List<Resource> PlanetResources { get; set; }
        
        public int planetNumber { get; set; }
        //list of units
        //list of facilities

        public override string ToString()
        {
            return Name;
        }

        public Planet()
        {
            PlanetResources = new List<Resource>();
            
            PlanetResources.Add(new Resource("Geneva Gas", 0, 0));
            PlanetResources.Add(new Resource("Carbon", 0));
            PlanetResources.Add(new Resource("Titanium", 0, 0));
            PlanetResources.Add(new Resource("Sequax", 0, 0));
            PlanetResources.Add(new Resource("Tungsten", 0));
            PlanetResources.Add(new Resource("Iron", 0));
            PlanetResources.Add(new Resource("Cobalt", 0));
            PlanetResources.Add(new Resource("Salataris Extract", 0));
            PlanetResources.Add(new Resource("Copper", 0));
            PlanetResources.Add(new Resource("Gold", 0));
            PlanetResources.Add(new Resource("Lead", 0));
            PlanetResources.Add(new Resource("Oxygen", 0));
            PlanetResources.Add(new Resource("Chlorine", 0));
            PlanetResources.Add(new Resource("Sillicon", 0));
            PlanetResources.Add(new Resource("Nitrogen", 0));
            PlanetResources.Add(new Resource("Uranium", 0));
            PlanetResources.Add(new Resource("Plutonium", 0));
            PlanetResources.Add(new Resource("Creolite", 0));
            PlanetResources.Add(new Resource("Kessium", 0));
            PlanetResources.Add(new Resource("Hydrogen", 0));
            PlanetResources.Add(new Resource("Chalybium", 0));
            PlanetResources.Add(new Resource("Alumium", 0, -100));

            foreach (Resource resource in PlanetResources)
            {
                if (this.Status == "Rebel") { resource.Owner = "Rebel"; }
                else { resource.Owner = "Hegmon"; }
            }
        }
    }
}
