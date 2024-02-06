using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IMagicUnit
    {
        public int Manna { get; set; }
        public int MaxManna { get; set; }
        public void DecreaseManna(int manna);
        public void IncreaseManna(int manna);
    }
}
