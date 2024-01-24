using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bersercer : Footman
    {
        public Bersercer(string name, int health, int defense, int minDamage, int maxDamage)
            : base(name, health, defense, minDamage, maxDamage)
        {
        }
        public override void Attack(Unit unit)
        {
            if (Health < MaxHealth / 2)
            {              
                Console.WriteLine($"у {this.Name} здоровье {this.Health}/{this.MaxHealth} (здоровье меньше 50% = урон * 2)");
                Random random = new Random();

                int a_damage = random.Next(MinDamage, MaxDamage);
                a_damage *= 2;
                int aa_damage = a_damage - unit.Defense;

                unit.Defense = unit.Defense - a_damage;
                unit.TakeDamage(aa_damage);

                Console.WriteLine($"{unit.Name} получил {a_damage} урона от {this.Name}." +
                    $" Здоровье: {unit.Health}/{unit.MaxHealth}. Защита: {unit.Defense}/{unit.MaxDefense}");
            }
            if (unit.Health <= 0) Console.WriteLine($"{this.Name} убил {unit.Name}");
        }
    }
}