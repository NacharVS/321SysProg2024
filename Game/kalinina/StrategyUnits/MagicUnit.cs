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
        private int _maxEnergy;

        public MagicUnit(int health, string? name, int min, int max, int treat, int energy, int defense) : base(health, name, min, max, defense)
        {
            _treat = treat;
            _energy = energy;
            _maxEnergy = energy;

        }

        public int Treat
        {
            get { return _treat; }
            set { _treat = value; }
        }


        public int MaxEnergy
        {
            get;
           private set;
        }

        public int Energy
        {
            get
            {
                return _energy;
            }
            set
            {
                if (value < 0)
                {
                  _energy = 0;
                }
                else
                {
                    if (value > _maxEnergy)
                    {
                        _energy = _maxEnergy;
                    }
                    else _energy = value;
                }
            }
        }

        public void CauseTreat(unit unit)
        {
            while (_energy > _treat*2 && unit.Health > 0 && unit.Health < unit.MaxHealth)
            {
                unit.Health += _treat;
                _energy -= _treat*2 ;
            }


        }

        public override void ShowInfo()
        {
            Console.WriteLine($"unit: {Name} Health: {Health} MaxHealth: {MaxHealth} MaxDamage: {MaxDamage} MinDamage {MinDamage} Defense: {Defense} Energy {Energy}");
        }
    }
}
