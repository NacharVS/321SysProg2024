using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : Knight
    {
        public Paladin(string name, int health, int defense, int minDamage, int maxDamage, int manna)
                : base(name, health, defense, minDamage, maxDamage, manna)
            {
            }
        public override int Defense
        {
            get
            {
                if (Health < MaxHealth * 0.5)
                {
                    Console.WriteLine($"у {Name} броня увеличена в 2 раза!");
                    return _defense * 2;
                }
                else
                {
                    return _defense; 
                }
            }
        }
        
    }
}
