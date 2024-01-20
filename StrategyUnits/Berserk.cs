using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserk : Footman
    {
        
        public Berserk(int health, string name, int armor, int mindamage, int maxdamage) 
            : base(health, name, armor, mindamage, maxdamage)
        {
            Rage = false;
        }

        public bool Rage { get; set; }

        public override int Health
        {
            get { return base.Health; }
            set
            {
                base.Health = value;
                if (value <= MaxHealth / 2 && !Rage)
                {
                    Rage = true;
                    MaxDamage += MinDamage;
                    MinDamage *= 2;
                    Console.WriteLine("Берсерк впал в ярость!");
                }
                else if (value > MaxHealth / 2 && Rage)
                {
                    MinDamage /= 2;
                    MaxDamage -= MinDamage;
                    Rage = false;
                    Console.WriteLine("Берсерк успокоился");
                }

            }

        }

        public override void Attack(Unit unit)
        {
            int damage = new Random().Next(MinDamage, MaxDamage);
            Console.WriteLine($"Берсерк нанесн ударом топора {damage} урона Юниту: {unit.Name}");
            unit.TakeDamage(damage);
        }

    }
}
