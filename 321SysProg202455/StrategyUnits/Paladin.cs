using System;

namespace StrategyUnits
{
    internal class Paladin : Knight
    {
        public Paladin(int health, string? name, int armor, int treat, int energy, int mindamage, int maxdamage)
            : base(health, name, armor, treat, energy, mindamage, maxdamage)
        {
            Shield = false;
        }

        public bool Shield { get; set; }

        public override int Health
        {
            get { return base.Health; }
            set
            {
                base.Health = value;
                if (value <= MaxHealth / 2 && !Shield)
                {
                    Shield = true;
                    Armor *= 2;
                    Console.WriteLine("Паладин активировал святой щит");
                }
                else if (value > MaxHealth / 2 && Shield)
                {
                    Armor /= 2;
                    Shield = false;
                    Console.WriteLine("Щит паладина пропал");
                }

            }

        }

        public override void Attack(Unit unit)
        {
            int damage = new Random().Next(MinDamage, MaxDamage);
            Console.WriteLine($"Палладин нанесн ударом святого меча {damage} урона Юниту: {unit.Name}");
            unit.TakeDamage(damage);
        }
    }
}
