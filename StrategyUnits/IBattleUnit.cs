﻿namespace StrategyUnits
{
    internal interface IBattleUnit
    {
        public int Damage { get; set; }

        public void Attack(IHealthControll unit);

    }
}
