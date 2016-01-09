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

        public static List<Mission> GetActiveMissions()
        {
            using (var missionFileStream = File.OpenRead("mission.xml"))
            {
                return (List<Mission>)activeMissionSerializer.Deserialize(missionFileStream);
            }
        }

        public static void SaveActiveMissions()
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

        public static List<MissionTemplate> ReadAllMissionsList()
        {
            using (FileStream allMissionsFileStream = File.OpenRead("missionList.xml"))
            {
                return (List<MissionTemplate>)missionTemplateSerializer.Deserialize(allMissionsFileStream);
            }
        }

        public static void WriteAllMissionsList()
        {
            File.Delete("missionList.xml");
            using (FileStream allMissionsFileStream = File.OpenWrite("missionList.xml"))
            {
                missionTemplateSerializer.Serialize(allMissionsFileStream, RebelScumGame.AllMissionTemplates);
            }
        }
               
    }

}
