using static StrategyUnits.Berserk;

namespace StrategyUnits
{ 
    internal class Unit
    {
        private int _currentHealth;
        private string? _name;
        public int MaxHealth { get; private set; }
        public int Armor { get; set; }


        public Unit(int health, string? name, int armor)
        {
            _currentHealth = health;
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
                //if (value > _currentHealth) HealthIncreasedEvent?.Invoke(value);
                //else if (value < _currentHealth) HealthDecreasedEvent?.Invoke(value);
                if (value < 0) _currentHealth = 0;
                else if (value > MaxHealth)  _currentHealth = MaxHealth;
                else _currentHealth = value;      
            }
        }
        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void TakeDamage(int damage, Unit? unit)
        { 
            _currentHealth -= damage;
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_currentHealth}");
        }

        //public event HealthChangedDelegate HealthIncreasedEvent;
        //public event HealthChangedDelegate HealthDecreasedEvent;

    }
}
