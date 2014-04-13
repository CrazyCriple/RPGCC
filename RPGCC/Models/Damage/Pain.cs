using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGCC.Models.Assets
{
    public class Pain : IDamage
    {
        public string Name { get { return "pain"; }}

        public int Value { get; set; }

    }
}