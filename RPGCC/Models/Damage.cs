using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGCC.Models
{
    public class Damage
    {
            public readonly string Name { get; set; }
            public int Value { get; set; }


            public Damage(string name)
            {
                Name = name;
            }

        }
    }
}