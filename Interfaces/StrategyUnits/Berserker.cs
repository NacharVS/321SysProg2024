using StrategyUnits.Interfaces;

namespace StrategyUnits
{
    internal class Berserker : Footman, IArmoredUnit, ISuperPower
    {
        public double Protection { get; set; }
        public bool ActivateSuperPower { get; set; }

        public Berserker(string? name, double currentHealth, double maxHealth, double damage, double protection) : base(name, currentHealth, maxHealth, damage)
        {
            Protection = protection;
            ActivateSuperPower = false;
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
                    Damage *= 1.5;
                    Console.WriteLine($"{Name} активировал супер силу, урон стал в два раза больше!");
                }
                else if (base.Health >= MaxHealth * 0.5 && ActivateSuperPower)
                {
                    ActivateSuperPower = false;
                    Damage /= 1.5;
                }
            }
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
        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name}\nЗдоровье: {Health}/{MaxHealth}\nУрон: {Damage}\nСупер сила: {ActivateSuperPower}");
        }
    }
} 
