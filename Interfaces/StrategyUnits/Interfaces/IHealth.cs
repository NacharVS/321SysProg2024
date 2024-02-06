using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IHealth
    {
        public double Health { get; set; }
        public double MaxHealth { get; set; }
        public void DecreaseHealth(double damage);
        public void IncreseHealth(double health);
        public delegate void HealthChangedDelegate(string? name, double health, double difference, double maxHealth);
        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}
