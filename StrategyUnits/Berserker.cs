namespace StrategyUnits
{
    internal class Berserker : MilitaryUnit
    {
        private bool is_low { get; set; } = true;

        public Berserker() : base(100, "Berserker", 20) { }

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
    }
} 
