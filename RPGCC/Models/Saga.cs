using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Resources;
using System.Reflection;
namespace RPGCC.Models


{
    public class Saga : IGameSystem
    {

        public List<Perk> PlayerPerks { get; set; }
        private List<Asset> PlayerAssets { get; set; }



        public List<Asset> GetAssets()
        {
            ResourceManager rm = new ResourceManager("Saga-DE", Assembly.GetExecutingAssembly());


            //todo: load save from file
            var fortune = new Asset(rm.GetString("Fortune"));
            var grace = new Asset(rm.GetString("Grace"));
            var acuity = new Asset(rm.GetString("Acuity"));
            var force = new Asset(rm.GetString("Force"));
            
            PlayerAssets.Add(fortune);
            PlayerAssets.Add(grace);
            PlayerAssets.Add(acuity);
            PlayerAssets.Add(force);

            return PlayerAssets;

        }




    }
}