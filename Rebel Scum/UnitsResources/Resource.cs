using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelScum.UnitsResources
{
    [Serializable]
    public class Resource
    {
        public string Name { get; set; }
        public int Quantity { get; set; }
        public int Availability { get; set; }
        public string Owner { get; set; }

        public Resource() { }

        public override string ToString()
        {
            return string.Format("{0}: {1}", Name, Quantity);
        }

        public Resource(string name, int quantity, int availability = 0)
        {
            this.Name = name;
            this.Quantity = quantity;
            this.Availability = availability;
        }
    }
}
