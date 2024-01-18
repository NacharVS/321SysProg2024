using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class militaryUnits : Unit
    {
        private int _minDamage;
        private int _maxDamage;
        private int _damage;
        public int minDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }
        public int maxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public militaryUnits(int health, string? name, int defence, int min_damage, int max_damage) : base(health, name, defence)
        {
            minDamage = min_damage;
            maxDamage = max_damage;
        }
        public virtual void InflictDamage(Unit unit)
        {
            Random rnd = new Random();
            _damage = rnd.Next(minDamage, maxDamage);
            _damage -= unit.Defence;
            unit.Health -= _damage;
            unit.TakeDamage(_damage);
            Console.WriteLine($"Юнит: {this.Name} наносит удар своим болтом {_damage} единиц по {unit.Name} при броне {unit.Defence}");
        }
    }
}
