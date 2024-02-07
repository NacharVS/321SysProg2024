using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Casern
    {
        public Footman CreateFootman()
        {
            return new Footman("Лакей", 10, 10, 5);
        }
        public Berserker CreateBerserker()
        {
            return new Berserker("Берсерк", 21, 21, 13, 3);
        }
    }
}
