﻿namespace StrategyUnits
{ 
    public delegate void HealthChangedDelegate(int health);
    internal class Unit
    {
        private int _health;
        private string? _name;
        public int MaxHealth { get; private set; }
        public int Armor { get; set; }


        public Unit(int health, string? name, int armor)
        {
            _health = health;
            _name = name;
            MaxHealth = health;
            Armor = armor;
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
                //HealthChangedEvent?.Invoke(_currentHealth);
                if (value > _currentHealth) HealthIncreasedEvent?.Invoke(value);
                else if (value < _currentHealth) HealthDecreasedEvent?.Invoke(value);
                if(value < 0) _currentHealth = 0;
                else if (value > MaxHealth)  _currentHealth = MaxHealth;
                else _currentHealth = value;
               
               
            }
        }
        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public void TakeDamage(int damage)
        { 
            _currentHealth -= damage;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}");
        }

        public event HealthChangedDelegate HealthChangedEvent;
        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}
