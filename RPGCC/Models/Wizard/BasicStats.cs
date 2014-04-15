using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using RPGCC.Models.Assets;
using RPGCC.Models.Skills;

namespace RPGCC.Models.Wizard
{
    public class BasicStats
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Assets")]
        public SagaAssets Assets { get; set; }

        [Display(Name = "Merkmale")]
        public List<String> Traits { get; set; }

        [Display(Name = "Fähigkeiten", Description = "Das kann dein Charakter")]
        public SagaSkills SagaSkills { get; set; }

    }
}