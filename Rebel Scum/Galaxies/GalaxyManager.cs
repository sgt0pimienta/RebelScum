using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace RebelScum.Galaxies
{
    public static class GalaxyManager
    {
        private static Random random = new Random();
        private static List<string> systemNames = new List<string>(File.ReadAllLines("SystemNames.txt"));
        private static List<string> planetNames = new List<string>(File.ReadAllLines("PlanetNames.txt"));

        public static Galaxy createGalaxy()
        {
            var newGalaxy = new Galaxy();
            newGalaxy.Id = 1;
            newGalaxy.Name = "Milky Way";
            int starSystemNumber = random.Next(300, 1000);

            for (int i = 1; i < starSystemNumber; i++)
            {
                newGalaxy.StarSystems.Add(createSystem());
            }

            return newGalaxy;
        }

        public static StarSystem createSystem()
        {
            var newSystem = new StarSystem();
            newSystem.Id = RebelScumGame.CreatedSystemCount + 1;
            int planetsInSystem = random.Next(1, 15);
            var systemNameIndex = random.Next(systemNames.Count);
            newSystem.Name = systemNames[systemNameIndex];
            systemNames.Remove(systemNames[systemNameIndex]);

            if (random.Next(1,100)>99){newSystem.Status = "Free";}
            else{newSystem.Status = "Hegmon";}

            for (int i = 1; i < planetsInSystem; i++)
            {
                newSystem.Planets.Add(createPlanet(i, planetsInSystem, newSystem.Status, random.Next(1,25),newSystem.Name));
            }

            RebelScumGame.SystemCount += 1;
            RebelScumGame.CreatedSystemCount += 1;
            return newSystem;
        }

        public static Planet createPlanet(int planetNumber, int planetsInSystem, string systemStatus, int systemTempMultiplyer, string systemName)
        {


            var newPlanet = new Planet();

            newPlanet.planetNumber = planetNumber;
            newPlanet.Id = RebelScumGame.CreatedPlanetCount + 1;
            newPlanet.Status = systemStatus;

            if (planetNames.Count > 15)
            {
                var planetNameIndex = random.Next(planetNames.Count);
                newPlanet.Name = planetNames[planetNameIndex];
                planetNames.Remove(planetNames[planetNameIndex]);
            }
            else
            {
                switch (newPlanet.planetNumber)
                {
                    case 1:  newPlanet.Name = systemName + " Prime"; break;
                    case 2:  newPlanet.Name = systemName + " II"; break;
                    case 3: newPlanet.Name = systemName + " III"; break;
                    case 4: newPlanet.Name = systemName + " IV"; break;
                    case 5: newPlanet.Name = systemName + " V"; break;
                    case 6: newPlanet.Name = systemName + " VI"; break;
                    case 7: newPlanet.Name = systemName + " VII"; break;
                    case 8: newPlanet.Name = systemName + " VIII"; break;
                    case 9: newPlanet.Name = systemName + " IX"; break;
                    case 10: newPlanet.Name = systemName + " X"; break;
                    case 11: newPlanet.Name = systemName + " XI"; break;
                    case 12: newPlanet.Name = systemName + " XII"; break;
                    case 13: newPlanet.Name = systemName + " XIII"; break;
                    case 14: newPlanet.Name = systemName + " XIV"; break;
                    case 15: newPlanet.Name = systemName + " XV"; break;
                    case 16: newPlanet.Name = systemName + " XVI"; break;
                }
            }

            newPlanet.Size = random.Next(1000, 100000);
            newPlanet.Temperature = (random.Next(1, 100))*(systemTempMultiplyer)*((16)-(newPlanet.planetNumber));

            foreach(var resource in newPlanet.PlanetResources)
            {
                resource.Availability = 2 ^ ((random.Next(1, 100) + (resource.Availability)) -30/10);
                if (resource.Availability < 0) { resource.Availability = 0; }
                resource.Quantity = resource.Availability * 100;
            }

            RebelScumGame.CreatedPlanetCount += 1;
            RebelScumGame.PlanetCount += 1;
            return newPlanet;
        }
    }
}
