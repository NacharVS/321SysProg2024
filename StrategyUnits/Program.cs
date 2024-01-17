using StrategyUnits;

Footman enemy = new Footman();
Footman ally = new Footman();
Peasant peasant = new Peasant();
Healer healer = new Healer();
//Altar altar = new Altar("Психушка", 1000);


ally.HealthIncreasedEvent += MethodIncreased;
ally.HealthDecreasedEvent += MethodDecreased;
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
enemy.InflictDamage(ally);
ally.ShowInfo();
healer.InflictHeal(ally);
ally.ShowInfo();
healer.ShowInfo();

static void MethodIncreased(int number)
{
    Console.WriteLine($"Здоровье увеличено. Теперь {number}");
}
static void MethodDecreased(int number)
{
    Console.WriteLine($"Здоровье уменьшено. Теперь {number}");
}
