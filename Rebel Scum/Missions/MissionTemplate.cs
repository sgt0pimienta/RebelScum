using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelScum.Missions
{
    [Serializable]
    public class MissionTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Scope { get; set; }
        public string MissionType { get; set; }
        public bool playerAccessible { get; set; }
    }
}
