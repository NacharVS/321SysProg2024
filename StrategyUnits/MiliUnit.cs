using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilliUnit : Unit
    {
        public event HealthChangedDelegate LowHealthEvent;
        private int _damage;
        private int _minDamage = 25;
        private int _maxDamage = 25;
        Random _random = new Random();

        public MilliUnit(int health, string? name, int stamina, int defense) : base(health, name, stamina, defense)
        {
            _damage = SetRandomDamage();
        }

        public virtual int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public override void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine($"This millitary unit {Name} Health: {Health}/{GetMaxHP()}. {Damage}");
            Console.ResetColor();
        }
        private int SetRandomDamage()
        {
            return _random.Next(_minDamage, _maxDamage);
        }
    }
}