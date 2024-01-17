using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {
        public Palladin() : base(90, "Hrash", 75, 9)
        {
            Heal = 1;
            Damage = 5;
        }
    }
}
