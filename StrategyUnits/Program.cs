using StrategyUnits.Buildings;
using StrategyUnits.MilitaryUnits;
using StrategyUnits.MilitaryUnits.MagicUnits;
using StrategyUnits.PeacefulUnits;


// спавн юнитов
Footman enemyFootman = new Footman("Противник-болванчик");
Footman allyFootman = new Footman("Союзник-болванчик");
Archer enemyArcher = new Archer("Противник-лучник");
Peasant peasant = new Peasant();
Healer healer = new Healer();
Altar altar = new Altar("Психушка");


// поле действия
enemyFootman.MilitaryUnitHitEvent += FootmanAttack;
enemyFootman.MilitaryUnitNonHitEvent += Absorb;
enemyArcher.MilitaryUnitHitEvent += ArcherAttack;
enemyArcher.MilitaryUnitNonHitEvent += Absorb;

allyFootman.HealthChangedEvent += HPChanged;


enemyFootman.InflictDamage(allyFootman, enemyFootman);
enemyArcher.InflictDamage(allyFootman, enemyArcher);
allyFootman.ShowInfo();

Console.WriteLine();
healer.InflictHeal(allyFootman);

healer.ShowInfo();

Console.WriteLine();
altar.RegenMana(healer);

Console.WriteLine();
healer.ShowInfo();
// методы ивентов
static void FootmanAttack(string attackerName, string defenderName, int damage, int defense)
{
    Console.WriteLine($"{attackerName} ударил копьем и нанес {damage} урона");
    Console.WriteLine($"Броня {defenderName.ToLower()}а сдержала {defense} урона, но была пробита, прошло {damage-defense} урон(а)");
}

static void ArcherAttack(string attackerName, string defenderName, int damage, int defense)
{
    Console.WriteLine($"{attackerName} попал стрелой и нанес {damage} урона");
    Console.WriteLine($"Броня {defenderName.ToLower()}а сдержала {defense} урона, но была пробита, прошло {damage - defense} урон(а)");
}

static void Absorb(string attackerName, string defenderName, int damage, int defense)
{
    Console.WriteLine($"{attackerName} не нанес урона");
    Console.WriteLine($"Броня {defenderName.ToLower()}а ({defense}) поглотила весь урон ({damage})\n");
}

static void HPChanged(string name, int number)
{
    Console.WriteLine($"Теперь у {name.ToLower()}а - {number} хп\n");
}