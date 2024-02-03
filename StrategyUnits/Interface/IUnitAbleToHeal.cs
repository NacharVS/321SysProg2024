namespace StrategyUnits.Interface
{
    internal interface IUnitAbleToHeal
    {
        public int Heal { get; set; }
        public void InflictHeal(IHealthControl unit);

    }
}
