using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using RebelScum.Model;
using RebelScum.Engine;

namespace RebelScum.Services
{
    public static class MissionManager
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
                activeMissionSerializer.Serialize(missionFileStream, GameState.ActiveMissions);
            }
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
                missionTemplateSerializer.Serialize(allMissionsFileStream, GameState.AllMissionTemplates);
            }
        }
               
    }

}
