using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : MagicUnit
    {
        public Healer() : base(80, "Bykov", 60, 3)
        {
            Heal = 5;
            Damage = 1;
        }
    }
}
