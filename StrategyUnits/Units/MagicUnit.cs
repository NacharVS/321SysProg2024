using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class MagicUnit : HostileUnit
    {
        public int Mana { get; set; }
        public int MaxMana { get; private set; }

        public MagicUnit(string name, int health, int damage, int mana) : base(name, health, damage)
        {
            Mana = mana;
            MaxMana = mana;
        }

        public override void ShowInfo() =>
            Console.WriteLine($"{Name} | {Health}/{MaxHealth} HP | {Mana}/{MaxMana} MP");
    }
}
