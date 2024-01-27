using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class HostileUnit : Unit, IAttackControl
    {
        public int Damage { get; set; }

        public HostileUnit(string name, int health, int damage) : base(name, health)
        {
            Name = name;
            Health = health;
            Damage = damage;
        }

        public virtual void Attack(IHealthControl unit)
        {
            if (Health > 0)
            {
                Console.WriteLine($"{Name} атаковал с уроном {Damage}");
                unit.TakeDamage(Damage);
            }
            else
            {
                Console.WriteLine("Я как бы мертв для атаки\n");
            }
        }

        public void Attack(IBuildingHealth building)
        {
            Console.WriteLine($"{Name} атаковал с уроном {Damage}");
            building.TakeDamage(Damage);
        }
    }
}
