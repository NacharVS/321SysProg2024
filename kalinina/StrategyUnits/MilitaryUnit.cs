using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class MilitaryUnit : unit
    {
        private int _minDamage;
        private int _maxDamage;

        public MilitaryUnit(int health, string? name, int min, int max) : base(health, name)
        {
            _minDamage = min;
            _maxDamage = max;
        }

        public int MaxDamage
        {
            get { return _maxDamage; }
            set { _maxDamage = value; }
        }


        public int MinDamage
        {
            get { return _minDamage; }
            set { _minDamage = value; }
        }

        public virtual void Attach()
        {
            Random rnd = new Random();
           int value= rnd.Next(value>MinDamage | value<MaxDamage);
            Console.WriteLine(value);
            
        }



    }
}
