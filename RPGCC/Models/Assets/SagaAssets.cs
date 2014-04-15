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