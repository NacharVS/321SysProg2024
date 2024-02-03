namespace StrategyUnits.Interface
{
    internal interface IBattleUnit
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public void Attack(IHealthControl unit);
    }
}
