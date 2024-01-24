namespace StrategyUnits.Units
{
    public delegate void HealthChangedDelegate(int health);
    internal class Unit
    {
        private int _currentHealth;
        private string? _name;
        private int _armor;
        public int MaxHealth { get; private set; }
        public int Armor
        {
            get { return _armor; }
            set { _armor = value; }
        }

        public Unit(int health, string? name, int armor)
        {
            _name = name;
            _currentHealth = health;
            MaxHealth = health;
            _armor = armor;
        }
       public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual int Health
        {
            get => _currentHealth;
            set
            {
                if (value <= 0)               
                    _currentHealth = 0;
                else if (_currentHealth > MaxHealth)               
                    _currentHealth = MaxHealth;
                else
                    _currentHealth = value;
            }
        }
        public int Defence
        {
            get { return _armor; }
            set { _armor = value; }
        }

        public void Move() => Console.WriteLine("He's moving");
        public virtual void TakeDamage(int damage, Unit? unit) => Health -= damage;
        public virtual void ShowInfo() => Console.WriteLine($"Unit: {Name} Health: {Health}/{MaxHealth} Armor: {Armor}");

        public event HealthChangedDelegate HealthChangedEvent;

        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}
 