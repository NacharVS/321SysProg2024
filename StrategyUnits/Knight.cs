using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Knight: MagicUnit
    {
        private int _heal;

        public int Heal
        {
            get { return _heal; }
            set { _heal = value; }
        }

        public Knight(int health, string? name, int defense, int energy,int minDamage, int maxDamage): base(health, name, defense, energy,minDamage, maxDamage)
        {
            _heal = 10;
        }

        public void AddHeal(Unit unit)
        {
            if (Energy < 2)
            {
                return;
            }

            int missingHealth = unit.MaxHealth - unit.Health;

            if (missingHealth * 2 > Energy)
            {
                missingHealth = Energy / 2;
            }

            unit.Health += missingHealth;
            Energy -= missingHealth * 2;
        }
    }
}
