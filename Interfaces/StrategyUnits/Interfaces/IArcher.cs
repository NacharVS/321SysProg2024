using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IArcher
    {
        public int CountArrow { get; set; }
        public double ArrowDamage { get; set; }
        public void ShootArrow(IHealth unit);
    }
}
