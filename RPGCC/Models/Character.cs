using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using RPGCC.Models.Assets;

namespace RPGCC.Models
{
    public class Character
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public string Concept { get; set; }
        public string Description { get; set; }
        public int Spark { get; set; }
        public int DoomActual { get; set; }
        public List<String> Traits { get; set; }
        public List<String> Consequences { get; set; }
        public List<String> Gear { get; set; }
        public List<String> Perks { get; set; }
        public List<Skill> Skills { get; set; }
        public List<IAsset> Assets { get; set; }
        public List<IDamage> Damages { get; set; }

        public Character(string name)
        {
            Name = name;
            FillAssets();
            FillDamage();
            FillSkills();
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

