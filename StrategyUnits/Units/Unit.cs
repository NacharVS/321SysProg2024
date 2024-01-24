using StrategyUnits.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits.Units
{
    internal class Unit : IHealthControll
    {
        public Unit(int health, string? name)
        {
            Health = health;
            Name = name;
        }

        public int Health { get; set; }
        public string? Name { get; set; }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public void TakeHeal(int heal)
        {
            Health += heal;
        }
    }
}
