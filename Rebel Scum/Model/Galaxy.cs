using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelScum.Model
{
    [Serializable]
    public class Galaxy
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<StarSystem> StarSystems;

        public override string ToString()
        {
            return Name;
        }

        public Galaxy()
        {
            StarSystems = new List<StarSystem>();
        }
    }
}
