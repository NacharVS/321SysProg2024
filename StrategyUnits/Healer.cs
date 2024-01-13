using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : Unit
    {
        private int _healing;
        private int _manna;
        private int _MaxManna;

        public Healer(): base(40, "Healer")
        {
            _healing = 1;
            _manna = 60;
            MaxManna = _manna;
        }

        public int Healing
        {
            get { return _healing; }
            set { _healing = value; }
        }
        public int MaxManna
        {
            get { return _MaxManna; }
            private set { _MaxManna = value;}
        }

        public int Manna
        {
            get { return _manna; }
            set {
                if (value < 0) _manna = 0;
                if (value > MaxManna) _manna = MaxManna;
                else _manna = value;
            }
        }

        public void UnitHealing(Unit unit)
        {
            while (unit.Health <= unit.MaxHealth && _manna >= 2)
            {
                
                unit.Health += _healing;
                
                if (unit.Health > unit.MaxHealth)
                {
                    unit.Health = unit.MaxHealth;
                    break;
                }
               _manna -= 2;
                Console.WriteLine($"Unit {unit.Name} health: {unit.Health}/{unit.MaxHealth}. Healder manna {this.Manna}/{MaxManna}");
            }
                
        }

    }
}
