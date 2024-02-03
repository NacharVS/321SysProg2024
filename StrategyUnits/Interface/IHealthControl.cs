namespace StrategyUnits.Interface
{
    internal interface IHealthControl
    {
        public int MaxHealth { get; set; }
        public int Health { get; set; }
        string Name { get; set; }
        public bool IsDead { get; set; }

        public void TakeDamage(int Damage);
        public void TakeHeal(int Health);
    }
}
