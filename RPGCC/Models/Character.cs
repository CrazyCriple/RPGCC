using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGCC.Models
{
    public class Character
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public string Concept { get; set; }
        public string Description { get; set; }
        public int Spark { get; set; }
        public int DoomActual { get; set; }
        public List<String> Traits;
        public List<String> Consequences;
        public List<String> Gear;
        public List<String> Perks;
        public List<Skill> Skills;


    }
    public enum Gender
    {
        Male, Female, Unknown
    }


}

