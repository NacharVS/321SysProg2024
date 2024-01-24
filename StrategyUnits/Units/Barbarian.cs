using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Barbarian : HostileUnit, IProtectionControl
    {
        public int Protection { get; set; }
        public Barbarian(string name, int health, int damage, int protection) : base(name, health, damage)
        {
            Protection = protection;
        }

        public override void TakeDamage(int damage)
        {
            Console.WriteLine($"Броня сдержала {Protection} урон(а). {Name} получил {damage - Protection} урон(а)");
            Health -= damage - Protection;
        }
    }
}
