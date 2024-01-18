using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnitsSemenov
{
    internal class Unit
    {
        private int _health;
        private string _name;
        private int _MaxHealth;
        private int _defense; // добавлено поле для защиты
        private int _damage; // добавлено поле для урона

        public Unit(int health, string name)
        {
            _health = health;
            _name = name;
            _MaxHealth = health;
            _defense = 0; // устанавливаем начальное значение защиты
            _damage = 0; // устанавливаем начальное значение урона
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int MaxHealth
        {
            get { return _MaxHealth; }
        }

        public int Health
        {
            get => _health;
            set => _health = value;
        }

        public int Defense
        {
            get { return _defense; }
            set { _defense = value; }
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public virtual void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}/{_MaxHealth} Defense: {_defense} Damage: {_damage}");
        }
    }
}
