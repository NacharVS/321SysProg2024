using StrategyUnits.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Spawner
    {
        public Barbarian CreateSimpleBarbarian()
        {
            return new Barbarian("Barbarian", 100, 40);
        }
        public Healer CreateSimpleHealer()
        {
            return new Healer("Healer", 20, 5, 10, 50);
        }
        public Knight CreateSimpleKinght()
        {
            return new Knight("Knight", 90, 45, 10);
        }

        public Knight CreateFool()
        {
            return new Knight("Fool", 10, 5, 0);
        }
    }
}
