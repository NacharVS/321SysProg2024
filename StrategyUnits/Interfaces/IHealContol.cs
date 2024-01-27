﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IHealContol
    {
        public int Mana { get; set; }

        public void Heal(IHealingControl unit);
    }
}
