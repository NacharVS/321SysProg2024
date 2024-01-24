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
            return new Footman(40, "Footman", 1, 2, 5);
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

        public Healer CreateHealer()
        {
            return new Healer(30, "Healer", 0, 1, 3, 30);
        }
        public Archer CreateArcher()
        {
            return new Archer(20, "Archer", 0, 5, 15);
        }

    }
}
