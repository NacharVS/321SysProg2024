using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interface
{
    internal interface IHealerUnit
    {
        const int minHeal = 1;

        public int Heal { get; set; }

        public int ManaReserve { get; set; }

        public void Healing(IHealthControll unit);

        public void TakeMana(int mana);
    }
}
