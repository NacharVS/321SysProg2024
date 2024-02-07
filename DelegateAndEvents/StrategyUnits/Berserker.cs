namespace StrategyUnits
{
    internal class Berserker : MilitaryUnit
    {
        public Berserker(int health, string? name, double protection, double damage) : base(health, name, protection, damage)
        {
            Rage = false;
        }

        private bool is_low { get; set; } = true;
        public bool Rage { get; set; }



        public void HeavyBlow(Unit unit)
        {
            if (is_low)
            {
                unit.Health += this.Damage * 2;
                is_low = false;
            }
            else
            {
                Console.WriteLine(this.Name + " low");
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

                if (base.Health < MaxHealth * 0.5 && !Rage)
                {
                    Rage = true;
                    Damage *= 1.5;
                    Console.WriteLine($"{Name} активировал рейдж!");
                }
                else if (base.Health >= MaxHealth * 0.5 && Rage)
                {
                    Rage = false;
                    Damage /= 1.5;
                    Console.WriteLine($"{Name} деактивировал рейдж!");
                }
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name}\nЗдоровье: {Health}/{MaxHealth}\nУрон: {Damage}\nСупер сила: {Rage}");
        }
    }
}

