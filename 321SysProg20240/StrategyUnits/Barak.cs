using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Barak : Build
    {
        public Barak() : base(100, "Barak", 9) { }
        public Footman CreateFootman()
        {
            return new Footman(750, "Footman", 2, 5, 7);
        }

        public Berserk CreateBerserk()
        {
            return new Berserk(100, "Berserk", 4, 10, 14);
        }

        public Knight CreateKnight()
        {
            return new Knight(90,"Knight", 4, 20, 25, 10, 50);
        }

        public Paladin CreatePalladin()
        {
            return new Paladin(150, "Palladin", 8, 10, 15, 15, 1000);
        }

        public Archer CreateArcher()
        {
            return new Archer(50, "Archer", 2, 5, 8);
        }

        public Bishop CreateBishop()
        {
            return new Bishop(50, "Bishop", 15, 1, 3, 150);
        }

    }
}
