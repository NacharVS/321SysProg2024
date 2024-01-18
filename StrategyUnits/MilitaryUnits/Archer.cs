using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.MilitaryUnits
{
    internal class Archer : MilitaryUnit
    {
        public Archer(string name, int health, int defense, int minDamage, int maxDamage) : base(name, health, defense, minDamage, maxDamage)
        {
        }
    }
}
