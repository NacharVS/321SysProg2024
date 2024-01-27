using StrategyUnits.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Knight : Unit, IProtectedUnit, IBattleUnit
    {
        private int _baseDefense;
        private int _currentDefense;
        public Knight(string name, int health, int damage, int defense) : base(health, name)
        {
            Damage = damage;
            _baseDefense = defense;
            _currentDefense = defense;
            Defense = _baseDefense;
        }
        public int Damage { get; set; }
        public int Defense
        {
            get
            {
                return _currentDefense;
            }
            set
            {
                _baseDefense = value;
            }
        }

        public void Attack(IHealthControll unit)
        {
            unit.TakeDamage(Damage);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"{Name} attacked {unit.Name} and made {Damage} damage. \n{unit.Name} has {unit.Health} HP.");
            Console.ResetColor();

        }

        public override void TakeDamage(int damage)
        {
            if (IsAlive)
            {
                base.TakeDamage(damage - _currentDefense);
                if (Health <= MaxHealth / 2)
                {
                    if (_currentDefense == _baseDefense)
                    {
                        _currentDefense = (int)(_baseDefense * 1.5);
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine($"{Name}'s defense up to {_currentDefense}.");
                        Console.ResetColor();
                    }
                }
                else
                    _currentDefense = _baseDefense;
            }
            else Console.WriteLine($"{Name} dead epta");
        }

        public override void TakeHealth(int heal)
        {
            if (IsAlive)
                Health += heal;
            else 
                Console.WriteLine($"{Name} is dead, do not heal");
        }

        public void Selfheal()
        {
            Health += MaxHealth / 4;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"I '{Name}' healed self on {MaxHealth / 4} HP. My HP now: {Health}.");
            Console.ResetColor();
        }
    }
}
