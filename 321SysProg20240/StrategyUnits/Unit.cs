namespace StrategyUnits
{
    public delegate void ChageHealth(int health, string? name, int maxHealth);

    internal class Unit : IHealthController
    {
        private int _health;
        private string? _name;
        private int _maxHealth;

        public Unit(int health, string? name)
        {
            _health = health;
            _name = name;
            _maxHealth = health;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int MaxHealth { get => _maxHealth; }

        public virtual int Health
        {
            get => _health;
            set
            {
                if (value < 0)
                { value = 0; }

                if (_health < value)

                    ChageIncreaseHealth(value, _name, _maxHealth);
                else
                    ChageDecreaseHealth(value, _name, _maxHealth);

                if (_health == 0)
                    return;

                if (value <= 0) //на вывод инфы кто умер
                {
                    _health = 0;
                    Console.WriteLine($"умер Юнит:{_name}");
                }
                else if (value >= _maxHealth)
                {
                    _health = _maxHealth;
                }
                else
                {
                    _health = value;
                }
            }
        }

        public virtual void ShowInfo()
        {
            Console.Write($"Unit: {_name}  Health: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{_health}/{_maxHealth}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public virtual void TakeStory() { }

        public virtual void TakeDamage(int Damage)
        {
            Health -= Damage;
        }

        public event ChageHealth ChageIncreaseHealth;
        public event ChageHealth ChageDecreaseHealth;
    }
}
