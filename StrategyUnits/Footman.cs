namespace StrategyUnits
{
    internal class Footman : MillitaryUnit
    {
        public Footman() : base(60, "Footman", 1, 1, 5)
        {
            
        }

        public void InflictDamage(Unit unit)
        {
            unit.Health -= _damage;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"Unit:{Name} Health:{Health}/{MaxHealth} Damage:{_damage}");
        }

    }
}
