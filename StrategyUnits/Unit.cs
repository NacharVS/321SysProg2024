namespace StrategyUnits
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
            get => _health;
            set
            {
                //HealthChangedEvent?.Invoke(_currentHealth);
                if (value > _health) HealthIncreasedEvent?.Invoke(value);
                else if (value < _health) HealthDecreasedEvent?.Invoke(value);
                if (value < 0) _health = 0;
                else if (value > MaxHealth) _health = MaxHealth;
                else _health = value;


            }
        }
        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public void TakeDamage(int damage)
        {
            _health -= damage;
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
