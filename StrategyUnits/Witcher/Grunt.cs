using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Witcher
{
    internal class Grunt : IHealthControll, IBattleUnit, IProtectedUnit
    {
        public Grunt()
        {
            Health = 120;
            Damage = 10;
            Defense = 5;
        }
        public int Health { get; set; }
        public int Damage { get; set; }
        public int Defense { get; set; }
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
