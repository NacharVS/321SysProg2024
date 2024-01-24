using StrategyUnits.Interface;

namespace StrategyUnits.Units
{
    internal class Barbarian : Unit, IBattleUnit
    {
        public int Damage { get; set; }
        public Barbarian(int health, string? name) : base(health, name)
        {
            Damage = 10;
        }

        public void Attack(IHealthControll unit)
        {
            unit.TakeDamage(Damage);
        }
    }
}
