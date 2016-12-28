using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RebelScum.Model
{
    [Serializable]
    public class Mission
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public MissionTemplate MissionTemplate { get; set; }
        public string Scope { get; set; }
        public string Type { get; set; }
        public string Target { get; set; }
        public int BaseSuccessChance { get; set; }
        public bool CanBackfire { get; set; }

        //DO NOT DELETE THIS SEEMINGLY USELESS CONSTRUCTOR METHOD *Parameterless constructor needed for serialization* (Seriously, trust me, do NOT delete this)... (IM SERIOUS)
        //Fine, delete it if you must
        //Don't say I didn't warn you
        public Mission()
        {

        }

        public Mission(int id, string name, string type, string scope, string target)
        { 
            Id = id;
            Name = name;
            Type = type;
            Scope = scope;
            Target = target;


        }

    }
}
