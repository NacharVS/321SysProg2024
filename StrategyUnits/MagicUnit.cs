using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _manna;
        private int _maxManna;

        public int MUManna
        {
            get { return _manna; }
            set
            {
                if (value < 0) _manna = 0;
                if (value > MUMaxManna) _manna = MUMaxManna;
                else _manna = value;
            }
        }

        public int MUMaxManna
        {
            get { return _maxManna; }
            set
            {
                if (value < 0) _manna = 0;
                if (value > MUMaxManna) _maxManna = MUMaxManna;
                else _maxManna = value;
            }
        }

        public MagicUnit(string name, int health, int defense, int minDamage, int maxDamage, int maxmanna)
            : base(name, health, defense, minDamage, maxDamage)
        {
            _manna = maxmanna;
            _maxManna = maxmanna;
        }
    }
}
