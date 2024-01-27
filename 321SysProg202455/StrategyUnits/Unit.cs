namespace StrategyUnits
{
    public delegate void ChageHealth(int health, int maxhealth, string? name, int armor);

    internal class Unit
    {


        public int _health;
        public string? _name;
        private int _armor;


        public int _maxhealth { get; private set; }


        public Unit(int health, string? name, int armor)
        {
            _health = health;
            _name = name;
            _maxhealth = health;
            _armor = armor;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int MaxHealth
        {
            get => _maxhealth;
        }

        public int Armor
        {
            get { return _armor; }
            set { _armor = value; }
        }

        public virtual int Health
        {
            get => _health;
            set
            {
                if (_health < value)
                { ChageIncreaseHealth(value, _maxhealth, _name, _armor); }
                else
                { ChageDecreaseHealth(value, _maxhealth, _name, _armor); }

                if (value <= 0)
                {
                    _health = 0;
                    Console.WriteLine($"умер Юнит:{_name}");
                }
                else if (value >= MaxHealth)
                {
                    _health = MaxHealth;
                }
                else
                {
                    _health = value;
                }
            }
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}/{_maxhealth} Armor:{_armor}");
        }

        public void TakeDamage(int Damage)
        {
            Damage = Damage <= 0 ? 0 : Damage - Armor;
            Health -= Damage;
        }

        public event ChageHealth ChageIncreaseHealth;
        public event ChageHealth ChageDecreaseHealth;
    }
}
