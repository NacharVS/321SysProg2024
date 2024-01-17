namespace StrategyUnits
{
    internal class Peasant : Unit
    {
        public Peasant() : base(30, "Peasant", 0)
        {
        }

        public void RepairBuilding(Build build)
        {
            build.Health = build.MaxHealth;
            Console.WriteLine("Крестьянин починил здание " + build.Name);
        }
    }
}
