using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserk : Footman
    {
        private bool _inRage = false;

        public Berserk(int health, string? name, int stamina, int defense) : base(health, name, stamina, defense)
        {
        }

        public override void TakeDamage(MilliUnit attackingUnit)
        {
            if (attackingUnit.Damage >= Armor)
            {
                int unitDamage = Damage;
                int startedAttack = attackingUnit.Damage;
                attackingUnit.Damage -= Armor;
                Armor = 0;
                Health -= attackingUnit.Damage;
                if (Health <= GetMaxHP() / 2)
                    RageOn(unitDamage);
                else
                    RageOff(unitDamage);
                Console.WriteLine($"{Name}`s amrmor down. He get {startedAttack} damage. His helath: {Health}.\nAttached: {attackingUnit.Name}.\nUnit can contrattack with: {Damage} damage.");
            }
            else
            {
                Armor -= attackingUnit.Damage;
                Console.WriteLine($"{Name} amrom survived. Now unit have: {Armor} armor.\nAttached: {attackingUnit.Name}.");
            }
        }

        private void RageOff(int unitDamage)
        {
            if (_inRage)
            {
                Damage = unitDamage / 2;
                Console.WriteLine("Rage lost");
                _inRage = false;
            }
        }

        private void RageOn(int unitDamage)
        {
            if (_inRage == false)
            {
                _inRage = true;
                Damage *= 2;
                Console.WriteLine("RAAAGEEE!!!");
            }
            else RageOff(unitDamage);
        }
    }
}