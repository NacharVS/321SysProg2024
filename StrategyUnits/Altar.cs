using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar: Buildings
    {
        public Altar(): base(100, "Altar")
        {

        }

        public void AddHeal(Unit unit)
        {
            unit.Health = unit.MaxHealth;
        }
    }
}
