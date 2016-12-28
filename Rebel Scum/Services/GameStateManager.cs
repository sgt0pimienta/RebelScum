using RebelScum.Engine;
using RebelScum.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RebelScum.Services
{
    public static class GameStateManager
    {
        public static XmlSerializer GameStateSerializer = new XmlSerializer(typeof(GameState));

        //ONE USE ONLY FOR LOADING SERIALIZED DATA INTO BASE SAVE GAME FOR FIRST USE
        public static XmlSerializer NameSerializer = new XmlSerializer(typeof(string));
        public static XmlSerializer missionTemplateSerializer = new XmlSerializer(typeof(List<MissionTemplate>));

        public static void GenerateBaseSave()
        {
            using (FileStream allMissionsFileStream = File.OpenRead("missionTemplateList.xml"))
            {
                RebelEngine.GameState.AllMissionTemplates = (List<MissionTemplate>)missionTemplateSerializer.Deserialize(allMissionsFileStream);
            }

            using (FileStream NameFileStream = File.OpenRead("PlanetNames.txt"))
            {
                RebelEngine.GameState.PlanetNames = new List<string>(File.ReadAllLines("PlanetNames.txt"));
            }


            using (FileStream NameFileStream = File.OpenRead("SystemNames.txt"))
            {
                RebelEngine.GameState.StarSystemNames = new List<string>(File.ReadAllLines("SystemNames.txt"));
            }
        }
        //ONE USE ONLY FOR LOADING SERIALIZED DATA INTO BASE SAVE GAME FOR FIRST USE

        public static void SerializeGameState()
        {
            File.Delete("SavedGame.xml");
            using (var galaxyFileStream = File.OpenWrite("SavedGame.xml"))
            {
            GameStateSerializer.Serialize(galaxyFileStream, RebelEngine.GameState);
            }
        }

        public static GameState DeserializeGameState(bool newGame)
        {
            if (newGame == true)
            {
                using (var galaxyFileStream = File.OpenRead("BaseSavedGame.xml"))
                {
                    return (GameState)GameStateSerializer.Deserialize(galaxyFileStream);
                }
            }
            else
            {
                using (var galaxyFileStream = File.OpenRead("SavedGame.xml"))
                {
                    return (GameState)GameStateSerializer.Deserialize(galaxyFileStream);
                }
            }
        }


    }
}
