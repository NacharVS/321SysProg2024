using System;

namespace StrategyUnits
{
    internal class Archer : MilitaryUnit
    {

        public Archer() : base(60, "Footman", 0, 12, 20)
        {

        }

        public override void Attack(Unit unit)
        {
            int damage = new Random().Next(MinDamage, MaxDamage);
            Console.WriteLine($"Лучник выстрелил из лука и нанес стрелой {damage} урона Юниту: {unit.Name}");
            unit.TakeDamage(damage);
        }
    }
}
