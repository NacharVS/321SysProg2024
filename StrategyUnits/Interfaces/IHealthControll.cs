
namespace StrategyUnits.Interfaces
{
    internal interface IHealthControll
    {
        public int Health { get; set; }
        public void TakeDamage(int damage);
        public void AddHealth(int quantity);
    }
}