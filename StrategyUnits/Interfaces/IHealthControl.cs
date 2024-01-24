using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IHealthControl
    {
        public int Health { get; set; }

        public void TakeDamage(int damage);
    }
}
