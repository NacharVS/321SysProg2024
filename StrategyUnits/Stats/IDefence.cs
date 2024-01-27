using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Stats
{
    internal interface IDefence
    {
        public int Defence { get; set; }
        public int MaxDefence { get; set; }
    }
}
