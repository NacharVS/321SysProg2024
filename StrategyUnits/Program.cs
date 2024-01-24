using StrategyUnits.Buildings;
using StrategyUnits.Units;

// спавн юнитов
Barrack barrack = new Barrack("Обэмэ", 1000);

Barbarian barbarian = barrack.TrainRegularBarbarian();
Barbarian enemyBarbarian = barrack.TrainRegularBarbarian();

// поле

barbarian.Attack(enemyBarbarian);
enemyBarbarian.Attack(barbarian);