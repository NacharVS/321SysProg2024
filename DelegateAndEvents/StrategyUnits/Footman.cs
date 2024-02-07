namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        public Footman(int health, string? name, double protection, double damage) : base(health, name, protection, damage)
        {
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Персонаж: {Name}\nЗдоровье: {Health}/{MaxHealth}\nУрон: {Damage}");
        }
    }
}
