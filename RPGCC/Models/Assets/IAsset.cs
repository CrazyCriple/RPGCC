using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RPGCC.Models.Enums;

namespace RPGCC.Models
{
    public interface IAsset
    {
        public string Name { get; set; }

        public int Value { get; set; }


    }
}