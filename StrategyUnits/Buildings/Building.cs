using StrategyUnits.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Buildings
{
    internal class Building: Unit
    {
        public Building(int health, string? name, int armor) : base(health, name, armor) { }
    }
}
