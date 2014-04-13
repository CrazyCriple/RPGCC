using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace RPGCC.Models
{
    [Table("skill")]
    public class Skill
    {
        [Key]
        public string Name { get; set; }

        public int Rank { get; set; }
        public List<string> Specializations { get; set; }


    }
}