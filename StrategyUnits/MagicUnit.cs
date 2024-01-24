//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Linq;

//namespace StrategyUnits
//{
//    internal class MagicUnit : MillitaryUnit
//    {
//        public MagicUnit(int health, string name, int armor, int minDamage, int maxDamage, int mana) : base(health, name, armor, minDamage, maxDamage)
//        {
//            _mana = mana;
//            MaxMana = mana;
//        }
//        private int _mana;
//        public int MaxMana { get; private set; }
//        public int Mana
//        {
//            get { return _mana; }
//            set
//            {
//                if (value < 0) _mana = 0;
//                else if (value > MaxMana) _mana = MaxMana;
//                else _mana = value;
//            }
//        }

//        public override void ShowInfo()
//        {
//            Console.WriteLine($"Unit:{Name} Health:{Health}/{MaxHealth} Damage:{MinDamage}-{MaxDamage} Mana:{Mana}/{MaxMana}");
//        }
//    }
//}
