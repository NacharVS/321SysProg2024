using StrategyUnitsSemenov;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnitsSemenov
{
    internal class Berserker : Unit
    {
        private int _minDamage;
        private int _maxDamage;

        public Berserker() : base(70, "Berserker")
        {
            _minDamage = 10;
            _maxDamage = 20;
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

        public void Attack(Unit unit)
        {
            int damage = new Random().Next(_minDamage, _maxDamage + 1);
            unit.Health -= damage;

            Console.WriteLine($"Berserker attacked {unit.Name} for {damage} damage.");
        }
    }
}
