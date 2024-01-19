namespace StrategyUnits
{
    public delegate void HealthChangedDelegate(string name, int health);
    internal class Unit
    {
        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;

        private int _health;
        private string? _name;

        public string Name
        {
            get { return _name == null ? "Неизвестный" : _name; }
            set { _name = value; }
        }
        public int Health
        {
            get => _health;
            set
            {
                if (value < 0)
                    _health = 0;
                else if (value > MaxHealth)
                    _health = MaxHealth;
                else
                {
                    value += Defense;

                    if (value < _health)
                        HealthDecreasedEvent?.Invoke(Name, value);
                    else
                        HealthIncreasedEvent?.Invoke(Name, value);

                    _health = value;
                }
            }
        }
        public int Defense { get; private set; }
        public int MaxHealth { get; private set; }

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
    }
}
