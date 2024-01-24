using StrategyUnits.Buildings;
using StrategyUnits.Units;

// спавн юнитов
Barrack barrack = new Barrack("Обэмэ", 1000);

Barbarian barbarian = barrack.TrainRegularBarbarian();
Barbarian enemyBarbarian = barrack.TrainNewbieBarbarian();
Healer healer = barrack.TrainHealer();

// поле
SetHealthTracker(barbarian);
SetHealthTracker(enemyBarbarian);
SetHealthTracker(healer);

barbarian.Attack(enemyBarbarian);
enemyBarbarian.Attack(barbarian);

healer.Heal(barbarian);
healer.ShowInfo();

// что-то для ивентов
static void SetHealthTracker(Unit unit)
{
    unit.HealthIncreasedEvent += HPIncreased;
    unit.HealthDecreasedEvent += HPDecreased;
    unit.HealthStayedEvent += HPStayed;
}

static void HPIncreased(int health, int maxHealth)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"{health}/{maxHealth}");
    Console.ResetColor();
}
static void HPDecreased(int health, int maxHealth)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{health}/{maxHealth}");
    Console.ResetColor();
}
static void HPStayed(int health, int maxHealth)
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine($"{health}/{maxHealth}");
    Console.ResetColor();
}