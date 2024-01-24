using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits.Units
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _mana;
        public int MaxMana { get; set; }
        public MagicUnit(int health, string? name, int armor, int mana, int MinDamage, int MaxDamage) : base(health, name, armor, MinDamage, MaxDamage)
        {
            _mana = mana;
            MaxMana = mana;
        }
        public int Mana
        {
            get { return _mana; }
            set
            {
                if (value <= 0)
                    _mana = 0;
                else
                    _mana = value;
            }
        }
        public override void ShowInfo() => Console.WriteLine($"Unit:{Name} Health:{Health}/{MaxHealth} Damage:{MinDamage}-{MaxDamage} Armor:{Armor} Mana:{Mana/MaxMana}");

    }
}
