using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin: MagicUnit
    {
        public Paladin(): base(100,"Paladin",10,5, 30, 10,20) 
        { 
        }

        public override void  InflictTreat( Unit unit) 
        {
            if ((Energy / 2) > 0)
            {
                unit.Health += Treat;
                Energy -= 2;
            }
        }

        public override void Attack(Unit unit)
        {
            Console.Write("Паладин нанес святым мечом ");
            base.Attack(unit);
        }
    }
}
