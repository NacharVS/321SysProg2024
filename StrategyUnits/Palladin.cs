using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {
        public Palladin(int health, string? name, int armor, int minDamage, int maxDamage, int mana) : base(health, name, armor, minDamage, maxDamage, mana)
        {

        }

        public void InflictSupport(Unit unit)
        {
            if (Mana > 5)
            {
                unit.Armor++;
                Mana -= 5;
                Console.WriteLine($"Юниту {unit.Name} была увеличена броня");
            }
            else Console.WriteLine("Маны не хватает");
        }

        public override void TakeDamage(int damage, Unit unit)
        {
            Palladin palad = (Palladin)unit;
            if (palad.Health < palad.MaxHealth / 2 && palad.Armor == 5)
            {
                palad.Armor = palad.Armor * 2;
            }
            base.TakeDamage(damage, palad);
        }
    }
}
