using StrategyUnitsSemenov;
using System;

namespace StrategyUnitsSemenov
{
    internal class Archer : Unit, IMilitary
    {
        public int Damage { get; set; }

        public Archer() : base(50, "Archer")
        {
            Damage = 10;
        }

        public void Shoot(Unit unit)
        {
            if (unit.Health > 0)
            {
                if (unit.Health <= Damage)
                {
                    Console.WriteLine($"Archer shot {unit.Name} and dealt {unit.Health} damage. {unit.Name} has been defeated.");
                    unit.Health = 0;
                }
                else
                {
                    Console.WriteLine($"Archer shot {unit.Name} and dealt {Damage} damage.");
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
