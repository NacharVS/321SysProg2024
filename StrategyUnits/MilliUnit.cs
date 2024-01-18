namespace StrategyUnits
{
    internal class MilliUnit : Unit
    {
        private int _damage;
        private int _minDamage = 31;
        private int _maxDamage = 31;
        Random _random = new Random();

        public MilliUnit(int health, string? name, int stamina, int defense) : base(health, name, stamina, defense)
        {
            _damage = SetRandomDamage();
        }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public override void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"This millitary unit {Name}. {Damage}");
            Console.ResetColor();
        }
        private int SetRandomDamage()
        {
            return _random.Next(_minDamage, _maxDamage);
        }
    }
}
