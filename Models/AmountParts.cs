﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Repairshop.Models
{
    public class AmountParts
    {
        public int Id { get; set; }
        public part part { get; set; }
        public int Amount { get; set; }
    }
}