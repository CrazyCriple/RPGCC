using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGCC.Models.Assets
{
    public class Acuity : IAsset
    {
        public string Name { get { return "acuity"; }}

        public int Value { get; set; }

    }
}