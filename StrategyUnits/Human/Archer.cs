using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyUnits.Interfaces;
using StrategyUnits.Type;

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
