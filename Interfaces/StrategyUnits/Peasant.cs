using StrategyUnits.Interfaces;

namespace StrategyUnits
{
    internal class Peasant : Unit, IPeaceful
    {
        public Peasant(string? name, double currentHealth, double maxHealth) : base(name, currentHealth, maxHealth)
        {
            IsWork = false;
        }

        public bool IsWork { get; set; }

        public void GoWork()
        {
            if (IsWork) {
                Console.WriteLine("Go work");
                IsWork = false;
            }
            else
            {
                Console.WriteLine("Peasant working");
            }
        }
    }
}
