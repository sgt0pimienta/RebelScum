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
            Mission newMission = new Mission();
            int newID = RebelEngine.GameState.CreatedMissionCount += 1;
            MissionTemplate usedTemplate = fetchMissionTemplate(name);

            if (scope == "Galaxy")
            {
                newMission = new Mission(newID, name, type, scope, "Galaxy");
            }
            else if (scope == "System")
            {
                newMission = new Mission(newID, name, type, scope, starSystem);
            }
            else
            {
                newMission = new Mission(newID, name, type, scope, planet);
            }

            newMission.BaseSuccessChance = usedTemplate.BaseSuccessChance;
            return newMission;
        }

        public void UpdateMissions (int timelapse)
        {
            foreach (Mission mission in RebelEngine.GameState.ActiveMissions)
            {

            }
        }

        public MissionTemplate fetchMissionTemplate(string name)
        {
            foreach (MissionTemplate template in RebelEngine.GameState.AllMissionTemplates)
            {
                if (template.Name.Equals(name, StringComparison.InvariantCultureIgnoreCase))
                {
                    return template;
                }
            }
            return RebelEngine.GameState.AllMissionTemplates[1];
            throw new System.ArgumentException("Mission template with that name no longer exists in XML file ", "name");
        }

    }
}

/* LEFTOVER CODE TO FIND MISSION'S TARGET

List<string> targetedPlanets = new List<string>();

foreach (StarSystem examinedStarSystem in RebelEngine.GameState.Galaxy.StarSystems)
{
    if (examinedStarSystem.Name == starSystem)
    {
        foreach (Planet examinedPlanet in examinedStarSystem.Planets)
        {
            targetedPlanets.Add(examinedPlanet.Name);
        }
    }
}
*/
