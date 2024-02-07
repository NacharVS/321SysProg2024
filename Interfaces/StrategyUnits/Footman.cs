using StrategyUnits.Interfaces;

namespace StrategyUnits
{
    internal class Footman : Unit, IAttack
    {
        public Footman(string? name, double currentHealth, double maxHealth, double damage) : base(name, currentHealth, maxHealth)
        {
            Damage = damage;
        }

        public double Damage { get; set; }

        public void Attack(IHealth unit)
        {
            unit.DecreaseHealth(Damage);
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name}\nЗдоровье: {Health}/{MaxHealth}\nУрон: {Damage}");
        }
    }
}
