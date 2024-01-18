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
        public Altar() : base("Altar", 50, 25)
        {
        }

        public void MannaHealing(MagicUnit magicUnit)
        {
            magicUnit.MUManna += mannaHealing;
            Console.WriteLine($"Unit {magicUnit.Name} + {mannaHealing} manna. Total {magicUnit.MUManna}/{magicUnit.MUMaxManna}");
        }
    }
}