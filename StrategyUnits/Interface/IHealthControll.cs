namespace StrategyUnits.Interface
{
    internal interface IHealthControll
    {
        const int minHealth = 0;
        public  int Health { get; set; }
        public string? Name { get; set; }

        public void TakeDamage(int damage);

        public void TakeHeal(int heal);
    }
}
