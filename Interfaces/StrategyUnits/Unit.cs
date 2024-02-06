using StrategyUnits.Interfaces;

namespace StrategyUnits
{
    internal class Unit : IMove, IGeneralInformation, IHealth
    {
        private string? _name;
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
        public double MaxHealth { get; set; }
        public Unit(string? name, double currentHealth, double maxHealth)
        {
            Name = name;
            _health = currentHealth;
            MaxHealth = maxHealth;
        }
        public void Move()
        {
            Console.WriteLine("Is moving");
        }
        public virtual void DecreaseHealth(double damage)
        {
            Health -= damage;
        }
        public void IncreseHealth(double health)
        {
            Health += health;
        }
        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}/{MaxHealth}");
        }
        public event IHealth.HealthChangedDelegate HealthIncreasedEvent;
        public event IHealth.HealthChangedDelegate HealthDecreasedEvent;
    }
}
