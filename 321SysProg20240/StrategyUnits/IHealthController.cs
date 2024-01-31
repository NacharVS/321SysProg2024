using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    
    internal interface IHealthController
    {
        public int Health { get; set; } 
        public string Name { get; set; }

        public void TakeDamage(int damage) { }

        public event ChageHealth ChageIncreaseHealth;
        public event ChageHealth ChageDecreaseHealth;
    }
}
