using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class PeacefulUnit : Unit
    {
        public PeacefulUnit(string name, int health) : base(name, health)
        {

        }
    }
}
