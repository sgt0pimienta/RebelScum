using RebelScum.Classes;
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
                activeMissionSerializer.Serialize(missionFileStream, RebelScumGame.activeMissions);
            }
        }

        public static Mission createMission(string name, string type, string scope)
        {
            Mission newMission = new Mission();
            newMission.Name = name;
            newMission.MissionType = type;
            newMission.MissionScope = scope;
            newMission.Id = (RebelScumGame.activeMissionCount + 1);
            RebelScumGame.activeMissionCount += 1;
            return newMission;
        }

        public static List<MissionTemplate> readAllMissionsList()
        {
            using (FileStream allMissionsFileStream = File.OpenRead("missionList.xml"))
            {
                return (List<MissionTemplate>)missionTemplateSerializer.Deserialize(allMissionsFileStream);
            }
        }
    }
}
