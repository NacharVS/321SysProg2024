using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.MilitaryUnits.MagicUnits
{
    internal class Palladin : Knight
    {
        private int _defense;

        public Palladin(string name, int health, int defense, int minDamage, int maxDamage, int mana)
            : base(name, health, defense, minDamage, maxDamage, mana)
        {
            _defense = defense;
        }

        public override int Defense
        {
            get
            {
                if (Health < MaxHealth * 0.5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("*'Броня не пробита' активатион*");
                    Console.ResetColor();

                    return _defense * 2;
                }
                else
                {
                    return _defense;
                }
            }
        }

        public void SelfHeal()
        {
            if (Health <= 0)
            {
                Console.WriteLine("Я сдох");
                return;
            }

            while (Health < MaxHealth * 0.5)
            {
                if (Mana == 0)
                {
                    Console.WriteLine("Мана закончилась");
                    return;
                }
                Mana -= 2;
                Console.WriteLine($"{Name} хилит себя по 1 хп и тратит 2 маны (осталось {Mana}/{MaxMana})");
                Health++;
            }
        }
    }
}
