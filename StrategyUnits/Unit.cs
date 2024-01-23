namespace StrategyUnits
{
    public delegate void HealthChangedDelegate(string name, int health, int maxHealth);
    internal class Unit
    {
        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
        public event HealthChangedDelegate HealthNoChangeEvent;

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
                {
                    HealthNoChangeEvent?.Invoke(Name, 0, MaxHealth);
                    _health = 0;
                }
                else if (value > MaxHealth)
                {
                    HealthNoChangeEvent?.Invoke(Name, MaxHealth, MaxHealth);
                    _health = MaxHealth;
                }
                else if (value == _health)
                {
                    // заглушка, чтобы выводило при нулевом уроне
                    HealthNoChangeEvent?.Invoke(Name, MaxHealth, MaxHealth); 
                }
                else
                {
                    if (value < _health)
                        HealthDecreasedEvent?.Invoke(Name, value, MaxHealth);
                    else
                        HealthIncreasedEvent?.Invoke(Name, value, MaxHealth);

                    _health = value;
                }
            }
        }
        public virtual int Defense { get; private set; }
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
           => Console.WriteLine($"Юнит: {_name} | Здоровье: {_health}/{MaxHealth}\n");
    }
}
