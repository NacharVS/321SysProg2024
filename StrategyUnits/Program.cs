﻿using StrategyUnits.Buildings;
using StrategyUnits.MilitaryUnits;
using StrategyUnits.MilitaryUnits.MagicUnits;
using StrategyUnits.PeacefulUnits;


// спавн юнитов
Altar altar = new Altar("Психушка");
Barrack barrack = new Barrack("Обэмэ");

Footman enemyFootman = barrack.RecruitAdvancedFootman();
Berserk allyBerserk = barrack.RecruitBerserk();
Archer enemyArcher = barrack.RecruitBossArcher();
Peasant peasant = new Peasant();
Healer healer = barrack.RecruitBossHealer();


//поле действия
//enemyFootman.MilitaryUnitHitEvent += FootmanAttack;
enemyFootman.HealthIncreasedEvent += HPIncreased;
enemyFootman.HealthDecreasedEvent += HPDecreased;
enemyFootman.MilitaryUnitHitEvent += Attack;
allyBerserk.MilitaryUnitRageHitEvent += Attack;

//allyBerserk.RageEvent += FootmanAttack;
//allyBerserk.MilitaryUnitHitEvent += Absorb;
allyBerserk.HealthIncreasedEvent += HPIncreased;
allyBerserk.HealthDecreasedEvent += HPDecreased;

enemyFootman.InflictDamage(allyBerserk);

allyBerserk.InflictDamage(enemyFootman);

allyBerserk.ShowInfo();
enemyFootman.ShowInfo();

healer.InflictHeal(enemyFootman);

#region
//enemyFootman.MilitaryUnitHitEvent += FootmanAttack;
//enemyFootman.MilitaryUnitNonHitEvent += Absorb;

//enemyArcher.MilitaryUnitHitEvent += ArcherAttack;
//enemyArcher.MilitaryUnitNonHitEvent += Absorb;

//allyFootman.HealthChangedEvent += HPChanged;


//enemyFootman.InflictDamage(allyFootman, enemyFootman);
//enemyArcher.InflictDamage(allyFootman, enemyArcher);
//allyFootman.ShowInfo();

//Console.WriteLine();
//healer.InflictHeal(allyFootman);

//healer.ShowInfo();

//Console.WriteLine();
//altar.RegenMana(healer);

//Console.WriteLine();
//healer.ShowInfo();
#endregion
// методы ивентов
static void FootmanAttack(string attackerName, string defenderName, int damage, int defense)
{
    Console.WriteLine($"{attackerName} ударил копьем и нанес {damage} урона");
    Console.WriteLine($"Броня {defenderName.ToLower()} сдержала {defense} урона, но была пробита, прошло {damage-defense} урон(а)");
}

static void ArcherAttack(string attackerName, string defenderName, int damage, int defense)
{
    Console.WriteLine($"{attackerName} попал стрелой и нанес {damage} урона");
    Console.WriteLine($"Броня {defenderName.ToLower()} сдержала {defense} урона, но была пробита, прошло {damage - defense} урон(а)");
}

static void HPIncreased(string name, int number)
{
    Console.WriteLine($"ХП увеличено. Теперь у {name.ToLower()} - {number} хп\n");
}
static void HPDecreased(string name, int number)
{
    Console.WriteLine($"ХП уменьшено. Теперь у {name.ToLower()} - {number} хп\n");
}

static void Attack(string name, int damage)
{
    Console.WriteLine($"Атаковал {name} с уроном {damage}");
}