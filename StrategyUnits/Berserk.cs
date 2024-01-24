using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserk : Footman
    {
        public Berserk(int health, string? name, int armor, int minDamage, int maxDamage) : base(health, name, armor, minDamage, maxDamage)
        {

        }
    }
}
