using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interface
{
    internal interface IHealthControl
    {
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        string Name { get; set; }

        public void TakeDamage(int Damage);
    }
}
