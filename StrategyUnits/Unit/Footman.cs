using StrategyUnits.Interface;

namespace StrategyUnits.Unit
{
    internal class Footman : IHealthControl, IProtectedUnit, IBattleUnit
    {
        public Footman()
        {
            Name = "Footman";
            MaxHealth = 40;
            Health = 40;
            Armor = 1;
            MinDamage = 3;
            MaxDamage = 8;
            IsDead = false;
        }
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public string Name { get; set; }
        public bool IsDead { get; set; }

        public void Attack(IHealthControl unit)
        {
            if (IsDead) Console.WriteLine("И пусть у вас всё ещё протекают трупные спазмы, вряд ли вы сможете кого-то ударить.");
            else
            {
                if (unit.IsDead)
                    Console.WriteLine($"Юнит {unit.Name} уже умер.");
                else
                {
                    Random rnd = new Random();
                    int damage;
                    damage = rnd.Next(MinDamage, MaxDamage);
                    Console.WriteLine($"Юнит {Name} атакует юнита {unit.Name}");
                    unit.TakeDamage(damage);
                }
            }
        }

        public void TakeDamage(int damage)
        {
            damage -= Armor;          
            if (damage <= 0) Console.WriteLine($"{Name} получил удар без какого-либо урона");
            else Health -= damage;
            if (Health < 0)
            {
                Health = 0;
                Console.WriteLine($"Юнит {Name} умер.");
                IsDead = true;
            }
            else Console.WriteLine($"Юнит {Name} получил {damage + Armor} урона (Поглощено: {Armor}). Тек. здоровье: {Health}/{MaxHealth}");
        }

        public void TakeHeal(int heal)
        {
            Health += heal;
            if (Health > MaxHealth)
                Health = MaxHealth;
        }
    }
}
