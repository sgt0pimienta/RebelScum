﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RebelScum.Model
{
    [Serializable]
    public class MissionTemplate
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Scope { get; set; }
        public string Alignment { get; set; }
        public string Type { get; set; }
        public int BaseSuccessChance { get; set; }
    }
}
