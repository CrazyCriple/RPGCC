using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGCC.Models.Assets
{
    public class Fear : IDamage
    {
        public string Name { get { return "fear"; }}

        public int Value { get; set; }

    }
}