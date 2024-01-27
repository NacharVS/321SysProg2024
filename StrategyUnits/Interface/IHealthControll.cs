namespace StrategyUnits.Interface
{
    internal interface IHealthControll
    {
        const int minHealth = 10;
        public  int Health { get; set; }
        public string Name { get; set; }

        public int MaxHealth { get; }

        public void TakeDamage(int damage);

        public void TakeHealth(int heal);
    }
}
