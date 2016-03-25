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

        static RebelEngine()
        {
            MissionEngine = new MissionEngine();
            GalaxyEngine = new GalaxyEngine();
        }

        public static void Save()
        {
            MissionManager.SerializeActiveMissions();
        }
    }
}
