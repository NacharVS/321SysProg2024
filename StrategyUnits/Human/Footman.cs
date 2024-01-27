using StrategyUnits.Type;

namespace StrategyUnits.Human
{
    internal class Footman : militaryUnits
    {
        public Footman(int health, string? name, int defence, int min_damage, int max_damage) : base(health, name, defence, min_damage, max_damage)
        {
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Footman {Health}/{MaxHealth}");
        }
    }
}
