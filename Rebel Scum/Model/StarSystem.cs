using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RebelScum.UnitsResources;

namespace RebelScum.Model
{
    [Serializable]
    public class StarSystem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Ownership { get; set; }
        public int Support { get; set; } 
        public List<Planet> Planets { get; set; }

        public int TotalGenevaGas { get; set; }
        public int TotalCarbon { get; set; }
        public int TotalTitanium { get; set; }
        public int TotalSequax { get; set; }
        public int TotalTungsten { get; set; }
        public int TotalIron { get; set; }
        public int TotalCobalt { get; set; }
        public int TotalSalatarisExtract { get; set; }
        public int TotalGold { get; set; }
        public int TotalLead { get; set; }
        public int TotalOxygen { get; set; }
        public int TotalChlorine { get; set; }
        public int TotalSillicon { get; set; }
        public int TotalNitrogen { get; set; }
        public int TotalUranium { get; set; }
        public int TotalPlutonium { get; set; }
        public int TotalCreolite { get; set; }
        public int TotalKessium { get; set; }
        public int TotalHydrogen { get; set; }
        public int TotalChalybium { get; set; }
        public int TotalAlumium { get; set; }

        public override string ToString()
        {
            return Name;
        }

        //public int TotalCarbon
        //{
        //    get
        //    {
        //        return Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Carbon").Quantity);
        //    }
        //}

        public StarSystem()
        {
            Planets = new List<Planet>();
            UpdateTotalResources();

        }

        public void UpdateTotalResources()
        {
            TotalGenevaGas = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Geneva Gas").Quantity);
            TotalCarbon = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Carbon").Quantity);
            TotalTitanium = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Titanium").Quantity);
            TotalSequax = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Sequax").Quantity);
            TotalTungsten = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Tungsten").Quantity);
            TotalIron = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Iron").Quantity);
            TotalCobalt = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Cobalt").Quantity);
            TotalSalatarisExtract = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Salataris Extract").Quantity);
            TotalGold = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Gold").Quantity);
            TotalLead = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Lead").Quantity);
            TotalOxygen = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Oxygen").Quantity);
            TotalChlorine = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Chlorine").Quantity);
            TotalSillicon = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Sillicon").Quantity);
            TotalNitrogen = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Nitrogen").Quantity);
            TotalUranium = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Uranium").Quantity);
            TotalPlutonium = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Plutonium").Quantity);
            TotalCreolite = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Creolite").Quantity);
            TotalKessium = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Kessium").Quantity);
            TotalHydrogen = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Hydrogen").Quantity);
            TotalChalybium = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Chalybium").Quantity);
            TotalAlumium = Planets.Sum(p => p.PlanetResources.FirstOrDefault(r => r.Name == "Alumium").Quantity);
        }

    }
}
