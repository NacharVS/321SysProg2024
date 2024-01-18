using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Footman
    {
        public Berserker(int health, string? name, int defence, int min_damage, int max_damage) : base(health, name, defence, min_damage, max_damage)
        {
        }
    }
}
