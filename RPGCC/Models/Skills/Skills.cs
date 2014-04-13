using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGCC.Models
{
    public class Skill
    {
        public string Name { get; set; }
        public int Rank { get; set; }
        public List<string> Specializations { get; set; }


    }
}