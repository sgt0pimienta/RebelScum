using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelScum.Classes
{
    [Serializable]
    public class StarSystem
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Planet> Planets { get; set; }
        public string Status { get; set; }
    }
}
