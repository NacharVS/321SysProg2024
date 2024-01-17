using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : militaryUnits
    {
        public Berserker() : base(100, "Berserker", 10, 10, 15)
        {
        }
    }
}
