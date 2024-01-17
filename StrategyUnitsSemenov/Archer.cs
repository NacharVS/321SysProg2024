using StrategyUnitsSemenov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnitsSemenov
{
    internal class Archer : Unit
    {
        private int _minDamage;
        private int _maxDamage;

        public Archer() : base(40, "Archer")
        {
            _minDamage = 5;
            _maxDamage = 10;
        }

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }

        public void Shoot(Unit unit)
        {
            int damage = new Random().Next(_minDamage, _maxDamage + 1);
            unit.Health -= damage;

            Console.WriteLine($"Archer shot {unit.Name} for {damage} damage.");
        }
    }
}
