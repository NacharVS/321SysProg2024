using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Archer: MilitaryUnit
    {

        public Archer() : base(60, "Footman",0, 12,20)
        {

        }

        public override void Attack(Unit unit)
        {
            Console.Write("Лучник выстрелил из лука и нанес ");
            base.Attack(unit);
        }
    }
}
