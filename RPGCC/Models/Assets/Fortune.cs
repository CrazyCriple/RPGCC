﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RPGCC.Models.Assets
{
    public class Fortune : IAsset
    {
        public string Name { get; set; }

        public int Value { get; set; }

    }
}