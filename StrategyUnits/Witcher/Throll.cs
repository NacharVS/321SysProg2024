using StrategyUnits.Interfaces;

namespace StrategyUnits.Witcher
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

        public void AddHealth(int quantity)
        {
            throw new NotImplementedException();
        }

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
