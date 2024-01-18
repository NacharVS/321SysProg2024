using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Barracks : Build
    {
        public Barracks() : base(200, "Barracks")
        {
        }

        public Footman CreateFootman() 
        {
            return new Footman(40, "Footman", 1, 10, 15);
        }

        public Berserk CreateBerserk()
        {
            return new Berserk(50, "Berserk", 2, 3, 10);
        }

        public Palladin CreatePalladin()
        {
            return new Palladin(50, "Palladin", 5, 3, 7, 30);
        }
    }
}
