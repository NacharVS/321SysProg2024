using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Human
{
    internal class Berserker : Footman
    {
        private int _damage;
        private int _firstDamage;
        public Berserker(int health, string? name, int defence, int min_damage, int max_damage) : base(health, name, defence, min_damage, max_damage)
        {
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Berserker {Health}/{MaxHealth}");
        }
        public override void InflictDamage(Unit unit)
        {
            if (Health > MaxHealth * 0.5)
            {
                base.InflictDamage(unit);
            }
            else
            {
                Console.WriteLine($"{Name} в ярости!"); ; ;
                Random rnd = new Random();
                _firstDamage = rnd.Next(minDamage, maxDamage) * 2;
                _damage = _firstDamage - unit.Defence;
                unit.Health -= _damage;
                unit.TakeDamage(_damage);
                Console.WriteLine($"Юнит: {Name} наносит удар своим болтом {_firstDamage} единиц по {unit.Name} при броне {unit.Defence}");
            }
        }
    }
}
