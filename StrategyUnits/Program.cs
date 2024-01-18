using StrategyUnits;
using System;

class Program
{
    static void Main()
    {
        Footman footman1 = new Footman();
        Footman footman2 = new Footman();
        Peasant peasant = new Peasant();
        Doctor bishop = new Doctor();
        Altar altar = new Altar();
        Archer archer = new Archer();
        Berserker berserker = new Berserker();

        // Пехотинцы атакуют крестьянина
        footman1.InflictDamage(peasant);
        footman2.InflictDamage(peasant);

        // Крестьянин отображает информацию
        peasant.ShowInfo();

        // Епископ лечит крестьянина
        bishop.Heal(peasant);

        // Отображаем информацию об епископе и крестьянине после лечения
        bishop.ShowInfo();
        peasant.ShowInfo();

        // Стрелок стреляет в епископа
        archer.Shoot(bishop);

        // Берсерк атакует стрелка
        berserker.Attack(archer);

        // Отображаем информацию об архере и берсерке после атак
        archer.ShowInfo();
        berserker.ShowInfo();

        // Восстановление выносливости для епископа
        Doctor[] bishops = { bishop };
        altar.RecoveryStamina(bishops);

        // Отображаем информацию об епископе после восстановления выносливости
        bishop.ShowInfo();
    }
}