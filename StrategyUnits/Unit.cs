namespace StrategyUnits
{
    internal class Unit
    {

        public delegate void HealthChangedDelegate(int health);
        private int _currentHealth;
        private int _currentStamina;
        private string? _name;
        private int _stamina;
        private int _health;
        private int _defense;

        public Unit(int health, string? name, int stamina, int defense)
        {
            _currentHealth = health;
            _name = name;
            _currentStamina = stamina;
            _health = _currentHealth;
            _stamina = _currentStamina;
            _defense = defense;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Health
        {
            get
            {
                return _currentHealth;
            }
            set
            {
                if (_currentHealth - value < 0)
                    HealthIncreasedEvent?.Invoke(_currentHealth);
                else
                    HealthDecreasedEvent?.Invoke(_currentHealth);
                if (value < 0)
                    _currentHealth = 0;
                else
                    _currentHealth = value;
                if (value > _health)
                    _currentHealth = _health;
                else
                    _currentHealth = value;

            }

        }
        public int Stamina
        {
            get { return _currentStamina; }
            set
            {
                if (value > _stamina)
                    _currentStamina = _stamina;
                else
                    _currentStamina = value;
            }

        }
        public int Defense
        {
            get { return _defense; }
            set
            {
                if (value < 0)
                    _defense = 0;
                else
                    _defense = value;
            }
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_currentHealth}/{_health}  Stamina: {_currentStamina} ");
        }

        public int GetMaxHP()
        {
            return _health;
        }

        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}
