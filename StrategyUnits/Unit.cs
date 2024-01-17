namespace StrategyUnits
{
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

        public int Health 
        { 
            get => _health;
            set
            { 
                if (value <= 0)
                {
                     _health = 0;
                }
                else  if (value >= MaxHealth)
                {
                    _health = MaxHealth;
                }
                else
                {
                    _health = value;
                }
            }
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}/{_maxhealth}");
        }
       

    }
}
