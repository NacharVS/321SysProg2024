using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.MilitaryUnits
{
    public delegate void MilitaryUnitDamageDelegate(string name, int damage);

    internal class MilitaryUnit : Unit
    {
        public event MilitaryUnitDamageDelegate MilitaryUnitHitEvent;
        Random random = new Random();

        private int _damage;
        public virtual int Damage
        {
            get
            {
                _damage = random.Next(_minDamage, _maxDamage);
                MilitaryUnitHitEvent.Invoke(Name, _damage);
                return _damage;
            }
            private set { }
        }

        private int _minDamage;
        private int _maxDamage;

        public MilitaryUnit(string name, int health, int defense, int minDamage, int maxDamage)
            : base(name, health, defense)
        {
            _minDamage = minDamage;
            _maxDamage = maxDamage;
        }
        public override void ShowInfo()
           => Console.WriteLine($"Юнит: {Name} | Здоровье: {Health}/{MaxHealth} | Броня: {Defense}\n");

        public virtual void InflictDamage(Unit unit)
        {
            int damage;
            if (Health > 0)
            {
                damage = Damage - unit.Defense;
                if (damage >= 0)
                {
                    unit.Health -= damage;
                }
                else
                {
                    unit.Health = unit.Health;
                }
            }
            else
            {
                Console.WriteLine("Я слишком умер, чтобы бить\n");
            }
        }
    }
}
