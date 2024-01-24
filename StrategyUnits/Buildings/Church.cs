using StrategyUnits.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Buildings
{
    internal class Church: Building
    {
        public Church() : base(500, "Church", 0) { }

        public void ManaCharging(MagicUnit unit)
        {
            unit.Mana = unit.MaxMana;
        }
    }
}
