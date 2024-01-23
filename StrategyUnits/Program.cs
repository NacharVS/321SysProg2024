using StrategyUnits;
using StrategyUnits.Buildings;
using StrategyUnits.MilitaryUnits;
using StrategyUnits.MilitaryUnits.MagicUnits;
using StrategyUnits.PeacefulUnits;


// спавн юнитов
Altar altar = new Altar("Психушка");
Barrack barrack = new Barrack("Обэмэ");

Footman enemyFootman2 = barrack.RecruitAdvancedFootman();
Berserk allyBerserk = barrack.RecruitBerserk();
Palladin allyPalladin = barrack.RecruitPalladin();
Archer enemyArcher = barrack.RecruitBossArcher();
Peasant peasant = new Peasant();
Healer healer = barrack.RecruitBossHealer();


//поле действия
//enemyFootman.MilitaryUnitHitEvent += FootmanAttack;
SetEventsForMilitaryUnits(allyPalladin);
SetEventsForMilitaryUnits(allyBerserk);
SetEventsForMilitaryUnits(enemyFootman2);


//
enemyFootman2.ShowInfo();
allyPalladin.ShowInfo();

enemyFootman2.InflictDamage(allyPalladin);
enemyFootman2.InflictDamage(allyPalladin);
enemyFootman2.InflictDamage(allyPalladin);
enemyFootman2.InflictDamage(allyPalladin);
enemyFootman2.InflictDamage(allyPalladin);
enemyFootman2.InflictDamage(allyPalladin);
enemyFootman2.InflictDamage(allyPalladin);
enemyFootman2.InflictDamage(allyPalladin);

allyPalladin.InflictDamage(enemyFootman2);

allyPalladin.SelfHeal();

enemyFootman2.ShowInfo();
allyPalladin.ShowInfo();
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
static void SetEventsForMilitaryUnits(MilitaryUnit unit)
{
    unit.HealthIncreasedEvent += HPIncreased;
    unit.HealthDecreasedEvent += HPDecreased;
    unit.HealthNoChangeEvent += HPNoChange;
    unit.MilitaryUnitHitEvent += Attack;
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