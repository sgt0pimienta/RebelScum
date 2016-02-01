using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

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

        public static Mission CreateMission(string name, string type, string scope)
        {
            Mission newMission = new Mission(name, type, scope);
            newMission.Id = (RebelScumGame.CreatedMissionCount + 1);
            RebelScumGame.CreatedMissionCount += 1;
            return newMission;

            //Possibly integrate all that stuff into the mission initializer? ^^^^^^^
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
