using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin: Knight
    {


        public Paladin(int health, string? name, int defense,int energy, int minDamage, int maxDamage) : base(health, name, defense, energy, minDamage, maxDamage)
        {

        }

    }
}
