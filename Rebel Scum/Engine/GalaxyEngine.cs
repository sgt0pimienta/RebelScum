using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RebelScum.Model;
using RebelScum.Engine;

namespace RebelScum.Engine
{
    public class GalaxyEngine
    {

        private Random random = new Random();

        public  Galaxy CreateGalaxy()
       { 
            var newGalaxy = new Galaxy();
            newGalaxy.Id = 1;
            newGalaxy.Name = "Milky Way";
            int starSystemNumber = random.Next(25, 50);

            for (int i = 1; i < starSystemNumber; i++)
            {
                newGalaxy.StarSystems.Add(CreateSystem());
            }

            return newGalaxy;
        }

        public  StarSystem CreateSystem()
        {
            int ownershipGenerationKey; 
            var newSystem = new StarSystem();
            int planetsInSystem = random.Next(1, 15);
            var systemNameIndex = random.Next(RebelEngine.GameState.StarSystemNames.Count);
            newSystem.Name = RebelEngine.GameState.StarSystemNames[systemNameIndex];
            newSystem.Id = RebelEngine.GameState.CreatedSystemCount + 1;
            RebelEngine.GameState.StarSystemNames.Remove(RebelEngine.GameState.StarSystemNames[systemNameIndex]);

            ownershipGenerationKey = random.Next(1, 100);

            if (ownershipGenerationKey > 99) { newSystem.Ownership = 100; newSystem.Support = 100; }
            else if (ownershipGenerationKey > 0 && ownershipGenerationKey < 20) { newSystem.Ownership = -100; newSystem.Support = 50; }
            else if (ownershipGenerationKey > 20 && ownershipGenerationKey < 30) { newSystem.Ownership = -50; newSystem.Support = 0; }
            else if (ownershipGenerationKey > 30 && ownershipGenerationKey < 40) { newSystem.Ownership = -25; newSystem.Support = 25; }
            else { newSystem.Ownership = -100; newSystem.Support = -100; }

            for (int i = 1; i < planetsInSystem; i++)
            {
                newSystem.Planets.Add(CreatePlanet(i, planetsInSystem, newSystem.Ownership, newSystem.Support, random.Next(1, 25), newSystem.Name));
            }

            RebelEngine.GameState.SystemCount += 1;
            RebelEngine.GameState.CreatedSystemCount += 1;
            newSystem.UpdateTotalResources();
            return newSystem;
        }

        public  Planet CreatePlanet(int planetNumber, int planetsInSystem, int systemOwnership, int systemSupport, int systemTempMultiplyer, string systemName)
        {


            var newPlanet = new Planet();

            newPlanet.planetNumber = planetNumber;
            newPlanet.Id = RebelEngine.GameState.CreatedPlanetCount + 1;
            newPlanet.Ownership = systemOwnership;
            newPlanet.Support = systemSupport;

            if (RebelEngine.GameState.PlanetNames.Count > 15)
            {
                var planetNameIndex = random.Next(RebelEngine.GameState.PlanetNames.Count);
                newPlanet.Name = RebelEngine.GameState.PlanetNames[planetNameIndex];
                RebelEngine.GameState.PlanetNames.Remove(RebelEngine.GameState.PlanetNames[planetNameIndex]);
            }
            else
            {
                switch (newPlanet.planetNumber)
                {
                    case 1: newPlanet.Name = systemName + " Prime"; break;
                    case 2: newPlanet.Name = systemName + " II"; break;
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
            newPlanet.Temperature = (random.Next(1, 100)) * (systemTempMultiplyer) * ((16) - (newPlanet.planetNumber));

            foreach (var resource in newPlanet.PlanetResources)
            {
                resource.Availability = 2 ^ ((random.Next(1, 100) + (resource.Availability)) - 30 / 10);
                if (resource.Availability < 0) { resource.Availability = 0; }
                resource.Quantity = resource.Availability * (newPlanet.Size / 1000);
                if (resource.Quantity < 0) { resource.Quantity = 0; }
            }

            RebelEngine.GameState.CreatedPlanetCount += 1;
            RebelEngine.GameState.PlanetCount += 1;
            return newPlanet;
        }
    }
}
