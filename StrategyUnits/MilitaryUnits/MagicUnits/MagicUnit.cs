using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.MilitaryUnits.MagicUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _mana;

        public int Mana
        {
            get { return _mana; }
            set
            {
                if (_mana < 0)
                    _mana = 0;
                else if (_mana > MaxMana)
                    _mana = MaxMana;
                else
                    _mana = value;
            }
        }
        public int MaxMana { get; private set; }

        public MagicUnit(string name, int health, int defense, int minDamage, int maxDamage, int mana)
            : base(name, health, defense, minDamage, maxDamage)
        {
            Mana = mana;
            MaxMana = mana;
            Name = name;
        }
    }
}
