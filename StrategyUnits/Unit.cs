namespace StrategyUnits
{
    internal class Unit
    {

        public delegate void HealthChangedDelegate(int health);
        private int _currentHealth;
        private int _currentStamina;
        private string? _name;
        private int _stamina;
        private int _health;
        private int _defense;

        public Unit(int health, string? name, int stamina, int defense)
        {
            _currentHealth = health;
            _name = name;
            _currentStamina = stamina;
            _health = _currentHealth;
            _stamina = _currentStamina;
            _defense = defense;
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
            set
            {
                if (_currentHealth - value < 0)
                    HealthIncreasedEvent?.Invoke(_currentHealth);
                else
                    HealthDecreasedEvent?.Invoke(_currentHealth);
                if (value < 0)
                    _currentHealth = 0;
                else
                    _currentHealth = value;
                if (value > _health)
                    _currentHealth = _health;
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
        public int Defense
        {
            get { return _defense; }
            set
            {
                if (value < 0)
                    _defense = 0;
                else
                    _defense = value;
            }
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_currentHealth} Stamina: {_currentStamina}");
        }
        public int GetMaxHP()
        {
            return _health;
        }
        public void TakeDamage(MilliUnit attackingUnit)
        {
            if (attackingUnit.Damage >= Defense)
            {
                attackingUnit.Damage -= Defense;
                Defense = 0;
                Health -= attackingUnit.Damage;
                HealthDecreasedEvent += DecMethod;
                Console.WriteLine($"{Name}`s amrmor down. He get {attackingUnit.Damage} damage. His helath: {Health}.\nAttached: {attackingUnit.Name}.");
            }
            else
            {
                Defense -= attackingUnit.Damage;
                Console.WriteLine($"{Name} amrom survived. Now unit have: {Defense} armor.\nAttached: {attackingUnit.Name}.");
            }
        }
        public void TakeHeal(MagicUnit healingUnit)
        {
            HealthIncreasedEvent += IncMethod;
            for (int i = Stamina; i > 0; i -= 2)
            {
                Health += healingUnit.Heal;
                Stamina = i;
                if (Health >= _health)
                {
                    Stamina -= 2;
                    Console.WriteLine($"{healingUnit.Name} healed {Name} on {healingUnit.Heal} HP.");
                    break;
                }
                Console.WriteLine($"{healingUnit.Name} healed {Name} on {healingUnit.Heal} HP.");
            }
        }

    }
}
