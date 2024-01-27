using StrategyUnits.Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units.WeaponUnit.AttackingUnit
{
    internal class Archer : Unit, IHealth
    {
        public Archer() : base(70, "Лучник")
        {
            Health = 70;
            MaxHealth = Health;
            Name = "Лучник";
        }
    }
}
