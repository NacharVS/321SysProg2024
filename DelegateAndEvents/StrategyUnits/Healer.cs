using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : MagicUnit
    {
        public Healer(int health, string? name, double protection, double damage, int manna, int maxManna) : base(health, name, protection, damage, manna, maxManna)
        {
        }

        public void Healing(Unit unit)
        {
            if (Manna > 10)
            {
                unit.Health += 10;
                Manna -= 10;
            }
            else if (Manna > 0)
            {
                unit.Health += Manna;
                Manna = 0;
            }
            else
            {
                Console.WriteLine(this.Name + " low manna");
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name}\nЗдоровье: {Health}/{MaxHealth}\nМана: {Manna}/{MaxManna}");
        }

    }
}
