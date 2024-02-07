using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin : Unit, IMagicAttack, IMagicUnit, IAttack, ISuperPower, IArmoredUnit
    {
        public Palladin(string? name, double currentHealth, double maxHealth, int manna, int maxManna, double magicDamage, double protection) : base(name, currentHealth, maxHealth)
        {
            ActivateSuperPower = false;
            Manna = manna;
            MaxManna = maxManna;
            MagicDamage = magicDamage;
            Protection = protection;
        }

        public double MagicDamage { get; set; }
        public int Manna { get; set; }
        public int MaxManna { get; set; }
        public double Damage { get; set; }

        public void Attack(IHealth unit)
        {
            unit.DecreaseHealth(Damage);
        }

        public void DecreaseManna(int manna)
        {
            Manna -= manna;
        }

        public void IncreaseManna(int manna)
        {
            Manna += manna;
        }
        public override void DecreaseHealth(double damage)
        {
            if (Protection > 0)
            {
                double actualDamage = damage - Protection;
                base.DecreaseHealth(actualDamage);
            }
            else
            {
                base.DecreaseHealth(damage);
            }
        }
        public void MagicAttack(IHealth unit)
        {
            DecreaseManna(2);
            unit.DecreaseHealth(MagicDamage);
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

                if (base.Health < MaxHealth * 0.5 && !ActivateSuperPower)
                {
                    ActivateSuperPower = true;
                    Protection *= 1.5;
                    Console.WriteLine($"{Name} активировал супер силу, броня в два раза больше!");
                }
                else if (base.Health >= MaxHealth * 0.5 && ActivateSuperPower)
                {
                    ActivateSuperPower = false;
                    Protection /= 1.5;
                    Console.WriteLine($"{Name} супер сила закончилась!");
                }
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name}\nЗдоровье: {Health}/{MaxHealth}\nУрон: {Damage}\nСупер сила: {ActivateSuperPower}\nМана: {Manna}/{MaxManna}\n Магический урон: {MagicDamage}");
        }
        public bool ActivateSuperPower { get; set; }
        public double Protection { get; set; }
    }
}
