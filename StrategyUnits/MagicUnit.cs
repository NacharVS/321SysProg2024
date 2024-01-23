using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class MagicUnit : militaryUnits
    {
        public MagicUnit(int health, string? name, int defense, int energy ,int minDamage, int maxDamage) : base(health, name, defense, minDamage, maxDamage)
        {
            _energy = energy;
            MaxEnergy = energy;
        }
        private int _energy;
        public int MaxEnergy { get; private set; }
        public int Energy
        {
            get { return _energy; }
            set
            {
                if(value < 0) _energy = 0;
                else if(value > MaxEnergy) _energy = MaxEnergy;
                else _energy = value;
            }
        }
    }
}
