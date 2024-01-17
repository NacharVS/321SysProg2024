using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker: MilitaryUnit
    {
        public Berserker() : base(60, "Footman",2, 10,23)
        {

        }

        public override void Attack(Unit unit)
        {
            Console.Write("Берсерк нанес топором ");
            base.Attack(unit);
        }
    }
}
