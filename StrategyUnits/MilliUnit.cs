﻿namespace StrategyUnits
{
    internal class MilliUnit : Unit
    {
        private int _damage;
        private int _minDamage = 0;
        private int _maxDamage = 10;
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
            Console.WriteLine($"This millitary unit {Name}.");
            Console.ResetColor();
        }
        private int SetRandomDamage()
        {
            return _random.Next(_minDamage, _maxDamage);
        }
    }
}