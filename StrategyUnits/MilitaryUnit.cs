using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit: Unit
    {
        private int _maxdamage;
        private int _mindamage;
        
        
        public MilitaryUnit(int health, string? name,int armor, int mindamage, int maxdamage) : base(health, name, armor)
        {
           _health  = health ;
             _name =name;
            _mindamage =mindamage;
            _maxdamage =maxdamage;
        }

        public int MinDamage
        {
            get { return _mindamage; } 
            set { _mindamage = value; } 
        }

        public int MaxDamage
        {
            get { return _maxdamage; }
            set { _maxdamage = value; }
        }

        public virtual void Attack(Unit unit)
        {
            if (unit.Health > 0)
            {
                int damage = new Random().Next(_mindamage, _maxdamage) - unit.Armor;
                damage = damage <= 0? 0 : damage;
                if(unit.Health < damage)
                    damage = unit.Health;
                unit.Health -= damage;
                Console.WriteLine($" {damage} урона");
            }
        }

        public void Move()
        {
            Console.WriteLine("Is moving");
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {_name} Health: {_health}/{_maxhealth}");
        }

    }
}
