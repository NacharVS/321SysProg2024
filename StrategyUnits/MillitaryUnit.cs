using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MillitaryUnit : Unit
    {
        private int _minDamage;

        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }

        private int _maxDamage;

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }
        public MillitaryUnit(int health, string name, int armor, int minDamage, int maxDamage) : base(health, name, armor)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }
        public void InflictDamage(Unit unit)
        {
            Random rnd = new Random();
            int damage;
            damage = rnd.Next(MinDamage, MaxDamage) - unit.Armor;
            Console.WriteLine($"Юнит {Name} наносит удар по юниту {unit.Name}");
            if (damage <= 0) Console.WriteLine($"{unit.Name} получил удар без какого-либо урона");
            else
            {
                Console.WriteLine($"{unit.Name} получил {damage + unit.Armor} урона. (Поглощено: {unit.Armor})");
                unit.TakeDamage(damage, unit);
            }
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit:{Name} Health:{Health}/{MaxHealth} Damage:{MinDamage}-{MaxDamage}");
        }
    }
}
