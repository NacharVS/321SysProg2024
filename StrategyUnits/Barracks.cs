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

        public Knight CreateKnight()
        {
            return new Knight(50, "Knight", 3, 3, 7, 10);
        }

        public Palladin CreatePalladin()
        {
            return new Palladin(60, "Palladin", 5, 5, 9, 20);
        }
    }
}
