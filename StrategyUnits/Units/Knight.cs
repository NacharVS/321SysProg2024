using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Knight : MagicUnit
    {
        public Knight(int health, string? name, int armor, int mana, int minDamage, int maxDamage) : base(health, name, armor, mana, minDamage, maxDamage) 
        {
            Heal = 5;
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
            Console.WriteLine($"{Name} cured seb by 5 points");
        }
    }
}
