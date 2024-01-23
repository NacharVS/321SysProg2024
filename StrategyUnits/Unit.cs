namespace StrategyUnits
{
    public delegate void HealthChangedDelegate(int health);
    internal class Unit
    {
        private int _currentHealth;
        private int _currentStamina;
        private int _currentArmor;
        private string? _name;
        private int _maxStamina;
        private int _maxHealth;
        private int _maxArmor;

        public Unit(int health, string? name, int stamina, int armor)
        {
            _currentHealth = health;
            _name = name;
            _currentStamina = stamina;
            _currentArmor = armor;
            _maxHealth = _currentHealth;
            _maxStamina = _currentStamina;
            _maxArmor = _currentArmor;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public virtual int Health
        {
            get { return _currentHealth; }
            set
            {
                if (_currentHealth - value < 0)
                    HealthIncreasedEvent?.Invoke(_currentHealth);
                else
                    HealthDecreasedEvent?.Invoke(_currentHealth);

                if (value > _maxHealth)
                    _currentHealth = _maxHealth;
                else if (value < 0)
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
                if (value > _maxStamina)
                    _currentStamina = _maxStamina;
                else if (value < 0)
                    _currentStamina = 0;
                else
                    _currentStamina = value;
            }
        }
        public int Armor
        {
            get { return _currentArmor; }
            set
            {
                if (value < 0)
                    _currentArmor = 0;
                else
                    _currentArmor = value;
            }
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"Unit: {_name} Health: {_currentHealth}/{_maxHealth}  Stamina: {_currentStamina} ");
            Console.ResetColor();
        }

        public int GetMaxHP()
        {
            return _maxHealth;
        }
        public int GetMaxArmor()
        {
            return _maxArmor;
        }


        public virtual void TakeDamage(MilliUnit attackingUnit)
        {
            if (attackingUnit.Damage >= Armor)
            {
                int startedAttack = attackingUnit.Damage;
                attackingUnit.Damage -= Armor;
                Armor = 0;
                Health -= attackingUnit.Damage;
                HealthDecreasedEvent += DecMethod;
                Console.WriteLine($"{Name}`s amrmor down. He get {startedAttack} damage. His helath: {Health}.\nAttached: {attackingUnit.Name}.");
            }
            else
            {
                Armor -= attackingUnit.Damage;
                Console.WriteLine($"{Name} amrom survived. Now unit has: {Armor} armor.\nAttached: {attackingUnit.Name}.");
            }
        }

        public void TakeHeal(MagicUnit healingUnit)
        {
            HealthIncreasedEvent += IncMethod;
            for (int i = Stamina; i > 0; i -= 2)
            {
                Health += healingUnit.Heal;
                Stamina = i;
                if (Health >= _maxHealth)
                {
                    Stamina -= 2;
                    Console.WriteLine($"{healingUnit.Name} healed {Name} on {healingUnit.Heal} HP.");
                    break;
                }
                Console.WriteLine($"{healingUnit.Name} healed {Name} on {healingUnit.Heal} HP.");
            }
        }

        void IncMethod(int health)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Health UP");
            Console.ResetColor();
        }
        void DecMethod(int health)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Health Down");
            Console.ResetColor();
        }

        public event HealthChangedDelegate HealthIncreasedEvent;
        public event HealthChangedDelegate HealthDecreasedEvent;
    }
}
