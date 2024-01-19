using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Knight : MagicUnit
    {
        public Knight(int health, string? name, int armor, int minDamage, int maxDamage, int mana) : base(health, name, armor, minDamage, maxDamage, mana)
        {
            _heal = 5;
        }

        private int _heal;
        public int Heal
        {
            get { return _heal; }
            set { _heal = value; }
        }

        public void SelfHeal()
        {
            if (Mana > 5)
            {
                Health += _heal;
                Mana -= _heal;
            }
            Console.WriteLine($"Юнит {Name} вылечил себя на 5 единиц, затратив 5 маны");
        }
    }
}
