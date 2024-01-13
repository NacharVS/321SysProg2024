using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar : building
    {
        private int _addMana;

        public int addMana
        {
            get { return _addMana; }
            set { _addMana = value; }
        }
        public Altar() : base(100, "Altar")
        {
            _addMana = 10;
        }
        public void AddManaToUnit(Healer healer)
        {
            healer.Mana += _addMana;
        }
    }
}
