using StrategyUnits.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Doctor: MagicUnit
    {
        private int _heal;
        public int Heal
        {
            get { return _heal; }
            set { _heal = value; }
        }
        public Doctor() : base(70, "Doctor", 0, 100, 1, 5)
        {
            _heal = 1;
        }
        public void IncreaseHeal(Unit unit)
        {
            while (Mana > 0 && unit.Health < unit.MaxHealth && unit.Health > 0)
            {
                unit.Health += _heal;
                Mana -= 2;

                if (Mana < 0)
                    Mana = 0;
            }
        }
    }
}
