﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.Models;
using MonopolyConsole.PropertyCards;

namespace MonopolyConsole.PropertyWildcards
{
    class RailroadUtility: PropertyCard
    {
        public RailroadUtility()
        {
            Value = 2;
            Name = "Railroad or Utility Wild Card";
        }
    }
}
