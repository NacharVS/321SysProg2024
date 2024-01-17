using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilliUnit
    {
        private int _healthValue;

        public int Heal
        {
            get { return _healthValue; }
            set { _healthValue = value; }
        }
        public MagicUnit(int health, string? name, int stamina, int defense) : base(health, name, stamina, defense)
        {
        }

        public void HealHP(Unit unit)
        {
            unit.HealthIncreasedEvent += IncMethod;
            for (int i = Stamina; i > 0; i -= 2)
            {
                unit.Health += _healthValue;
                Stamina = i;
                Console.WriteLine("+1");
                if (unit.Health >= unit.GetMaxHP())
                {
                    Stamina -= 2;
                    break;
                }
            }
        }

        void IncMethod(int health)
        {
            Console.WriteLine($"Health UP");
        }
    }
}
