using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{

    internal class Palladin : Knight
    {
        public Palladin(int health, string? name, int armor, int minDamage, int maxDamage, int mana)
            : base(health, name, armor, minDamage, maxDamage, mana) 
        {
            Shield = false;
        }

        public bool Shield { get; set; }    
        public override int Health
        {
            get => base.Health;
            set
            {
                if (value < MaxHealth / 2 && !Shield)
                {
                    Armor *= 2;
                    Shield = true;
                }   
                else if(value > MaxHealth / 2 && Shield)
                {
                    Armor /= 2;
                    Shield = false;
                }    
                base.Health = value;

            }
        }
    }
}
