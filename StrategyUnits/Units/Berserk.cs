using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Berserk : Footman
    {
        public Berserk(int health, string? name, int armor, int minDamage, int maxDamage) 
            : base(health, name, armor, minDamage, maxDamage)
        {
            Rage = false;
        }

        public bool Rage { get; set; }
        public override int Health
        {
            get => base.Health;
            set
            {
                if (value < MaxHealth / 2 && !Rage)
                {
                    MinDamage *= 2;
                    MaxDamage *= 2;
                    Rage = true;
                }
                else if (value > MaxHealth / 2 && Rage)
                {
                    MinDamage /= 2;
                    MaxDamage /= 2;
                    Rage = false;
                }
                base.Health = value;

            }
        }
    }

    
}
