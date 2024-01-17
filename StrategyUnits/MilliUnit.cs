using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilliUnit : Unit
    {
        private int _damage;
        private int _minDamage = 0;
        private int _maxDamage = 10;
        Random _random = new Random();

        public MilliUnit(int health, string? name, int stamina, int defense) : base(health, name, stamina, defense)
        {
            _damage = Damage;
        }

        public int Damage
        {
            get { return _random.Next(_minDamage, _maxDamage); }
            set { _damage = value; }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"This millitary unit {Name}");
        }
        public void InflictDamage(Unit unit)
        {
            if (_damage >= unit.Defense)
            {
                unit.Health += unit.Defense;
                unit.Health -= _damage;
                unit.Defense -= _damage;
                ShowInfo();
                Console.WriteLine($"Unit {unit.Name} get damage {_damage}. His health: {unit.Health}. His armor: {unit.Defense}");
            }
            else
            {
                unit.Defense -= _damage;
                Console.WriteLine($"Unit {unit.Name} get damage {Damage}. His health: {unit.Health}. His armor: {unit.Defense}");
            }
            unit.HealthDecreasedEvent += DecMethod;
        }
        void DecMethod(int health)
        {
            Console.WriteLine($"Health Down");
        }
    }
}
