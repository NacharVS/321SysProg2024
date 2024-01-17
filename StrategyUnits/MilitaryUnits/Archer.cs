using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.MilitaryUnits
{
    internal class Archer : MilitaryUnit
    {
        public Archer(string name) : base(name, 20, 3, 5, 15)
        {

        }
    }
}
