using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RPGCC.Models.Wizard
{
    public class BasicDetails
    {
        [Required]
        [Key]
        public string CharakterName { get; set; }

        [Required]
        [Display(Name = "Geschlecht", Prompt = "Wähle das Geschlecht deines Charakters")]
        public Gender Gender { get; set; }

        [Required]
        [Display(Name = "Alter")]
        public int Age { get; set; }

        [Display(Name = "Charakter Konzept")]
        public string Concept { get; set; }

        [Display(Name = "Beschreibung")]
        public string Description { get; set; }


    }
}