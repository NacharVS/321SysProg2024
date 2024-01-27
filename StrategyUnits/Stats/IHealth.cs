using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Stats
{
    internal interface IHealth
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }

        public void TakeDamage(int damage)
        {

        }

        public void TakeHeal(int health)
        {

        }
    }
}
