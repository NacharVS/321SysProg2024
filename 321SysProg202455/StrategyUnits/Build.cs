using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Build
    {
        private int _health;
        private int _maxHealth;
        private int _square;
        private string _name;
        public Build(int health, string name, int square)
        {

        }

        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }

        public int MaxHealth
        {
            get { return _maxHealth; }
            set { _maxHealth = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Square
        {
            get { return _square; }
            set { _square = value; }
        }

        public virtual void ShowInfo()
        {
            Console.Write($"Здание: {_name}  Здоровье: {_health}/{_maxHealth}  площадь: {_square}  ");
        }
    }
}
