using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : Unit
    {
        private int _healthValue;

        public int Heal
        {
            get { return _healthValue; }
            set { _healthValue = value; }
        }

        public Healer() : base(80, "Bykov", 60)
        {
            _healthValue = 1;
        }

        public void HealHP(Unit unit)
        {
            for (int i = Stamina; i > 0; i-=2)
            {
                unit.Health += _healthValue;
                Console.WriteLine("+1 HP");
                Stamina = i;
                if (unit.Health == unit.GetMaxHP())
                {
                    Stamina -= 2;
                    break;
                }
            }
            
            
        }

    }
}
