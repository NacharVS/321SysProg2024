namespace StrategyUnits
{
    internal class Unit
    {
        private string? _name;
        public int MaxHealth { get; set; }
        public delegate void HealthChangedDelegate(string? name, double health, double difference, double maxHealth);
        public Unit(int health, string? name, double protection)
        {
            _health = health;
            _name = name;
            MaxHealth = health;
            _protection = protection;
        }
        private double _protection;
        public virtual double Protection
        {
            get { return _protection; }
            set { _protection = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        private double _health;
        public virtual double Health
        {
            get => _health;
            set
            {
                double previousHealth = _health;

                if (value <= 0)
                {
                    _health = 0;
                }
                else
                {
                    if (value > MaxHealth)
                        _health = MaxHealth;
                    else
                        _health = value;
                }
                if (value <= previousHealth)
                {
                    HealthDecreasedEvent.Invoke(Name, _health, (previousHealth - value), MaxHealth);
                }
                else if (value > previousHealth)
                {
                    HealthIncreasedEvent.Invoke(Name, _health, value - previousHealth, MaxHealth);
                }
            }
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}/{MaxHealth}");
        }
        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}
