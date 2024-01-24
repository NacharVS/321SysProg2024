using System.Xml.Linq;
using StrategyUnits.Interface;
using static System.Net.Mime.MediaTypeNames;

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
            MinDamage = 5;
            MaxDamage = 15;
        }
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        public int Armor { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public string Name { get; set; }

        public void Attack(IHealthControl unit)
        {
            if (unit.Health == 0) 
                Console.WriteLine($"Юнит {unit.Name} уже умер.");
            else
            {
                Random rnd = new Random();
                int damage;
                damage = rnd.Next(MinDamage, MaxDamage) - Armor;
                Console.WriteLine($"Юнит {Name} атакует юнита {unit.Name}");
                if (damage <= 0) Console.WriteLine($"{unit.Name} получил удар без какого-либо урона");
                else
                    unit.TakeDamage(damage);
            }
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
            if (Health < 0)
            {
                Health = 0;
                Console.WriteLine($"Юнит {Name} умер.");
            }
            else Console.WriteLine($"Юнит {Name} получил {damage + Armor} урона (Поглощено: {Armor}). Тек. здоровье: {Health}/{MaxHealth}");
        }
    }
}
