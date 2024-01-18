namespace StrategyUnits
{
    public delegate void HealthChanged(int health);
    public delegate void HealthIncrease(int health);
    public delegate void HealthDecrease(int health);
    internal class Unit
    {
        private int _currentHealth;
        private string? _name;
        public int Defence { get; set; }
        public int MaxHealth { get; private set; }

        public Unit(int health, string? name, int defence)
        {
            _currentHealth = health;
            _name = name;
            MaxHealth = health;
            Defence = defence;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public void HealDamage(int heal)
        {
            HealthIncreaseEvent?.Invoke(_currentHealth);
        }
        public void TakeDamage(int damage)
        {
            HealthDecreaseEvent?.Invoke(_currentHealth);

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
                HealthChangedEvent?.Invoke(_currentHealth);
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
        public event HealthChanged HealthChangedEvent;
        public event HealthIncrease HealthIncreaseEvent;
        public event HealthDecrease HealthDecreaseEvent;
    }
}
