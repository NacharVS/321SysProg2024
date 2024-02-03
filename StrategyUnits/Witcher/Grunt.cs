
using StrategyUnits.Interfaces;

namespace StrategyUnits.Witcher
{
    internal class Grunt : IHealthControll, IBattleUnit, IProtectedUnit
    {
        public Grunt()
        {
            Health = 120;
            Damage = 10;
            Defense = 5;
            Quantity = 5;
        }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
        public int Quantity { get; set; }
        public void Attack(IHealthControll unit)
        {
            unit.TakeDamage(Damage);
        }
        public void AddHealth(int quantity)
        {
            Health += Quantity;
        }
        public void TakeDamage(int damage)
        {
            Health -= damage - Defense;
        }
    }
}
