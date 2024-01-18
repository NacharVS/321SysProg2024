using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {
        public Palladin() : base(20, 40, "Palladin", 10, 2) { }

        public void MagicHit(Unit unit)
        {
            if (Manna > MagicDamage)
            {
                unit.Health -= this.MagicDamage;
                this.Manna -= this.MagicDamage;
            }
            else if(MagicDamage > 0)
            {
                unit.Health -= this.Manna;
                this.Manna = 0;
            }
            else
            {
                Console.WriteLine(this.Name + " manna 0");
            }
        }
    }
}
