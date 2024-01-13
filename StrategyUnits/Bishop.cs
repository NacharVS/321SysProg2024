using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bishop : Unit
    {

        private int _heal;
        private int _stamina;
        private int _maxStamina;
        public Bishop() : base(20, "Svyatoi_Otec")
        {
            _heal = 2;
            _stamina = 100;
            _maxStamina = _stamina;
        }

        public int Stamina
        {
            get { return _stamina; } 
            set { _stamina = value; }
        }

        public int MaxStamina
        {
            get { return _maxStamina; } 
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}/{MaxHealth}   Stamina: {Stamina}/{MaxStamina}");
        }
        public void Heal(Unit unit)
        {


            if (unit.MaxHealth != unit.Health && unit.Health > 0 && _stamina > 0)
            {
                if (unit.MaxHealth - unit.Health >= _heal)
                {
                    _stamina = _stamina - _heal;
                    unit.Health = _heal + unit.Health;
                }
                else
                {
                    _stamina -= unit.MaxHealth - unit.Health;
                    unit.Health = unit.MaxHealth;
                }


            }
        }
    }
}
