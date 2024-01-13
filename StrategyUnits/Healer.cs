using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer: Unit
    {
        private int _heal;
        private int _energy = 60;

        public int Heal
        {
            get { return _heal; }
            set { _heal = value; }
        }

        public Healer() : base(50, "Healer")
        {

            _heal = 7;
            //jhgk
        }

        public void AddHeal(Unit unit)
        {
            if (_energy < 2)
            {
                return;
            }

            int missingHealth = unit.MaxHealth - unit.Health;

            if (missingHealth * 2 > _energy)
            {
                missingHealth = _energy / 2;
            }

            unit.Health += missingHealth;
            _energy -= missingHealth * 2;
        }
    }
 }
