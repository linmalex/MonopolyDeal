﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.Models;
using MonopolyConsole.PropertyCards;

namespace MonopolyConsole.PropertyWildcards
{
    class TotalWild: PropertyCard
    {
        public TotalWild()
        {
            Value = 0;
            Name = "Total Wild Card";
        }
    }
}
