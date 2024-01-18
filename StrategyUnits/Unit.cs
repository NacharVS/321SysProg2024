namespace StrategyUnits
{
    internal class Unit
    {
        private int _health;
        private string _name;
        private int _maxHealth;
        private int _defense;
        private int _maxdefense;

        public Unit(string name, int health, int defense)
        {
            _health = health;
            _name = name;
            _maxHealth = _health;
            _defense = defense;
            _maxdefense = defense;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int MaxDefesne
        {
            get { return _maxdefense; }

        }
        public int MaxHealth
        {
            get { return _maxHealth; }
            
        }
        public int Defense
        {
            get { return _defense; }
            set
            {
                if (value < 0) { _defense = 0; }
                else { _defense = value; }
            }
        }

        public int Health 
        { 
            get => _health; 
            set
            {
                if(value < 0) { _health = 0;}
                else { _health = value; }
            } 
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health} ");
            
        }

        public void TakeDamage(int damage)
        {
            if (_defense <= 0) { _health -= damage;}
            
        }
    }
}
