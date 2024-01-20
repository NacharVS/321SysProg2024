using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit: Unit
    {
        public int _maxdamage;
        public int _mindamage;
        
        
        public MilitaryUnit(int health, string? name,int armor, int mindamage, int maxdamage) : base(health, name, armor)
        {
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
        }


    }
}
