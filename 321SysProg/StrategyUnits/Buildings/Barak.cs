using StrategyUnits.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Buildings
{
    internal class Barak : Building
    {
        public Barak() : base(30, "Barak", 0)
        {
        }

        public Knight GetPalladin()
        {
            return new Palladin(100, "Palladin", 10, 7, 12, 100);
        }
        public Footman GetFootman()
        {
            return new Footman(50, "Footman", 2, 5, 10);
        }
        public Footman GetBerserk()
        {
            return new Berserk(30, "Berserk", 2, 10, 15);
        }

    }
}
