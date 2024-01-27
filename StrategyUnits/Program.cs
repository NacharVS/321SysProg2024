using StrategyUnits.Buildings;
using StrategyUnits.Units;

// спавн юнитов
Barrack barrack = new Barrack("Обэмэ", 1000);

Builder builder = new Builder("Боб строитель", 50);
Barbarian barbarian = barrack.TrainRegularBarbarian();
Lumberjack lumberjack = barrack.TrainLumberjack();
Palladin palladin = barrack.TrainPalladin();
Barbarian enemyBarbarian = barrack.TrainNewbieBarbarian();
Healer healer = barrack.TrainHealer();

// поле
SetHealthTracker(barbarian);
SetHealthTracker(lumberjack);
SetHealthTracker(palladin);
SetHealthTracker(enemyBarbarian);
SetHealthTracker(healer);
SetBuildingHealthTracker(barrack);

barbarian.Attack(barrack);
barbarian.Attack(barrack);
barbarian.Attack(barrack);
barrack.ShowInfo();
builder.Repair(barrack);
barrack.ShowInfo();


#region тест защита х2
//barbarian.ShowInfo();
//palladin.ShowInfo();

//barbarian.Attack(barbarian);
//barbarian.Attack(barbarian);
//barbarian.Attack(barbarian);
//barbarian.Attack(barbarian);
//barbarian.Attack(barbarian);
//barbarian.Attack(barbarian);
//barbarian.Attack(palladin);
//barbarian.Attack(palladin);
//barbarian.Attack(palladin);

//palladin.SelfHeal();
#endregion

#region тест рейдж мода
//barbarian.Attack(lumberjack);
//barbarian.Attack(lumberjack);
//barbarian.Attack(lumberjack);
//lumberjack.Attack(barbarian);

//healer.Heal(lumberjack);

//lumberjack.Attack(barbarian);
#endregion


// что-то для ивентов
static void SetHealthTracker(Unit unit)
{
    unit.HealthIncreasedEvent += HPIncreased;
    unit.HealthDecreasedEvent += HPDecreased;
    unit.HealthStayedEvent += HPStayed;
}
static void SetBuildingHealthTracker(Building building)
{
    building.HealthIncreasedEvent += HPIncreased;
    building.HealthDecreasedEvent += HPDecreased;
    building.HealthStayedEvent += HPStayed;
}

static void HPIncreased(int health, int maxHealth)
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine($"{health}/{maxHealth}\n");
    Console.ResetColor();
}
static void HPDecreased(int health, int maxHealth)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"{health}/{maxHealth}\n");
    Console.ResetColor();
}
static void HPStayed(int health, int maxHealth)
{
    Console.ForegroundColor = ConsoleColor.DarkGray;
    Console.WriteLine($"{health}/{maxHealth}\n");
    Console.ResetColor();
}