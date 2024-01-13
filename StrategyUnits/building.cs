using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class building
    {
        private int _currentHealth;
        private string? _name;
        public int MaxHealth { get; private set; }
        public building(int health, string? name)
        {
            _currentHealth = health;
            _name = name;
            MaxHealth = health;
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Health
        {
            get => _currentHealth;
            set
            {
                if (value < 0)
                {
                    _currentHealth = 0;
                }
                else
                    _currentHealth = value;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Building: {_name} Health: {_currentHealth}/{MaxHealth}");
        }
    }
}
