﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGCC.Models.Assets
{
    public class Kismet : IDamage
    {
        public string Name { get { return "kismet"; }}

        public int Value { get; set; }

    }
}