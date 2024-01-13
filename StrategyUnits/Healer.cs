using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : Unit
    {
        private int _heal;
        private int _mana;
        public int MaxMana { get; private set; }

        public int Heal { 
            get { return _heal; }
            set { _heal = value; }
        }
        public int Mana
        {
            get { return _mana;  }
            set { _mana = value; }
        }
        
        public Healer() : base(50, "Healer")
        {
            _heal = 1;
            _mana = 30;
            MaxMana = _mana;
        }
        public void AddHeal(Unit unit)
        {
            while (unit.Health < unit.MaxHealth && _mana>0)
            {
                if (unit.Health >= unit.MaxHealth)
                {
                    Console.WriteLine("Юнит вылечен!");
                    unit.Health = unit.MaxHealth;
                }
                else
                {
                    unit.Health += _heal;
                    _mana -= _heal * 2;
                }
            }
            Console.WriteLine("Юнит здоров либо нет маны!");

        }
    }
}
