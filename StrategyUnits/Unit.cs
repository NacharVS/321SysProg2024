namespace StrategyUnits
{
    
    internal class Unit
    {
        private int _health;
        private string _name;
        private int _maxHealth;
        public int _defense;
        public int _maxdefense;
        
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
        public int MaxDefense
        {
            get { return _maxdefense; }

        }
        public int MaxHealth
        {
            get { return _maxHealth; }
            
        }
        public virtual int Defense
        {
            get { return _defense; }
            set
            {
                if (value < 0) { 
                    _defense = 0;
                    
                }
                else { _defense = value; }
            }
        }

        public int Health 
        {
            get
            {
                return _health;
            }
            set
            {
                if(value <= 0) { 
                    _health = 0;
                    Console.Write($"{Name} погиб: ");
                    
                }
                else { _health = value; }
                
            } 
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health} Defense: {_defense} ");
        }

        public virtual void TakeDamage(int damage)
        {
            if (_defense <= 0) 
            { 
                this.Health -= damage;
            }
        }
    }
}
