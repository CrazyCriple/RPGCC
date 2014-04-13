using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGCC.Models.Assets
{
    public class Force : IAsset
    {
        public string Name { get { return "force"; } }

        public int Value { get; set; }

    }
}