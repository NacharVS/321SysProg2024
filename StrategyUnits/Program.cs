using StrategyUnits.Buildings;
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
enemyFootman.MilitaryUnitHitEvent += FootmanAttack;
enemyFootman.MilitaryUnitNonHitEvent += Absorb;
enemyFootman.HealthChangedEvent += HPChanged;

//allyBerserk.RageEvent += FootmanAttack;
allyBerserk.MilitaryUnitNonHitEvent += Absorb;
allyBerserk.MilitaryUnitHitEvent += Absorb;
allyBerserk.HealthChangedEvent += HPChanged;

//enemyFootman.InflictDamage(allyBerserk, enemyFootman);
//enemyFootman.InflictDamage(allyBerserk, enemyFootman);
//enemyFootman.InflictDamage(allyBerserk, enemyFootman);
//enemyFootman.InflictDamage(allyBerserk, enemyFootman);
//enemyFootman.InflictDamage(allyBerserk, enemyFootman);
enemyFootman.InflictDamage(allyBerserk, enemyFootman);
enemyFootman.InflictDamage(allyBerserk, enemyFootman);

allyBerserk.ShowInfo();

allyBerserk.InflictDamage(enemyFootman, allyBerserk);
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

static void Absorb(string attackerName, string defenderName, int damage, int defense)
{
    Console.WriteLine($"{attackerName} не нанес урона");
    Console.WriteLine($"Броня {defenderName.ToLower()} ({defense}) поглотила весь урон ({damage})\n");
}

static void HPChanged(string name, int number)
{
    Console.WriteLine($"Теперь у {name.ToLower()} - {number} хп\n");
}