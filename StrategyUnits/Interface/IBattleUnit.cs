namespace StrategyUnits.Interface
{
    internal interface IBattleUnit
    {
        const int minDamage = 1;
        public int Damage {get; set;}
        public void Attack(IHealthControll unit);
    }
}
