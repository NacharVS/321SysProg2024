using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyUnits.Type;

namespace StrategyUnits.Human
{
    internal class Archer : militaryUnits
    {
        public Archer() : base(60, "Archer", 1, 3, 5)
        {
        }
    }
}
