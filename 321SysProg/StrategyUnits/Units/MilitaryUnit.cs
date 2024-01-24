using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits.Units
{
    internal class MilitaryUnit : Unit
    {
        private int _damage;
        private int _minDamage;
        private int _maxDamage;
        public MilitaryUnit(int health, string? name, int armor, int minDamage, int maxDamage) : base(health, name, armor)
        {
            _minDamage = minDamage;
            _maxDamage = maxDamage;
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
        public virtual void DealDamage(Unit unit)
        {
            Random rnd = new Random();
            _damage = rnd.Next(MinDamage, MaxDamage) - unit.Armor;
            if (_damage <= 0)
                Console.WriteLine($"{unit.Name} got hit, but no damage");
            else
            {
                Console.WriteLine($"{unit.Name} took {_damage + unit.Armor} damage. (Absorbed: {unit.Armor})");
                unit.TakeDamage(_damage, unit);
            }
        }
        public override void ShowInfo() => Console.WriteLine($"Unit:{Name} Health:{Health}/{MaxHealth} Damage:{MinDamage}-{MaxDamage} Armor:{Armor}");
    }
}
    

