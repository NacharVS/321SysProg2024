namespace StrategyUnits
{
    internal class Peasant : Unit
    {
        private bool is_work { get; set; } = true;

        public Peasant() : base(30, "Peasant") { }

        public void goWork()
        {
            if (is_work) {
                Console.WriteLine("Go work");
                is_work = false;
            }
            else
            {
                Console.WriteLine("Peasant working");
            }
        }
    }
}
