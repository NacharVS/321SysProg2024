using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Barracs: Buildings
    {
        public Barracs(): base(1000, "Barracs")
        {

        }
        public Footman CreateFootman()
        {
            return new Footman(60, "Footman", 2, 15, 20);
        }

        public Berserker CreateBerserker()
        {
            return new Berserker(40, "Berserker", 9, 10, 15);
        }
        public Archer CreateArcher()
        {
            return new Archer(40, "Archer", 0, 5, 10);
        }
        public Paladin CreatePaladin()
        {
            return new Paladin(50, "Paladin", 12, 60, 10, 15);
        }
        public Knight CreateKnight()
        {
            return new Knight(90, "Knight", 10, 50, 8, 12);
        }
        public Healer CreateHealer()
        {
            return new Healer();
        }
    }
}
