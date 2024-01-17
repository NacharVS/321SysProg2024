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

        public Healer() : base("Мэджик Хилер", 15, 1, 10, 25, 100)
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Юнит: {Name} | Здоровье: {Health}/{MaxHealth} | Броня: {Defense} | Мана: {Mana}/{MaxMana}");
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
                Console.WriteLine($"{Name} хилит {healedUnit.Name.ToLower()}а по 1 хп и тратит 2 маны (осталось {Mana}/{MaxMana})");
                healedUnit.Health++;
            }

        }
    }
}
