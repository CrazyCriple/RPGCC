using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using RPGCC.Models.Assets;

namespace RPGCC.Models.Damage
{
    public class SagaDamages
    {
        [Display(Name = "Zweifel", GroupName = "Schaden")]
        public int Doubt { get; set; }

        [Display(Name = "Angst", GroupName = "Schaden")]
        public int Fear { get; set; }

        [Display(Name = "Schmärz", GroupName = "Schaden")]
        public int Pain { get; set; }

        [Display(Name = "Schicksal", GroupName = "Schaden")]
        public int Kismet { get; set; }
        
    }
}