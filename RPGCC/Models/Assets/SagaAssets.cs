using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RPGCC.Models.Assets
{
    public class SagaAssets
    {
        [Key]
        public string Primary { get; set; }

        public string Secondary { get; set; }

        public List<KeyValuePair<string,int>> Assets { get; set; }

        public List<string> AssetNames { get; set; }


        public SagaAssets()
        {
            AssetNames = new List<string>();
            AssetNames.Add("Kraft");
            AssetNames.Add("Schärfe");
            AssetNames.Add("Raffinesse");
            AssetNames.Add("Glück");


            Assets =new List<KeyValuePair<string, int>>();

            //initialize all assets
            
        }
            
        [Display(Name = "Schärfe", GroupName = "Assets")]
        public int Acuity { get; set;}

        [Display(Name = "Kraft", GroupName = "Assets")]
        public int Force { get; set; }

        [Display(Name = "Glück", GroupName = "Assets")]
        public int Fortune { get; set; }

        [Display(Name = "Raffinesse", GroupName = "Assets")]
        public int Grace { get; set; }
        
    }
}