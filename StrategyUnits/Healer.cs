using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : MagicUnit
    {
        private int _healing;

        public Healer(string name, int health, int defense, int minDamage, int maxDamage, int manna, int healing)
                : base(name, health, defense, minDamage, maxDamage, manna)
        {
            _healing = healing;
        }

        public int Healing
        {
            get { return _healing; }
            set { _healing = value; }
        }

        public void UnitHealing(Unit unit)
        {
            while (unit.Health <= unit.MaxHealth && this.MUManna >= 2)
            {

                unit.Health += _healing;

                if (unit.Health > unit.MaxHealth)
                {
                    unit.Health = unit.MaxHealth;
                    break;
                }
                this.MUManna -= 2;
                Console.WriteLine($"Unit {unit.Name} health: {unit.Health}/{unit.MaxHealth}. Healder manna: {this.MUManna}/{this.MUMaxManna}");
            }

        }

    }
}