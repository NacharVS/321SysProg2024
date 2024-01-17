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
        public Palladin() : base(100, "Palladin", 5,  10, 5, 10)
        {
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Паладин{Health}/{MaxHealth}");
        }
    }
}
