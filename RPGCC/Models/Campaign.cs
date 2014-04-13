using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGCC.Models
{
    public class Campaign
    {
        public string Description;
        public List<Character> Players;
        public List<Account> GMs;

    }
}