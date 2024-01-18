using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserk : Footman
    {
        public Berserk(int health, string? name, int stamina, int defense) : base(health, name, stamina, defense)
        {
        }
        public override void TakeDamage(MilliUnit attackingUnit)
        {
            if (attackingUnit.Damage >= Defense)
            {
                attackingUnit.Damage -= Defense;
                Defense = 0;
                Health -= attackingUnit.Damage;
                ActivateRageEvent += Rage;
                Console.WriteLine($"{Name}`s amrmor down. He get {attackingUnit.Damage} damage. His helath: {Health}.\nAttached: {attackingUnit.Name}.");
            }
            else
            {
                Defense -= attackingUnit.Damage;
                Console.WriteLine($"{Name} amrom survived. Now unit has: {Defense} armor.\nAttached: {attackingUnit.Name}.");
            }
        }
        public void Rage(int health)
        {
            Console.WriteLine("SSS");
            Damage *= 2;
        }
    }
}
