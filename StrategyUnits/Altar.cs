using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar : Unit
    {
        private int mannaHealing = 5;
        public Altar() : base(100, "Altar")
        {
        }

        public void MannaHealing(Healer healer) {
            healer.Manna += mannaHealing;
            Console.WriteLine($"Unit {healer.Name} + {mannaHealing} manna. Total {healer.Manna}/{healer.MaxManna}");
        }
    }
}
