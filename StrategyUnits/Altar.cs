using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar : Build
    {
        public Altar() : base(1000, "Altar")
        {

        }

        public void RecoverMana(MagicUnit unit)
        {
            unit.Mana = unit.MaxMana;
            Console.WriteLine($"Юниту {unit.Name} полностью восстановлена мана");
        }
    }
}
