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
//enemyFootman.MilitaryUnitHitEvent += FootmanAttack;
enemyFootman.HealthIncreasedEvent += HPIncreased;
enemyFootman.HealthDecreasedEvent += HPDecreased;
enemyFootman.HealthNoChangeEvent += HPNoChange;
enemyFootman.MilitaryUnitHitEvent += Attack;
allyBerserk.MilitaryUnitRageHitEvent += Attack;

//allyBerserk.RageEvent += FootmanAttack;
//allyBerserk.MilitaryUnitHitEvent += Absorb;
allyBerserk.HealthIncreasedEvent += HPIncreased;
allyBerserk.HealthDecreasedEvent += HPDecreased;
allyBerserk.HealthNoChangeEvent += HPNoChange;

enemyFootman.InflictDamage(allyBerserk);
enemyFootman.InflictDamage(allyBerserk);
enemyFootman.InflictDamage(allyBerserk);

allyBerserk.InflictDamage(enemyFootman);

healer.InflictHeal(allyBerserk);

allyBerserk.InflictDamage(enemyFootman);

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

static void HPIncreased(string name, int health, int maxHealth)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"Теперь у {name.ToLower()} - {health}/{maxHealth}\n");
    Console.ResetColor();
}
static void HPDecreased(string name, int health, int maxHealth)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"Теперь у {name.ToLower()} - {health}/{maxHealth}\n");
    Console.ResetColor();
}

static void HPNoChange(string name, int health, int maxHealth)
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine($"Здоровье не затронуто ({name} - {health}/{maxHealth})\n");
    Console.ResetColor();
}

static void Attack(string name, int damage)
{
    Console.WriteLine($"{name} атаковал с уроном {damage}");
}