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
        public event MilitaryUnitDamageDelegate MilitaryUnitRageHitEvent;

        private int _damage;
        private int _minDamage;
        private int _maxDamage;
        Random random = new Random();

        public override int Damage
        {
            get
            {
                _damage = random.Next(_minDamage, _maxDamage);
                if (Health < MaxHealth * 0.5)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("*Рейдж мод активатион, тебя убиватион*");
                    MilitaryUnitRageHitEvent.Invoke(Name, _damage * 2);
                    Console.ResetColor();

                    return _damage * 2;
                }
                else
                {
                    MilitaryUnitRageHitEvent.Invoke(Name, _damage);
                    return _damage;
                }
            }
        }

        public Berserk(string name, int health, int defense, int minDamage, int maxDamage) : base(name, health, defense, minDamage, maxDamage)
        {
            _maxDamage = maxDamage;
            _minDamage = minDamage;
        }
    }
}
