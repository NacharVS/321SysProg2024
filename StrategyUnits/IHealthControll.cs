using System;
using System.Collections.Generic;
namespace StrategyUnits
{
    internal interface IHealthControll
    {
        public int Health { get; set; }

        public void TakeDamage(int damage);
    }
}
