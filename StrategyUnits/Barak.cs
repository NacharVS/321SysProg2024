using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Barak
    {
        public Footman CreateRecruitFootman()
        {
            return new Footman(50, "Recruit footman", 2, 4, 7);
        }

        public Footman CreateAdvansedFootman()
        {
            return new Footman(60, "Advansed footman", 2, 6, 9);
        }
        public Footman CreateVeteranFootman()
        {
            return new Footman(70, "Recruit", 3, 7, 10);
        }

        public Footman CreateBerserk()
        {
            return new Berserk(100, "Berserk", 4, 10, 14);
        }

        public Knight CreateKnight()
        {
            return new Knight(90,"Knight", 6, 8, 50, 7, 10);
        }

        public Knight CreatePalladin()
        {
            return new Paladin(150, "Knight", 8, 10, 100, 8, 11);
        }


    }
}
