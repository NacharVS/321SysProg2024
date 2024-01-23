using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Healer : MagicUnit
    {
        public Healer(int health, string? name, int stamina, int defense) : base(health, name, stamina, defense)
        {
            Heal = 5;
            Damage = 1;
        }
    }
}
