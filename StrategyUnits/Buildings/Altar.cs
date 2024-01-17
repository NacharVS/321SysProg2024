using StrategyUnits.MilitaryUnits.MagicUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Buildings
{
    internal class Altar : Building
    {
        public Altar(string name) : base(name, 1000)
        {

        }

        public void RegenMana(MagicUnit magicUnit)
        {
            while (magicUnit.Mana < magicUnit.MaxMana)
            {
                magicUnit.Mana += 2;
                //Thread.Sleep(millisecondsTimeout: 100);
                Console.WriteLine($"+2 манки для {magicUnit.Name} | {magicUnit.Mana}/{magicUnit.MaxMana}");
            }
        }
    }
}
