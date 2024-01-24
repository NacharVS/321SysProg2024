namespace StrategyUnits
{
    internal class Grunt : IHealthControll, IProtectedUnit, IBattleUnit
    {
        public Grunt()
        {
            Health = 100;
            Defense = 3;
            Damage = 5;
        }

        public int Health { get; set; }
        public int Defense { get; set; }
        public int Damage { get; set; }

        public void Attack(IHealthControll unit)
        {
            unit.TakeDamage(Damage);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage - Defense;
        }
    }
}
