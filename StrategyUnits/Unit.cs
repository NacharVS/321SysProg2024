﻿namespace StrategyUnits
{
    internal class Unit
    {
        private int _currentHealth;
        private string? _name;
        public int MaxHealth { get; private set; }

        public Unit(int health, string? name)
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
                if(value < 0)
                {
                    _currentHealth = 0;
                }
                else
                    _currentHealth = value;
            }
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_currentHealth}/{MaxHealth}");
        }
    }
}
