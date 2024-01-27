using StrategyUnits.Stats;

namespace StrategyUnits.Units
{
    internal class Unit : IHealth
    {
        public Unit(int health, string name)
        {
            MaxHealth = Health;
        }
        public int Health { get; set; }
        public int MaxHealth { get; set; }
        public string Name { get; set; }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
        public void TakeHeal(int heal)
        {
            Health += heal;
        }
        public virtual void ShowInfo()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($"GameObject: ");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write(Name);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write($" Health: ");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write($"{Health}/{MaxHealth}");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
