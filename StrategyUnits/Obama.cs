﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Obama
    {
        public Footman CreateFootman()
        {
            return new Footman(40,"Footman", 60, 31);
        }
        public Berserk CreateBerserk()
        {
            return new Berserk(60, "Gats", 80, 0);
        }
    }
}
