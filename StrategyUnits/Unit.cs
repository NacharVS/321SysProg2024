namespace StrategyUnits
{
    public delegate void HealthChangedDelegate(int health);
    internal class Unit
    {
        private int _health;
        private string? _name;
        public virtual string Name
        {
            get { return _name == null ? "" : _name; }
            set { _name = value; }
        }

        public virtual int MaxHealth { get; set; }
        public virtual int Defense { get; set; }
        public virtual int Health
        {
            get => _health;
            set
            {
                if (value < 0)
                    _health = 0;
                else if (value > MaxHealth)
                    _health = MaxHealth;
                else
                    _health = value;
                //HealthChangedEvent?.Invoke(_health);

                if (_health < value)
                    HealthIncreasedEvent?.Invoke(_health);
                else
                    HealthDecreasedEvent?.Invoke(_health);
            }
        }

        public Unit(string? name, int health, int defense)
        {
            _health = health;
            MaxHealth = _health;
            _name = name;
            Defense = defense;
        }

        public void Move()
        {
            Console.WriteLine("Двигается");
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Юнит: {_name} | Здоровье: {_health}/{MaxHealth}");
        }

        public event HealthChangedDelegate HealthChangedEvent;

        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}
