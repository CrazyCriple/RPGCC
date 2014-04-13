using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGCC.Models.Assets
{
    public class Grace : IAsset
    {
        public string Name { get { return "grace"; }}

        public int Value { get; set; }

    }
}