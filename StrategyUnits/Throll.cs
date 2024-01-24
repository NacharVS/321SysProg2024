namespace StrategyUnits
{
    internal class Throll : IHealthControll, IBattleUnit
    {
        public Throll()
        {
            Health = 120;
            Damage = 10;
        }

        public int Health { get; set; }
        public int Damage { get; set; }

        public void Attack(IHealthControll unit)
        {
            unit.TakeDamage(Damage);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
