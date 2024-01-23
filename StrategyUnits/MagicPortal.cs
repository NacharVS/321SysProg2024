using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicPortal
    {
        public Healer CreateMiddleHelaer()
        {
            return new Healer(30, "Healer", 40, 5);
        }

        public Palladin CreateMiddlePalladin()
        {
            return new Palladin(50, "Palladin", 50, 6);
        }
        public Palladin CreateMiddleKnight()
        {
            return new Knight(50, "Knight", 60, 8);
        }
    }
}
