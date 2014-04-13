using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGCC.Models.Assets
{
    public class Doubt : IDamage
    {
        public string Name { get{return "doubt"; }}

        public int Value { get; set; }

    }
}