using StrategyUnits.Interface;

namespace StrategyUnits.Units
{
    internal class Barbarian : Unit, IBattleUnit
    {
        private int _baseDamage;
        private int _currentDamage;

        public Barbarian(string name, int health, int damage) : base(health, name)
        {
            _baseDamage = damage;
            _currentDamage = damage;
            Damage = _currentDamage;
        }

        public int Damage
        {
            get { return _currentDamage; }
            set { _baseDamage = value; }
        }
        public override void TakeDamage(int damage)
        {
            base.TakeDamage(damage);
            if (Health <= MaxHealth / 2)
            {
                _currentDamage = (_baseDamage * 2);
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.WriteLine($"{Name}'s damage up to {_currentDamage}.");
                Console.ResetColor();
            }
            else
            {
                _currentDamage = _baseDamage;
                Console.WriteLine($"{Name}'s damage in base value {_currentDamage}.");
            }
        }
        public void Attack(IHealthControll unit)
        {
            unit.TakeDamage(Damage);
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine($"{Name} attacked {unit.Name} and made {Damage} damage. \n{unit.Name.ToUpper()} has {unit.Health} HP.");
            Console.ResetColor();
        }
    }
}
