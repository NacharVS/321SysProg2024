using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilliUnit
    {
        private int _healthValue;

        public MagicUnit(int health, string? name, int stamina, int defense) : base(health, name, stamina, defense)
        {
        }
        public int Heal
        {
            get { return _healthValue; }
            set { _healthValue = value; }
        }
    }
}