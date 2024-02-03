using StrategyUnits.Type;

namespace StrategyUnits.Human
{
    internal class Healer : magicUnit
    {
        private int _heal;

        public int Heal
        {
            get { return _heal; }
            set { _heal = value; }
        }

        public Healer() : base(50, "Healer", 0, 30, 2, 5)
        {
            _heal = 1;
        }
        public void AddHeal(Unit unit)
        {
            while (unit.Health < unit.MaxHealth && Mana > 0)
            {
                if (unit.Health + 1 >= unit.MaxHealth)
                {
                    unit.Health = unit.MaxHealth;
                    unit.HealDamage(Health);
                    Console.WriteLine($"{Name} вылечил {unit.Name}");
                }
                else
                {
                    unit.Health += _heal;
                    Mana -= 2;
                    if (Mana < 0)
                    {
                        Console.WriteLine("Нет маны!");
                    }
                }
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Юнит:{Name} Mana: {Mana}/{MaxMana} Здровье: {Health}/{MaxHealth}");
        }
    }
}
