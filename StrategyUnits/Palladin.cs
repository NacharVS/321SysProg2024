using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {
        public Palladin() : base(40, "Palladin", 5, 3, 7, 30)
        {

        }

        public void InflictSupport(Unit unit)
        {
            if (Mana > 5)
            {
                unit.Armor++;
                Mana -= 5;
                Console.WriteLine($"Юниту {unit.Name} была увеличена броня");
            }
            else Console.WriteLine("Маны не хватает");
        }
    }
}
