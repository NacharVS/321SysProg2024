using StrategyUnits.Type;

namespace StrategyUnits.Human
{
    internal class Knight : magicUnit
    {
        private int _heal;
        public Knight(int health, string? name, int defence, int mana, int min_damage, int max_damage) : base(health, name, defence, mana, min_damage, max_damage)
        {
            _heal = 20;
        }
        public void SelfHeal()
        {
            Console.WriteLine("Лечимся!");
            if (Health < MaxHealth && Mana > 0)
            {
                if (Health + 1 >= MaxHealth)
                {
                    Health = MaxHealth;
                    HealDamage(Health);
                    Console.WriteLine("Вылечен!");
                }
                else
                {
                    Health += _heal;
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
            Console.WriteLine($"Рыцарь {Health}/{MaxHealth}");
        }
    }
}
