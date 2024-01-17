using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.MilitaryUnits
{
    public delegate void MilitaryUnitChangedEventHandler(string attackerName,string defenderName, int damage, int defense);

    internal class MilitaryUnit : Unit
    {
        public event MilitaryUnitChangedEventHandler MilitaryUnitHitEvent;
        public event MilitaryUnitChangedEventHandler MilitaryUnitNonHitEvent;

        private int _damage;

        private int _minDamage;
        private int _maxDamage;

        public MilitaryUnit(string name, int health, int defense, int minDamage, int maxDamage) : base(name, health, defense)
        {
            _minDamage = minDamage;
            _maxDamage = maxDamage;
            Name = name;
            Health = health;
        }

        public void InflictDamage(Unit defender, Unit attacker)
        {
            Random random = new Random();
            _damage = random.Next(_minDamage, _maxDamage);

            if (defender.Defense >= _damage)
            {
                MilitaryUnitNonHitEvent.Invoke(attacker.Name, defender.Name, _damage, defender.Defense);
            }
            else
            {
                MilitaryUnitHitEvent.Invoke(attacker.Name, defender.Name, _damage, defender.Defense);

                defender.Health = defender.Health + (defender.Defense - _damage);
            }
        }
    }
}
