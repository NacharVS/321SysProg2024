using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker: Footman
    {


        public Berserker(int health, string? name, int defense, int minDamage, int maxDamage) : base(health, name, defense, minDamage, maxDamage)
        {
            
        }


    }
}
