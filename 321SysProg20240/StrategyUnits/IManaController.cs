using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IManaController
    {
        public int Mana { get; set; }
        public int HealStrange {  get; set; }
    }
}
