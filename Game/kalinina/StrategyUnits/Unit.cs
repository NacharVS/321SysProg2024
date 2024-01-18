using System.Security.Cryptography.X509Certificates;

namespace StrategyUnits
{
    internal class unit
    {
        public delegate void HealthChangedDelegate(int health);
        private int _currentHealth;
        private string? _name;
        public int MaxHealth { get; private set; }
        public int _defense;
        
        public unit (int health, string? name, int defense)
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
                {
                    if (value > MaxHealth)
                    {
                        _currentHealth = MaxHealth;
                    }
                    else
                    {
                        if (value > _currentHealth) HealthIncreasedEvent?.Invoke(value);
                        else if (value < _currentHealth) HealthDecreasedEvent?.Invoke(value);
                        _currentHealth = value;
                    }
                }             
            }
        }
        public int Defense
        {
            get; set;
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public void TakeDamage(int damage)
        {
            Health -= damage - Defense;
            if (damage > 0)
            {
                this.Health -= damage;
                if (Health<0)
                {
                    this.Health = 0;
                }
            }
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_currentHealth} / {MaxHealth}");
        }
        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}

