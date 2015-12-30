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

        private static XmlSerializer serializer = new XmlSerializer(typeof(List<Mission>));

        public static List<Mission> GetMissions() {

            List<Mission> missions;
            var missionFileStream = File.OpenRead("mission2.xml");
            missions = (List<Mission>)serializer.Deserialize(missionFileStream);
            missionFileStream.Dispose();
            return missions;
        }

        public static void SaveMissions(List<Mission> missions)
        {
            using (var missionFileStream = File.OpenWrite("mission.xml"))
            {
                serializer.Serialize(missionFileStream, missions);
            }
        }

        public static Mission createMission()
        {
            Mission newMission = new Mission();
            return newMission;
        }
    }
}
