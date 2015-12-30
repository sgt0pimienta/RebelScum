using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelScum.Missions
{
        [Serializable]
        public enum MissionType
        {
            Diplomatic = 1,
            Military,
            Intelligence,
            Sabotage,
            Economic,
            Population
        }

        [Serializable]
        public enum MissionScope
        {
            Planet = 1,
            System,
            Galaxy
        }   
}
