using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _damage;

        private int _minDamage;
        private int _maxDamage;

        public override string Name { get => base.Name; set => base.Name = value; }
        public override int Health { get => base.Health; set => base.Health = value; }
        public override int MaxHealth => base.MaxHealth;

        public MilitaryUnit(string name, int health, int minDamage, int maxDamage) : base("Военный", 60, 5)
        {
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            Name = name;
            Health = health;
            MaxHealth = health;
        }

        public void InflictDamage(Unit unit)
        {
            Random random = new Random();
            _damage = random.Next(_minDamage, _maxDamage);

            if (unit.Defense >= _damage)
            {
                Console.WriteLine($"Броня ({unit.Defense}) поглотила весь урон ({_damage})");
            }
            else
            {
                Console.WriteLine($"Юниту {unit.Name} пробили броню ({unit.Defense}), нанесено {_damage} дамага ({_minDamage}-{_maxDamage})");
                unit.Health = unit.Health + (unit.Defense - _damage);
            }
        }
    }
}
