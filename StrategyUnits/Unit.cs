namespace StrategyUnits
{
    abstract class Unit
    {
        private int _currentHealth;
        private string? _name;
        public int Defense {get; set;}
        public int MaxHealth { get; private set; }
        public delegate void HealthChangedDelegate(Unit unit);


        public Unit(int health, string? name, int defense)
        {
            _currentHealth = health;
            _name = name;
            MaxHealth = health;
            Defense = defense;
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
                Unit unit = this;
                if(value > _currentHealth)
                {
                    _currentHealth = value;
                    HealthIncreasedEvent?.Invoke(unit);
                }
                else if(value < _currentHealth)
                {
                    _currentHealth = value;
                    HealthDecreasedEvent?.Invoke(unit);
                }
                if (value < 0)
                {
                    _currentHealth = 0;
                } 
                else if (value > MaxHealth)
                {
                    _currentHealth = MaxHealth;
                } 
                else _currentHealth = value;
                    
            }
        }

        public virtual void TakeDamage(int damage, Unit unit)
        {
            Health -= damage;
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_currentHealth}/{MaxHealth}");
        }

        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}
