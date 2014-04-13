using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGCC.Models
{
    public class Asset
    {
        public readonly string Name { get; set; }
        public int Value { get; set; }


        public Asset (string name)
        {
            Name = name;
        }

    }
}