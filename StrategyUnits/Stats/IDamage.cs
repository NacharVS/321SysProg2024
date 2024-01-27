using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Stats
{
    internal interface IDamage
    {
        public int Damage { get; set; }

        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public void Attack(IHealth unit);
    }
}
