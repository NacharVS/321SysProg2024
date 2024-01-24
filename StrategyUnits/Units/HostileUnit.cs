using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class HostileUnit : IHealthControl, IAttackControl
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int Damage { get; set; }

        public HostileUnit(string name, int health, int damage)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public void Attack(IHealthControl unit)
        {
            unit.TakeDamage(Damage);
        }

        public virtual void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
