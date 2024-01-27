using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyUnits.Human;

namespace StrategyUnits.Building
{
    internal class Barracs
    {
        public Footman CreateRecruitFootman()
        {
            return new Footman(60, "Recruit Footman", 5, 5, 10);
        }
        public Footman CreateAdvancedFootman()
        {
            return new Footman(70, "Advanced Footman", 6, 8, 12);
        }
        public Footman CreateSuperFootman()
        {
            return new Footman(80, "Super Footman", 7, 10, 15);
        }

        public Berserker CreateBerserk()
        {
            return new Berserker(100, "Berserker", 1, 10, 15);
        }

        public Palladin CreatePalladin()
        {
            return new Palladin(100, "Palladin", 5, 10, 5, 10);
        }
        public Knight CreateKnight()
        {
            return new Knight(100, "Knight", 5, 10, 5, 10);
        }
    }
}
