﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGCC.Models.Assets
{
    public class Pain : IDamage
    {
        public string Name { get; set; }

        public int Value { get; set; }

    }
}