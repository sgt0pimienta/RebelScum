using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using RebelScum.Galaxies;

namespace RebelScum.Missions
{
    public static class MissionProvider
    {

        private static XmlSerializer activeMissionSerializer = new XmlSerializer(typeof(List<Mission>));
        private static XmlSerializer missionTemplateSerializer = new XmlSerializer(typeof(List<MissionTemplate>));

        public static List<Mission> DeserializeActiveMissions()
        {
            using (var missionFileStream = File.OpenRead("mission.xml"))
            {
                return (List<Mission>)activeMissionSerializer.Deserialize(missionFileStream);
            }
        }

        public static void SerializeActiveMissions()
        {
            File.Delete("mission.xml");
            using (var missionFileStream = File.OpenWrite("mission.xml"))
            {
                activeMissionSerializer.Serialize(missionFileStream, RebelScumGame.ActiveMissions);
            }
        }

        public static Mission CreateMission(string name, string type, string scope, string starSystem, string planet)
        {
            int newID = RebelScumGame.CreatedMissionCount += 1;

            if (scope == "Galaxy")
            {
                Mission newMission = new Mission(newID, name, type, scope, null, null);
                return newMission;
            }
            else if (scope == "System")
            {
                List<string> targetedPlanets = new List<string>();

                foreach (StarSystem examinedStarSystem in RebelScumGame.Galaxy.StarSystems)
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
                return newMission;
            }
            else
            {
                List<string> targetedPlanet = new List<string>();
                Mission newMission = new Mission(newID, name, type, scope, starSystem, targetedPlanet);
                return newMission;
            }


            
            
         

            //Possibly integrate all that stuff into the mission constructor method? ^^^^^^^
        }

        public static List<MissionTemplate> DeserializeMissionTemplateList()
        {
            using (FileStream allMissionsFileStream = File.OpenRead("missionTemplateList.xml"))
            {
                return (List<MissionTemplate>)missionTemplateSerializer.Deserialize(allMissionsFileStream);
            }
        }

        public static void SerializeMissionTemplateList()
        {
            File.Delete("missionTemplateList.xml");
            using (FileStream allMissionsFileStream = File.OpenWrite("missionTemplateList.xml"))
            {
                missionTemplateSerializer.Serialize(allMissionsFileStream, RebelScumGame.AllMissionTemplates);
            }
        }

        public static List<Mission> FetchLoadedMissions()
        {
            return RebelScumGame.ActiveMissions;
        }

        public static List<MissionTemplate> BuildPossibleMissionList(string type, string scope)
        {
            List<MissionTemplate> possibleMissonList = new List<MissionTemplate>();
            foreach (MissionTemplate candidateTemplate in RebelScumGame.AllMissionTemplates)
            {
                if ((candidateTemplate.Scope == scope) && (candidateTemplate.Type == type) && ((candidateTemplate.Alignment == "Rebellion") || (candidateTemplate.Alignment == "Neutral")))
                {
                    possibleMissonList.Add(candidateTemplate);
                }
            }
            return possibleMissonList;
        }
               
    }

}
