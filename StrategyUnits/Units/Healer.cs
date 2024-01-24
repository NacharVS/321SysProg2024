using StrategyUnits.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits.Units
{
    internal class Healer : Unit, IHealerUnit
    {
        public Healer(int health, string? name) : base(health, name)
        {
            Heal = 5;
        }

        public int Heal { get; set; }

        public void Healing(IHealthControll unit)
        {
            unit.TakeHeal(Heal);
        }
    }
}
