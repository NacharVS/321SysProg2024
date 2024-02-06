using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IAttack
    {
        public void Attack(IHealth unit);
        public double Damage { get; set; }
    }
}
