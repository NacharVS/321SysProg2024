using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Church : IChurch, IMagicUnit
    {
        public int MaxManna { get; set; }

        private int _manna;

        public Church()
        {
            MaxManna = 30;
            _manna = 30;
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
            _manna -= manna;
        }

        public void IncreaseManna(int manna)
        {
            _manna += manna;
        }

        public void RecoveryManna(IMagicUnit unit)
        {
            while (Manna > 0)
            {
                if (unit.MaxManna <= unit.Manna)
                {
                    return;
                }
                if (Manna < 2)
                {
                    break;
                }
                unit.IncreaseManna(1);
                DecreaseManna(2);
            }
        }
        public Palladin CreatePaladin()
        {
            return new Palladin("Паладин", 12, 12, 30, 30, 16, 4);
        }
        public Healer CreateHealer()
        {
            return new Healer("Исцелитель", 8, 8, 35, 35);
        }
    }
}
