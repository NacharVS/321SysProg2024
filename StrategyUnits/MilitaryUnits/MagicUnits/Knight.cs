using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.MilitaryUnits.MagicUnits
{
    internal class Knight : MagicUnit
    {
        public Knight(string name, int health, int defense, int minDamage, int maxDamage, int mana) 
            : base(name, health, defense, minDamage, maxDamage, mana)
        {
        }
    }
}
