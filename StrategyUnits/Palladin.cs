using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {
        private int selfHealth = 10;

        public Palladin(int health, string? name, int stamina, int defense) : base(health, name, stamina, defense)
        {
            Heal = 1;
            Damage = 5;
        }
        public void SelfHeal()
        {
            this.Health += selfHealth;
            Stamina -= 5;
        }
    }
}
