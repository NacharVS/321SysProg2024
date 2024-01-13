namespace StrategyUnits
{
    internal class Unit
    {
        private int _currentHealth;
        private int _currentStamina;
        private string? _name;
        private int _stamina;
        private int _health;

        public Unit(int health, string? name, int stamina)
        {
            _currentHealth = health;
            _name = name;
            _currentStamina = stamina;
            _health = _currentHealth;
            _stamina = _currentStamina;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Health
        {
            get
            {
                 return _currentHealth;
            }
            set {
                if (value < 0)
                    _currentHealth = 0;
                else
                    _currentHealth = value;
            }

        }
        public int Stamina
        {
            get { return _currentStamina; }
            set
            {
                if (value > _stamina)
                    _currentStamina = _stamina;
                else
                    _currentStamina = value;
            }

        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_currentHealth} Stamina: {_currentStamina}");
        }

        public int GetMaxHP()
        {
            return _health;
        }

    }
}
