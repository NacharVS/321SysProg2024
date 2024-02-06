using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Casern
    {
        public Footman CreateRecruit()
        {
            return new Footman(10, "Recruit", 0, 7);
        }
        public Footman CreateFootman()
        {
            return new Footman(14, "Footman", 2, 10);
        }
        public Berserker CreateBerserker()
        {
            return new Berserker(20, "Berserker", 13, 12);
        }
        public Archer CreateArcher()
        {
            return new Archer(20, "Archer", 1, 5, 10);
        }
    }
}
