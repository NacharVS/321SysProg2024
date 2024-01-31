using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Build : IHealthController
    {
        private int _health;
        private int _maxHealth;
        private int _square;
        private string _name;
        public Build(int health, string name, int square)
        {
            _health = health;
            _name = name;
            _square = square;
            _maxHealth = _health;
        }

        public int Health { get => _health; set => _health = value; }
        public int MaxHealth { get => _maxHealth; }
        public string Name { get => _name; set => _name = value; }
        public int Square { get => _square; set => _square = value; }

        public event ChageHealth ChageIncreaseHealth;
        public event ChageHealth ChageDecreaseHealth;

        public virtual void ShowInfo()
        {
            Console.Write($"Здание: {_name}  Здоровье: {_health}/{_maxHealth}  площадь: {_square}  ");
        }
    }
}
