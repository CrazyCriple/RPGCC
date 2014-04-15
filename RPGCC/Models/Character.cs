using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RPGCC.Models.Assets;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using RPGCC.Models.Damage;
using RPGCC.Models.Skills;

namespace RPGCC.Models
{
    [Table("character")]
    public class Character
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Geschlecht", Prompt = "Wähle das Geschlecht deines Charakters")]
        public Gender Gender { get; set; }

        [Display(Name = "Alter")]
        public int Age { get; set; }

        [Display(Name = "Charakter Konzept")]
        public string Concept { get; set; }

        [Display(Name = "Beschreibung")]
        public string Description { get; set; }

        public int Spark { get; set; }

        [Display(Name = "Momentaner Doom (0 beim start)")]
        public int DoomActual { get; set; }

        [Display(Name = "Merkmale")]
        public List<String> Traits { get; set; }

        [Display(Name = "Konsequenzen")]
        public List<String> Consequences { get; set; }

        [Display(Name = "Ausrüstung")]
        public List<String> Gear { get; set; }

        [Display(Name = "Extras")]
        public List<String> Perks { get; set; }

        [Display(Name = "Fähigkeiten", Description = "Das kann dein Charakter")]
        public SagaSkills SagaSkills { get; set; }

        [Display(Name = "Assets")]
        public SagaAssets Assets { get; set; }

        [Display(Name = "Schaden")]
        public SagaDamages Damages { get; set; }

        [Display(Name = "Ist spielbar")]
        public bool IsNPC { get; set; }

        public Character(string name)
        {
            Name = name;
            Assets = new SagaAssets();
            Damages = new SagaDamages();
            SagaSkills = new SagaSkills();

        }
        public int GetMaxDoom()
        {
            return Assets.Fortune*2;
        }
        
        private void FillCustomSkill(Skill skill)
        {
            SagaSkills.Skills.Add(skill);
        }

    }
    public enum Gender
    {
        Male, Female, Unknown
    }


}

