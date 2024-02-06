using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Church
    {
        private double _manna;
        private double _maxManna;
        public Church()
        {
            _manna = 100;
            _maxManna = 100;
        }
        public double Manna
        {
            get { return _manna; }
            set
            {
                if (value < 0)
                {
                    _manna = 0;
                }
                else
                {
                    if (value > _maxManna)
                        _manna = _maxManna;
                    else
                        _manna = value;
                }
            }
        }

        public double MaxManna
        {
            get { return _maxManna; }
            set
            {
                if (value < 0)
                {
                    _manna = 0;
                }
                else
                {
                    if (value > _maxManna)
                        _manna = _maxManna;
                    else
                        _manna = value;

                }
            }
        }
        public void RestoreManna(MagicUnit magicUnit)
        {
            var currentEnergyBeforeRestore = magicUnit.Manna;
            while (Manna > 0)
            {
                if (magicUnit.MaxManna <= magicUnit.Manna)
                {
                    return;
                }
                magicUnit.Manna += 10;
                _manna -= 1;
            }
        }
        public Palladin CreatePaladin()
        {
            return new Palladin(25, "Paladin", 6, 15, 30, 30);
        }
        public Healer CreateHealer()
        {
            return new Healer(15, "Cleric", 0, 0, 20, 20);
        }
    }
}
