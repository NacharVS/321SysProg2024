using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Wizard : MagicUnit
    {
       
        public Wizard() : base (30, "Wizard",0, 5, 60, 1,2)
        {
            

        }
        public override void InflictTreat(Unit unit)
        {
            while(unit.Health < unit.MaxHealth && (Energy/2)>0)
            { 
               
                    unit.Health += Treat;
                    Energy -= 2;
            }
            
        }

        public override void Attack(Unit unit)
        {
            Console.Write("Волшебник нанес посохом ");
            base.Attack(unit);
        }

    }
}
