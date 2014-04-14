using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RPGCC.Models.Skills
{
    [Table("sagaSkills")]
    public class SagaSkills
    {
        [Key]
        public int Id { get; set;}
        public List<Skill> Skills { get; set; }

        //todo: load from db
        public SagaSkills()
        {
            //todo: only until db
            Id = 1;
            Skills = new List<Skill>();

            Skills.Add(new Skill {Name = "Academia"});
            Skills.Add(new Skill {Name = "Awareness"});
            Skills.Add(new Skill {Name = "Athletics"});
            Skills.Add(new Skill {Name = "Influence"});
            Skills.Add(new Skill {Name = "Legerdemain"});
            Skills.Add(new Skill {Name = "Subterfuge"});
            Skills.Add(new Skill {Name = "Marksmanship"});
            Skills.Add(new Skill {Name = "Weaponry"});
        }

    }
}