using StrategyUnitsSemenov;
using System;

namespace StrategyUnitsSemenov
{
    internal class Footman : Unit, IMilitary
    {
        public int Damage { get; set; }

        public Footman() : base(60, "Footman")
        {
            Damage = 7;
        }

        public void InflictDamage(Unit unit)
        {
            if (unit.Health > 0)
            {
                if (unit.Health <= Damage)
                {
                    Console.WriteLine($"Footman attacked {unit.Name} and dealt {unit.Health} damage. {unit.Name} has been defeated.");
                    unit.Health = 0;
                }
                else
                {
                    Console.WriteLine($"Footman attacked {unit.Name} and dealt {Damage} damage.");
                    unit.Health -= Damage;
                }
            }
            else
            {
                Console.WriteLine($"{unit.Name} is already defeated. No damage dealt.");
            }
        }
    }
}


