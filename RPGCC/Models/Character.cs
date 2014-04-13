using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RPGCC.Models.Assets;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RPGCC.Models
{
    [Table("character")]
    public class Character
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }

        [Display(Name = "Geschlecht")]
        public Gender Gender { get; set; }

        [Display(Name = "Alter")]
        public int Age { get; set; }

        [Display(Name = "Charakter Konzept")]
        public string Concept { get; set; }

        [Display(Name = "Beschreibung")]
        public string Description { get; set; }

        public int Spark { get; set; }

        public int DoomActual { get; set; }

        [Display(Name = "Eigenschaften")]
        public List<String> Traits { get; set; }

        [Display(Name = "Konsequenzen")]
        public List<String> Consequences { get; set; }

        [Display(Name = "Ausrüstung")]
        public List<String> Gear { get; set; }

        [Display(Name = "Extras")]
        public List<String> Perks { get; set; }

        [Display(Name = "Fähigkeiten")]
        public List<Skill> Skills { get; set; }

        public List<IAsset> Assets { get; set; }
        public List<IDamage> Damages { get; set; }

        [Display(Name = "Ist spielbar")]
        public bool IsNPC { get; set; }

        public Character(string name)
        {
            Name = name;
            FillAssets();
            FillDamage();
            FillSkills();
        }
        public int GetMaxDoom()
        {
            return Assets.Find(x => x.Name == "fortune").Value * 2;
        }

        private void FillAssets()
        {
            Assets = new List<IAsset>();
            Assets.Add(new Acuity());
            Assets.Add(new Force());
            Assets.Add(new Fortune());
            Assets.Add(new Grace());
           
        }

        private void FillDamage()
        {
            Damages = new List<IDamage>();
            Damages.Add(new Doubt());
            Damages.Add(new Fear());
            Damages.Add(new Kismet());
            Damages.Add(new Pain());
        }

        private void FillSkills()
        {
            Skills = new List<Skill>();
            Skills.Add(new Skill { Name = "Academia" });
            Skills.Add(new Skill { Name = "Awareness" });
            Skills.Add(new Skill { Name = "Athletics" });
            Skills.Add(new Skill { Name = "Influence" });
            Skills.Add(new Skill { Name = "Legerdemain" });
            Skills.Add(new Skill { Name = "Subterfuge" });
            Skills.Add(new Skill { Name = "Marksmanship" });
            Skills.Add(new Skill { Name = "Weaponry" });
        }
        private void FillCustomSkill(Skill skill)
        {
            Skills.Add(skill);
        }

    }
    public enum Gender
    {
        Male, Female, Unknown
    }


}

