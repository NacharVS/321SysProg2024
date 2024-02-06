using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {
        public Palladin(int health, string? name, double protection, double damage, int manna, int maxManna) : base(health, name, protection, damage, manna, maxManna)
        {
        }

        public bool HolyArmor { get; set; }
        public void MagicHit(Unit unit)
        {
            if (Manna > MagicDamage)
            {
                if (unit.Protection > MagicDamage)
                {
                    unit.Health -= 0;
                    this.Manna -= this.MagicDamage;
                }
                else
                {
                    unit.Health -= this.MagicDamage - unit.Protection;
                    this.Manna -= this.MagicDamage;
                }
            }
            else if (MagicDamage > 0)
            {
                unit.Health -= this.Manna;
                this.Manna = 0;
            }
            else
            {
                Console.WriteLine(this.Name + " manna 0");
            }
        }
        public override double Health
        {
            get => base.Health;
            set
            {
                double previousHealth = base.Health;

                if (value <= 0)
                {
                    base.Health = 0;
                }
                else
                {
                    if (value > MaxHealth)
                        base.Health = MaxHealth;
                    else
                        base.Health = value;
                }

                if (base.Health < MaxHealth * 0.5 && !HolyArmor)
                {
                    HolyArmor = true;
                    Protection *= 1.5;
                    Console.WriteLine($"{Name} активировал Святой щит!");
                }
                else if (base.Health >= MaxHealth * 0.5 && HolyArmor)
                {
                    HolyArmor = false;
                    Protection /= 1.5;
                    Console.WriteLine($"{Name} деактивировал Святой щит!");
                }
            }

        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name}\nЗдоровье: {Health}/{MaxHealth}\nУрон: {Damage}\nСупер сила: {HolyArmor}\nМана: {Manna}/{MaxManna}\n Магический урон: {MagicDamage}");
        }
    }
}
