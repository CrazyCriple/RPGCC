using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGCC.Models
{
    public class Saga : IGameSystem
    {

        public List<Perk> PlayerPerks { get; set; }
        public List<Asset> PlayerAssets { get; set; }




    }
}