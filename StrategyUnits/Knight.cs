using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Knight
        : MagicUnit
    {
        public Knight(string name, int health, int defense, int minDamage, int maxDamage, int maxmanna) : base(name, health, defense, minDamage, maxDamage, maxmanna)
        {
        }
        public void SelfHeal()
        {
            if (Health <= 0)
            {
                Console.WriteLine($"{Name} погиб");
            }

            while (Health < MaxHealth * 0.5)
            {
                if (MUManna < 2)
                {
                    Console.WriteLine("Манна закончилась");
                    break; 
                }
                else
                {
                    MUManna -= 2;
                    Console.WriteLine($"{Name} восстановил 1 здоровье за 2 манны. Всего здоровья: {Health}/{MaxHealth}. Всего манны: {MUManna}/{MUMaxManna}");
                    Health += 1;
                }
            }
        }


    }
}
