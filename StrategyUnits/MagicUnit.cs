using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
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
        public override string Name { get => base.Name; set => base.Name = value; }
        public int MaxMana { get; private set; }
        public override int Defense => base.Defense;
        public MagicUnit(string name, int defense, int mana) : base("Мэджик",15,1, 5)
        {
            Mana = mana;
            MaxMana = mana;
            Name = name;
            Defense = defense;
        }
    }
}
