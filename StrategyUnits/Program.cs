using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Healer healer1 = new Healer();

ps1.HealthChangedEvent += Method;
ps1.HealthIncreasedEvent += MethodIn;
ps1.HealthDecreasedEvent += MethodDe;

footman2.HealthChangedEvent += Method;
footman2.HealthIncreasedEvent += MethodIn;
footman2.HealthDecreasedEvent += MethodDe;

ps1.ShowInfo();
footman2.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
ps1.ShowInfo();
footman2.ShowInfo();
footman2.ShowInfo();
healer1.InflictDamage(footman);
footman.ShowInfo();
healer1.InflictHeal(footman2);
healer1.InflictHeal(ps1);
ps1.ShowInfo();
footman2.ShowInfo();
healer1.ShowInfo();


static void Method(int number)
{
    Console.WriteLine($"Health has changed. Current: {number}");
}

static void MethodIn(int number)
{
    Console.WriteLine($"Health has increased. Current: {number}");
}

static void MethodDe(int number)
{
    Console.WriteLine($"Health has decreased. Current: {number}");
}

