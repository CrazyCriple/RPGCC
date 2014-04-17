using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RPGCC.Models.Skills
{
    [Table("sagaSkills")]
    public class SagaSkills
    {
        [Key]
        public int Id { get; set;}
        public List<Skill> Skills { get; set; }

        public List<SelectListItem> List { get; set; }

        public List<string> Primary { get; set; }
 

        //todo: load from db
        public SagaSkills()
        {
            //todo: only until db
            Id = 1;
            List = new List<SelectListItem>();

            List.Add(new SelectListItem { Text = "Akademie" });
            List.Add(new SelectListItem { Text = "Aufmerksamkeit" });
            List.Add(new SelectListItem { Text = "Athletik" });
            List.Add(new SelectListItem { Text = "Einfluss" });
            List.Add(new SelectListItem { Text = "Schwindel" });
            List.Add(new SelectListItem { Text = "List" });
            List.Add(new SelectListItem { Text = "Treffsicherheit" });
            List.Add(new SelectListItem { Text = "Waffenkunst" });

            Skills = new List<Skill>();

            foreach (var selectListItem in List)
            {
                Skills.Add(new Skill{Name = selectListItem.Text});
            }

        }

    }
}