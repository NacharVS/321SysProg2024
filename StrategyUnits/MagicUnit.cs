using System;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _healStrange;
        private int _mana;
        private int _maxMana;

        public MagicUnit(int health, string name, int armor, int mindamage, int maxdamage, int healStrange, int mana)
            : base(health, name, armor, mindamage, maxdamage)
        {
            _mana = mana;
            _healStrange = healStrange;
            _maxMana = mana;
        }
        public int MaxMana 
        {
            get { return _maxMana; }
        }

        public int  HealStrange 
        {
            get { return _healStrange; }
            set { _healStrange = value <= 0 ? 0 : value; }
        }


        public int Mana
        {
            get { return _mana; }
            set
            {
                if (value < 0)
                    _mana = 0;
                else if (value >= _maxMana)
                    _mana = _maxMana;
                else
                    _mana = value;
            }
        }


        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}/{MaxHealth}  Armor: {Armor}  Mana: {_mana}");
        }
    }
}
