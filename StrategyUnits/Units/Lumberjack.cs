using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Lumberjack : HostileUnit
    {
        public Lumberjack(string name, int health, int damage) : base(name, health, damage)
        {
        }

        public override void Attack(IHealthControl unit)
        {
            if (Health > 0 && Health < MaxHealth * 0.5)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("*Чипикос Шикитос Двойнос Уронос Активанос*");
                Console.WriteLine($"{Name} атаковал с уроном {Damage * 2} (x2)");
                unit.TakeDamage(Damage * 2);
                Console.ResetColor();
            }
            else if (Health > 0)
            {
                Console.WriteLine($"{Name} атаковал с уроном {Damage}");
                unit.TakeDamage(Damage);
            }
            else
            {
                Console.WriteLine("Я как бы мертв для атаки\n");
            }
        }
    }
}
