using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.MilitaryUnits.MagicUnits
{
    internal class Healer : MagicUnit
    {
        private int _heal;

        public int Heal
        {
            get { return _heal; }
            set { _heal = value; }
        }

        public Healer(string name, int health, int defense, int minDamage, int maxDamage, int mana) : base(name, health, defense, minDamage, maxDamage, mana)
        {

        }

        public void InflictHeal(Unit healedUnit)
        {
            if (healedUnit.Health <= 0)
            {
                Console.WriteLine("Челик сдох");
                return;
            }

            while (healedUnit.Health < healedUnit.MaxHealth)
            {
                if (Mana == 0)
                {
                    Console.WriteLine("Мана закончилась");
                    return;
                }
                Mana -= 2;
                Console.WriteLine($"{Name} хилит {healedUnit.Name.ToLower()} по 1 хп и тратит 2 маны (осталось {Mana}/{MaxMana})");
                healedUnit.Health++;
            }

        }
    }
}
