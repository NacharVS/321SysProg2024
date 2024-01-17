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
        public int MAxEnergy { get; private set; }

        public int Treat
        {
            get { return _treat; }
            set { _treat = value; }
        }


        public int Energy
        {
            get => _energy;
            set
            {
                if (value < 0)
                {
                    _energy = 0;
                }
                else if (value >= MAxEnergy)
                {
                    _energy = MAxEnergy;
                }
                else
                {
                    _energy = value;
                }
            }
        }
        public MagicUnit(int health, string? name,int armor, int treat, int energy, int mindamage, int maxdamage) : base(health, name, armor, mindamage, maxdamage)
        {
            _health = health;
            _name = name;
            _treat = treat;
            _energy = energy;
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public override void ShowInfo() => Console.WriteLine($"Unit: {this.Name} Health: {this.Health}/{this.MaxHealth} Energy: {Energy}");
        public virtual void InflictTreat(Unit unit)
        {
            while (unit.Health < unit.MaxHealth && (Energy / 2) > 0)
            {

                unit.Health += Treat;
                Energy -= 2;

            }

        }
    }
}
