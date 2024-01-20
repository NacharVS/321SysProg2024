using System;

namespace StrategyUnits
{
    internal class Knight : MagicUnit
    {
        public Knight(int health, string? name, int armor, int treat, int energy, int mindamage, int maxdamage) 
            : base(health, name, armor, treat, energy, mindamage, maxdamage)
        {
        }

        public override void Attack(Unit unit)
        {
            int damage = new Random().Next(MinDamage, MaxDamage);
            Console.WriteLine($"Рыцарь нанесн ударом меча {damage} урона Юниту: {unit.Name}");
            unit.TakeDamage(damage);
        }
        public void SelfHeal()
        {
            if (Health == 0)
                return;

            if (MaxHealth - Health > HealStrange)
            {
                if (Mana < HealStrange && Mana != 0)
                {
                    Health += Mana;
                    Mana = 0;
                }
                else if (Mana > HealStrange)
                {
                    Health += HealStrange;
                    Mana -= HealStrange;
                }
            }
            else
            {
                if (Mana < MaxHealth - Health && Mana != 0)
                {
                    Health += Mana;
                    Mana = 0;
                }
                else if (Mana > MaxHealth - Health)
                {
                    Mana -= MaxHealth - Health;
                    Health += MaxHealth;
                }
            }
        }
    }
}
