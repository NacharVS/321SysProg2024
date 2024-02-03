using StrategyUnits.Interfaces;

namespace StrategyUnits.Human
{
    internal class Archer : IHealthControll, IBattleUnit, IComboAttack
    {
        public Archer()
        {
            Health = 50;
            Damage = 10;
            Combo = 3;
        }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Combo { get; set; }

        public void AddHealth(int quantity)
        {
            Health += quantity;
        }

        public void Attack (IHealthControll unit)
        {
            int _doneCombo = 0;
            while(_doneCombo < Combo)
            {
                unit.TakeDamage(Damage);
                _doneCombo++;
            }
        }
        public void TakeDamage(int damage)
        {
            Health -= damage;
        }
    }
}
