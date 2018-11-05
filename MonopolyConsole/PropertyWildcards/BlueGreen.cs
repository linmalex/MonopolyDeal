﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MonopolyConsole.Models;
using MonopolyConsole.PropertyCards;

namespace MonopolyConsole.PropertyWildcards
{
    class BlueGreen: PropertyCard
    {
        public BlueGreen()
        {
            Value = 4;
            Name = "Blue or Green Wild Card";
        }
    }
}
