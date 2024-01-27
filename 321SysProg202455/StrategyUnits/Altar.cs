using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar : Build
    {
        private int _regenMana;

        public Altar() : base(100, "Altar", 9)
        {
            _regenMana = 10;
        }
        public int RegenMana
        {
            get { return _regenMana; }
            set { _regenMana = value <= 0 ? 0 : value; }
        }


        public void RecoveryMana(MagicUnit magicUnit)
        {
            magicUnit.Mana += _regenMana;
        }

        public override void ShowInfo()
        {
            base.ShowInfo();
            Console.WriteLine($"сила восстановления маны: {_regenMana}");
        }

    }
}
