using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RebelScum.Services;


namespace RebelScum.Engine
{

    public static class RebelEngine
    {
        public static MissionEngine MissionEngine { get; set; }
        public static GalaxyEngine GalaxyEngine { get; set; }
        public static CalendarEngine CalendarEngine { get; set; }
        public static GameState GameState { get; set; }

        static RebelEngine()
        {
            MissionEngine = new MissionEngine();
            GalaxyEngine = new GalaxyEngine();
            GameState = new GameState();
        }

        public static void Save()
        {
            GameStateManager.SerializeGameState();
        }

        public static void Load()
        {
            GameState = GameStateManager.DeserializeGameState(false);
            // USED TO CREATE A NEW BASE SAVE THAT IS EMPTY FOR NEW GAME GENERATION: GameStateManager.GenerateBaseSave();
        }

        public static void NewGame()
        {
            GameState = GameStateManager.DeserializeGameState(true);
            GameState.Galaxy = GalaxyEngine.CreateGalaxy();
        }
    }
}
