using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserk : Footman
    {
        //public delegate void RageChangedDelegate(Berserk berserk);
        public Berserk(int health, string? name, int armor, int minDamage, int maxDamage) : base(health, name, armor, minDamage, maxDamage)
        {

        }

        public override void TakeDamage(int damage, Unit unit)
        {
            Berserk berserk = (Berserk)unit;
            if (berserk.Health < berserk.MaxHealth / 2 && berserk.MinDamage == 3)
            {
                berserk.MinDamage = berserk.MinDamage * 2;
                berserk.MaxDamage = berserk.MaxDamage * 2;
            }
            base.TakeDamage(damage, berserk);
        }

        //public event RageChangedDelegate RageCheckEvent;
    }
}
