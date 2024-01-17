using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        private int _treat;
        private int _energy;

        public MagicUnit(int health, string? name, int min, int max, int treat, int energy) : base(health, name, min, max)
        {
            _treat = treat;
            _energy = energy;
        }

        public int Treat
        {
            get { return _treat; }
            set { _treat = value; }
        }

         public int Energy
        {
            get { return _energy;}
            set { _energy = value; }
        }

        public void CauseTreat(unit unit)
        {
            while (_energy > _treat*2 && unit.Health > 0 && unit.Health < unit.MaxHealth)
            {
                unit.Health += _treat;
                _energy -= _treat*2 ;
            }


        }


    }
}
