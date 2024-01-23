using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Knight : Palladin
    {
        private bool _armorBuff = false;

        public Knight(int health, string? name, int stamina, int defense) : base(health, name, stamina, defense)
        {
            Heal = 1;
            Damage = 25;
        }


        public override void TakeDamage(MilliUnit attackingUnit)
        {
            if (attackingUnit.Damage >= Armor)
            {
                int startedAttack = attackingUnit.Damage;
                attackingUnit.Damage -= Armor;
                Armor = 0;
                Health -= attackingUnit.Damage;
                if (Health <= GetMaxHP() / 2)
                    ArmorBuff();
                Console.WriteLine($"Knight take damage from {attackingUnit.Name}. His health {Health}/{GetMaxHP()}.\nHe can contrattack: {Damage}.");
            }
            else
            {
                Armor -= attackingUnit.Damage;
                Console.WriteLine($"Knight take damage from {attackingUnit.Name}. His armor: {Armor}.\nHe can contrattack: {Damage}.");
            }
        }

        private void ArmorBuff()
        {
            if (_armorBuff == false)
            {
                _armorBuff = true;
                Armor += GetMaxArmor() / 2;
                Console.WriteLine($"Armor buff. Unit {Armor}.");
            }
            else
                Console.WriteLine("Perk has already worked");
        }

    }
}
