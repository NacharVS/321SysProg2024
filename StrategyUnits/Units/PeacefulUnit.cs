using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class PeacefulUnit : IHealthControl
    {
        public int Health { get; set; }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
