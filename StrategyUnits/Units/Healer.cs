using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Healer : HostileUnit, IHealContol
    {
        public int Mana { get; set; }
        public int MaxMana { get; private set; }
        
        public Healer(string name, int health, int damage, int mana) : base(name, health, damage)
        {
            Mana = mana;
            MaxMana = mana;
        }

        public override void ShowInfo() =>
            Console.WriteLine($"{Name} | {Health}/{MaxHealth} HP | {Mana}/{MaxMana} MP");
        public void Heal(IHealthControl unit)
        {
            Console.WriteLine($"{Name} хилит");
            while (Mana >= 2)
            {
                Mana -= 2;

                unit.TakeHeal();
            }
        }
    }
}
