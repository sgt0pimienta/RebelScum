using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RebelScum.Model;

namespace RebelScum.Engine
{
    public class MissionEngine
    {

        public Mission CreateMission(string name, string type, string scope, string starSystem, string planet)
        {
            int newID = GameState.CreatedMissionCount += 1;

            if (scope == "Galaxy")
            {
                Mission newMission = new Mission(newID, name, type, scope, null, null);
                newMission.summarizedTarget = "Galaxy";
                return newMission;
            }
            else if (scope == "System")
            {
                List<string> targetedPlanets = new List<string>();

                foreach (StarSystem examinedStarSystem in GameState.Galaxy.StarSystems)
                {
                    if (examinedStarSystem.Name == starSystem)
                    {
                        foreach (Planet examinedPlanet in examinedStarSystem.Planets)
                        {
                            targetedPlanets.Add(examinedPlanet.Name);
                        }
                    }
                }

                Mission newMission = new Mission(newID, name, type, scope, starSystem, targetedPlanets);
                newMission.summarizedTarget = starSystem;
                return newMission;
            }
            else
            {
                List<string> targetedPlanets = new List<string>();
                targetedPlanets.Add(planet);
                Mission newMission = new Mission(newID, name, type, scope, starSystem, targetedPlanets);
                newMission.summarizedTarget = planet;
                return newMission;
            }
        }

    }
}
