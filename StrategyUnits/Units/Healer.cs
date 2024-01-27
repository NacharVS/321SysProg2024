using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Units
{
    internal class Healer : MagicUnit, IHealContol
    {
        public Healer(string name, int health, int damage, int mana) : base(name, health, damage, mana)
        {

        }

        public void Heal(IHealthControl unit)
        {
            while (Mana >= 2)
            {
                if (unit.Health == unit.MaxHealth)
                    return;

                Console.WriteLine($"{Name} хилит");
                Mana -= 2;

                unit.TakeHeal();
            }
        }
    }
}
