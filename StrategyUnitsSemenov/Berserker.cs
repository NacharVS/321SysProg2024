using StrategyUnitsSemenov;
using System;

namespace StrategyUnitsSemenov
{
    internal class Berserker : Unit, IMilitary
    {
        public int Damage { get; set; }

        public Berserker() : base(70, "Berserker")
        {
            Damage = 15;
        }

        public void Attack(IMilitary target)
        {
            if (target != null)
            {
                Console.WriteLine($"Berserker attacked {target.GetType().Name} and dealt {Damage} damage.");
                target.Damage = Damage;
            }
            else
            {
                Console.WriteLine("Invalid target. No damage dealt.");
            }
        }
    }
}
