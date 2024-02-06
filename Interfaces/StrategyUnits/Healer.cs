using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : Unit, IMagicUnit, IHealer
    {
        public int MaxManna { get; set; }

        private int _manna;

        public Healer(string? name, double currentHealth, double maxHealth, int manna, int maxManna) : base(name, currentHealth, maxHealth)
        {
            _manna = manna;
            MaxManna = maxManna;
        }

        public int Manna
        {
            get { return _manna; }
            set
            {
                int previousEnergy = _manna;
                if (value < 0)
                {
                    _manna = 0;
                }
                else
                {
                    if (value > MaxManna)
                        _manna = MaxManna;
                    else
                        _manna = value;
                }
            }
        }

        public void DecreaseManna(int manna)
        {
            Manna -= manna;
        }

        public void Healing(IHealth unit)
        {
            while (Manna > 0)
            {
                if (unit.MaxHealth <= unit.Health)
                {
                    return;
                }
                if (Manna < 2)
                {
                    break;
                }
                unit.IncreseHealth(1);
                DecreaseManna(2);
            }
        }

        public void IncreaseManna(int manna)
        {
            Manna += manna;
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name}\nЗдоровье: {Health}/{MaxHealth}\nМана: {Manna}/{MaxManna}");
        }
    }
}
