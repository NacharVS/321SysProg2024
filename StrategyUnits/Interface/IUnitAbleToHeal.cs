using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interface
{
    internal interface IUnitAbleToHeal
    {
        public int Heal { get; set; }
        public void InflictHeal(IHealthControl unit);

    }
}
