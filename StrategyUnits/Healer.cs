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
        private int _stamina;

        public int Heal
        {
            get { return _heal; }
            set { _heal = value; }
        }

        public int MaxStamina { get; private set; }

        public int Stamina
        {
            get { return _stamina; }
            set
            {
                if (value <= 0)
                {
                    _stamina = 0;
                }
                else if (value >= MaxStamina)
                {
                    _stamina = MaxStamina;
                }
                else
                {
                    _stamina = value;
                }
            }
        }

        public Healer() : base(15, "Healer")
        {
            _heal = 1;
            _stamina = 100;
            MaxStamina = _stamina;
        }
        // 1хп за 2 манки

        public void InflictHeal(Unit unit)
        {
            if (unit.Health <= 0)
            {
                return;
            }

            while (unit.Health < unit.MaxHealth)
            {
                _stamina -= 2;
                unit.Health += 1;
                if (_stamina == 0)
                {
                    return;
                }
            }
        }

        public void ShowHealerInfo()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Stamina: {Stamina}/{MaxStamina}");
            Console.ResetColor();

        }
    }
}
