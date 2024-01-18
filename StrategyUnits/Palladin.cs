using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin : magicUnit
    {
        public Palladin(int health, string? name, int defence, int mana, int min_damage, int max_damage) : base(health, name, defence, mana, min_damage, max_damage)
        {
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Паладин{Health}/{MaxHealth}");
        }
    }
}
