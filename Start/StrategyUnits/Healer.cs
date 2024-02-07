using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : MagicUnit
    {
        public Healer() : base(20, 40, "Healer", 0, 0) { }

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
    }
}
