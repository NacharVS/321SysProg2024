using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.MilitaryUnits
{
    //public delegate void ActivateRageDeledate(int damage);
    internal class Berserk : Footman
    {
        public event MilitaryUnitChangedEventHandler RageEvent;

        private int _damage;
        private int _minDamage;
        private int _maxDamage;

        public Berserk(string name, int health, int defense, int minDamage, int maxDamage) : base(name, health, defense, minDamage, maxDamage)
        {
            _maxDamage = maxDamage;
            _minDamage = minDamage;
        }

        // hp < 50% => dmg x2
        public void Rage()
        {
            Console.WriteLine("активатион");
        }
    }
}
