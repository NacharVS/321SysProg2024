using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Stats
{
    internal interface IMana
    {
        public int Mana { get; set; }
        public int MaxMana { get; set; }

        public void GiveMana(int mana);
    }
}
