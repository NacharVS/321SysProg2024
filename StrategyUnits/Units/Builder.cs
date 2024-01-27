using StrategyUnits.Buildings;
using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Builder : Unit, IRepairBuilding
    {
        public Builder(string name, int health) : base(name, health)
        {
        }

        public void Repair(IBuildingHealth building)
        {
            Console.WriteLine($"{Name} быстро запилил дверь +100");
            building.TakeRepair();
        }
    }
}
