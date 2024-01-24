using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Buildings
{
    internal class Building : IHealthControl
    {
        public string Name { get; set; }
        public int Health { get; set; }

        public Building(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
        public void TakeHeal()
        {
            Health++;
        }
    }
}
